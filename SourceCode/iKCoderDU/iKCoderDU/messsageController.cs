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

        public messsageController(class_Net_RemoteRequest refRemoteObject)
        {
            InitializeComponent();
        }

        private void messsageController_Load(object sender, EventArgs e)
        {
        
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
                inputDoc.Append(cmb_to.Text);
                inputDoc.Append("</username>");
                inputDoc.Append("<message>");
                inputDoc.Append(txt_message.Text);
                inputDoc.Append("</message>");
                inputDoc.Append("<type>sys</type>");
                inputDoc.Append("</root>");
             
                string getArrUrl = "api_Message_NewMessage.aspx?operation=" + GlobalDefined.iKCoderOperationCode;
                string requestURL = activeServerUrl + "/Message/" + getArrUrl;
                string result = object_remote.getRemoteRequestToStringWithCookieHeader("<root></root>", requestURL, 1000 * 60, 1024 * 1024);
                XmlDocument toolBoxDoc = new XmlDocument();
                toolBoxDoc.LoadXml(result);
                XmlNodeList msgNodes = toolBoxDoc.SelectNodes("/root/msg");
                lst_message.Items.Clear();
                foreach (XmlNode msgNode in msgNodes)
                {
                    string id = class_XmlHelper.GetAttrValue(msgNode, "id");
                    string title = class_XmlHelper.GetAttrValue(msgNode, "title");
                    ListViewItem newLVI = new ListViewItem();
                    newLVI.Text = id;
                    newLVI.SubItems.Add(title);
                    lst_message.Items.Add(newLVI);
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
                foreach (XmlNode msgNode in msgNodes)
                {
                    string id = class_XmlHelper.GetAttrValue(msgNode, "id");
                    string title = class_XmlHelper.GetAttrValue(msgNode, "title");
                    ListViewItem newLVI = new ListViewItem();
                    newLVI.Text = id;
                    newLVI.SubItems.Add(title);
                    lst_message.Items.Add(newLVI);
                }
            }
            catch
            {
                MessageBox.Show("无法联系服务器，请检查网络配置。");
            }
        }

    }
}
