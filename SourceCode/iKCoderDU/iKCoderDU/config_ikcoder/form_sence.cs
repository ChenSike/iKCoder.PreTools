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
    public partial class form_sence : Forms_NoBorderBaseform
    {
        class_Net_RemoteRequest object_remote;

        public form_sence(class_Net_RemoteRequest refRemoteObject)
        {
            object_remote = refRemoteObject;
            InitializeComponent();
        }

        private void form_sence_Load(object sender, EventArgs e)
        {
            flushSence();
        }

        public string activeServerUrl
        {
            set;
            get;
        }

        private void flushSence()
        {
            string getArrUrl = "api_iKCoder_Workspace_Get_AggSence.aspx?operation=" + GlobalDefined.iKCoderOperationCode;
            string requestURL = activeServerUrl + "/Bus/Workspace/" + getArrUrl;
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbSymbol.Text))
            {
                string getArrUrl = "api_iKCoder_Workspace_Get_Sence.aspx?operation=" + GlobalDefined.iKCoderOperationCode + "&symbol=" + cmbSymbol.Text;
                string requestURL = activeServerUrl + "/Bus/Workspace/" + getArrUrl;
                string result = object_remote.getRemoteRequestToStringWithCookieHeader("<root></root>", requestURL, 1000 * 60, 1024 * 1024);
                txtConfig.Text = result;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbSymbol.Text))
            {
                StringBuilder inputDocument = new StringBuilder();               
                string isfree = chkFreeSence.Checked ? "1" : "0";
                string getArrUrl = "api_iKCoder_Workspace_Set_Sence.aspx?operation=" + GlobalDefined.iKCoderOperationCode + "&isfree=" + isfree + "&symbol=" + cmbSymbol.Text;
                string requestURL = activeServerUrl + "/Bus/Workspace/" + getArrUrl;
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

        private void button2_Click(object sender, EventArgs e)
        {
            flushSence();
        }
    }
}
