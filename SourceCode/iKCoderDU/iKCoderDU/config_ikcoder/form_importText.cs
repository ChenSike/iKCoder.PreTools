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

namespace iKCoderDU.config_ikcoder
{
    public partial class form_importText : Forms_NoBorderBaseform
    {
        class_Net_RemoteRequest object_remote;

        public string activeServerUrl
        {
            set;
            get;
        }

        public form_importText(class_Net_RemoteRequest refRemoteObject)
        {
            object_remote = refRemoteObject;
            InitializeComponent();
        }

        private void form_importText_Load(object sender, EventArgs e)
        {
            flushResourceList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flushResourceList()
        {
            string getArrUrl = "api_iKCoder_Data_Get_AggResourceText.aspx?operation=" + GlobalDefined.iKCoderOperationCode;
            string requestURL = activeServerUrl + "/Data/" + getArrUrl;
            string result = object_remote.getRemoteRequestToStringWithCookieHeader("<root></root>", requestURL, 1000 * 60, 1024 * 1024);
            XmlDocument toolBoxDoc = new XmlDocument();
            toolBoxDoc.LoadXml(result);
            XmlNodeList msgNodes = toolBoxDoc.SelectNodes("/root/msg");
            cmbSymbol.Items.Clear();
            foreach (XmlNode msgNode in msgNodes)
            {
                string symbol = class_XmlHelper.GetAttrValue(msgNode, "msg");
                cmbSymbol.Items.Add(symbol);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flushResourceList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbSymbol.Text))
            {
                string getArrUrl = "api_iKCoder_Data_Set_TextData.aspx?operation=" + GlobalDefined.iKCoderOperationCode + "&symbol=" + cmbSymbol.Text;
                string requestURL = activeServerUrl + "/Data/" + getArrUrl;
                string result = object_remote.getRemoteRequestToStringWithCookieHeader(txtConfig.Text, requestURL, 1000 * 60, 1024 * 1024);
                if (result.Contains("err"))
                {
                    MessageBox.Show("更新失败。");
                }
                else
                {
                    MessageBox.Show("更新成功。");
                }
            }
        }

        private void cmbSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbSymbol.Text))
            {
                string getArrUrl = "api_iKCoder_Data_Get_ResourceText.aspx?operation=" + GlobalDefined.iKCoderOperationCode + "&symbol=" + cmbSymbol.Text;
                string requestURL = activeServerUrl + "/Data/" + getArrUrl;
                string result = object_remote.getRemoteRequestToStringWithCookieHeader(txtConfig.Text, requestURL, 1000 * 60, 1024 * 1024);
                txtConfig.Text = result;
            }
        }
    }
}
