using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iKCoder_Platform_SDK_Kit;
using System.Xml;
using System.Text;

namespace iKCoderDU
{
    public partial class messsageController : Forms_NoBorderBaseform
    {
        class_Net_RemoteRequest object_remote;
        Dictionary<string, XmlNode> data_buffer = new Dictionary<string, XmlNode>();

        public messsageController(class_Net_RemoteRequest refRemoteObject)
        {
            object_remote = refRemoteObject;
            InitializeComponent();
        }

        public string activeHost
        {
            set;
            get;
        }

        private void messsageController_Load(object sender, EventArgs e)
        {
            flushMessage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder inputDoc = new StringBuilder();
                inputDoc.Append("<root>");
                inputDoc.Append("<title>");
                inputDoc.Append(txt_title.Text);
                inputDoc.Append("</title>");
                inputDoc.Append("<username>");
                inputDoc.Append(cmb_to.Text == "everyone" ? "all" : cmb_to.Text);
                inputDoc.Append("</username>");
                inputDoc.Append("<message>");
                inputDoc.Append(txt_message.Text);
                inputDoc.Append("</message>");
                inputDoc.Append("<type>sys</type>");
                inputDoc.Append("</root>");             
                string getArrUrl = "api_Message_NewMessage.aspx?operation=" + GlobalDefined.iKCoderOperationCode;
                string requestURL = activeServerUrl + "/Message/" + getArrUrl;
                string result = object_remote.getRemoteRequestToStringWithCookieHeader(inputDoc.ToString(), requestURL, 1000 * 60, 1024 * 1024);
                XmlDocument resultDoc = new XmlDocument();
                resultDoc.LoadXml(result);
                XmlNode msgNode = resultDoc.SelectSingleNode("/root/msg");
                string messageid = class_XmlHelper.GetAttrValue(msgNode, "id");
                getArrUrl = "api_Message_Send.aspx?operation=" + GlobalDefined.iKCoderOperationCode + "&messageid=" + messageid + "&istop=" + (istop.Checked ? "1" : "0") + "&to=" + (cmb_to.Text == "everyone" ? "all" : cmb_to.Text);
                requestURL = activeServerUrl + "/Message/" + getArrUrl;
                result = object_remote.getRemoteRequestToStringWithCookieHeader(inputDoc.ToString(), requestURL, 1000 * 60, 1024 * 1024);
                if (!result.Contains("<err"))
                {
                    MessageBox.Show("发送成功。");
                    flushMessage();
                }
            }
            catch
            {
                MessageBox.Show("无法联系服务器，请检查网络配置。");
            }
        }

        public string activeServerUrl
        {
            set;
            get;
        }

        protected void flushMessage()
        {
            try
            {
                string getArrUrl = "api_Message_GetList.aspx?operation=" + GlobalDefined.iKCoderOperationCode;
                string requestURL = activeServerUrl + "/Message/" + getArrUrl;
                string result = object_remote.getRemoteRequestToStringWithCookieHeader("<root></root>", requestURL, 1000 * 60, 1024 * 1024);
                XmlDocument toolBoxDoc = new XmlDocument();
                toolBoxDoc.LoadXml(result);
                XmlNodeList msgNodes = toolBoxDoc.SelectNodes("/root/msg");
                lst_message.Items.Clear();
                data_buffer.Clear();
                foreach (XmlNode msgNode in msgNodes)
                {
                    string id = class_XmlHelper.GetAttrValue(msgNode, "id");
                    string title = class_XmlHelper.GetAttrValue(msgNode, "title");
                    ListViewItem newLVI = new ListViewItem();
                    newLVI.Text = id;
                    newLVI.SubItems.Add(title);
                    lst_message.Items.Add(newLVI);
                    data_buffer.Add(id, msgNode);
                }
            }
            catch
            {
                MessageBox.Show("无法联系服务器，请检查网络配置。");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string id = string.Empty;
                id = lst_message.SelectedItems[0].Text;
                string getArrUrl = "api_Message_RemoveMessage.aspx?id=" + id;
                string requestURL = activeServerUrl + "/Message/" + getArrUrl;
                string result = object_remote.getRemoteRequestToStringWithCookieHeader("<root></root>", requestURL, 1000 * 60, 1024 * 1024);
                if(result.Contains("<err"))
                {
                    MessageBox.Show("执行操作失败。");
                }
                else
                {
                    MessageBox.Show("成功执行操作.");
                    flushMessage();
                }
            }
            catch
            {
                MessageBox.Show("无法联系服务器，请检查网络配置。");
            }
        }

        private void lst_message_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = string.Empty;
            id = lst_message.SelectedItems[0].Text;
            if(data_buffer.ContainsKey(id))
            {
                XmlNode activeMsgNode = data_buffer[id];
                if(activeMsgNode!=null)
                {
                    string title = class_XmlHelper.GetAttrValue(activeMsgNode, "title");
                    string message = class_XmlHelper.GetAttrValue(activeMsgNode, "message");
                    txt_title.Text = title;
                    txt_message.Text = message;
                }
            }
        }
    }
}
