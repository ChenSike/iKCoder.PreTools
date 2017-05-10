using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iKCoderDU;
using iKCoder_Platform_SDK_Kit;
using System.Xml;

namespace iKCoderDU
{
    public partial class MessageRegRouter : Forms_NoBorderBaseform
    {
        class_Net_RemoteRequest object_remote;
        Dictionary<string, XmlNode> messageDic = new Dictionary<string, XmlNode>();

        public string activeServerUrl
        {
            set;
            get;
        }

        public MessageRegRouter(class_Net_RemoteRequest refNetObject)
        {
            object_remote = refNetObject;
            InitializeComponent();
        }

        private void MessageRegRouter_Load(object sender, EventArgs e)
        {
            flushList();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            flushList();
        }

        protected void flushList()
        {
            string url = activeServerUrl + "/Message/api_Message_GetMessageRouterList.aspx";
            string result = object_remote.getRemoteRequestToStringWithCookieHeader("<root></root>", url, 1000 * 60, 100000);
            XmlDocument resultDoc = new XmlDocument();
            resultDoc.LoadXml(result);
            XmlNodeList msgNodes = resultDoc.SelectNodes("/root/msg");
            cmb_symbols.Items.Clear();
            messageDic.Clear();
            foreach(XmlNode activeMsgNode in msgNodes)
            {
                string symbol = class_XmlHelper.GetAttrValue(activeMsgNode, "symbol");
                cmb_symbols.Items.Add(symbol);
                messageDic.Add(symbol, activeMsgNode);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmb_symbols.Text!="")
            {
                if (!cmb_symbols.Items.Contains(cmb_symbols.Text))
                {
                    string url = activeServerUrl + "/Message/api_Message_RegRouter.aspx?symbol=" + cmb_symbols.Text + "&pushapi=" + txt_pushapi.Text + "&getapi=" + txt_getapi.Text;
                    string result = object_remote.getRemoteRequestToStringWithCookieHeader("<root></root>", url, 1000 * 60, 1024*1024);
                    if(result.Contains("<err"))
                    {
                        MessageBox.Show("无法注册信息路由，请检查内容的合法性.");
                    }
                    else
                    {
                        MessageBox.Show("成功注册信息路由。");
                        flushList();
                    }
                }
                else
                    MessageBox.Show("请更换symbol的内容，此symbol已经存在。");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmb_symbols.Text != "")
            {
                XmlNode activeNode = messageDic[cmb_symbols.Text];
                if (activeNode != null)
                {
                    string id = class_XmlHelper.GetAttrValue(activeNode, "id");
                    string url = activeServerUrl + "/Message/api_Message_RemoveRouter.aspx?id=" + id;
                    string result = object_remote.getRemoteRequestToStringWithCookieHeader("<root></root>", url, 1000 * 60, 1024 * 1024);
                    if (result.Contains("<err"))
                    {
                        MessageBox.Show("无法删除信息路由，请检查内容的合法性.");
                    }
                    else
                    {
                        MessageBox.Show("成功删除信息路由。");
                        flushList();
                    }
                }
                else
                {
                    MessageBox.Show("无法找到对应的ROUTER。");
                }
            }
            else
            {
                MessageBox.Show("请选择需要删除的ROUTER后进行操作.");
            }
        }
    }
}
