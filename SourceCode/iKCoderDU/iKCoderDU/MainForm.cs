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
using System.Net;
using System.Xml;
using System.IO;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;

namespace iKCoderDU
{
    public partial class MainForm : Forms_NoBorderBaseform
    {

        class_Net_RemoteRequest object_remote;
        List<Cookie> object_cookies = new List<Cookie>();
        bool is_connected = false;
        Dictionary<string, string> urlMap = new Dictionary<string, string>();
        CookieContainer activeContainer = new CookieContainer();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.object_remote = new class_Net_RemoteRequest(ref activeContainer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmb_server.Text) && !string.IsNullOrEmpty(cmb_produce.Text))
            {
                string input = "<root><name>" + cmb_produce.Text + "</name><code>" + cmb_code.Text + "</code></root>";
                string requestURL = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + "/Token/api_getToken.aspx";
                object_cookies = object_remote.getRemoteServerCookie(requestURL,input);
                if(object_cookies.Count>0)
                {
                    lst_cookies.Items.Clear();
                    foreach(Cookie activeCookie in object_cookies)
                    {
                        ListViewItem newItem = new ListViewItem(activeCookie.Name);
                        newItem.SubItems.Add(activeCookie.Value);
                        lst_cookies.Items.Add(newItem);
                        activeContainer.Add(activeCookie);
                    }
                    lb_serverstatus.Text = "服务器状态：已经取得服务器TOKEN授权.";
                    is_connected = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void lst_cookies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void 重新创建对应服务器的所有SPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (is_connected)
            {
                string requestURL = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + "/Data/api_BuildAllSPS.aspx?keycode=AllowPlatformOperation";
                string responseFromServer = object_remote.getRemoteRequestToString("<root></root>", requestURL, 1000, 1000, null);
                XmlDocument responseDoc = new XmlDocument();
                responseDoc.LoadXml(responseFromServer);
                XmlNode msgNode = responseDoc.SelectSingleNode("/root/msg[@code='executed']");
                if (msgNode != null)
                    MessageBox.Show("已经成功完成自定动作.");
                else
                {
                    MessageBox.Show("无法完成指定动作,请点击确定后查看文档.");
                    MessageBox.Show(responseFromServer);
                }
            }
            else
                MessageBox.Show("请先取得服务器授权后再进行动作.");
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                string requestURL = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + cmb_URL.Text;
                string result = object_remote.getRemoteXMLRequestToString(txtInput.Text, requestURL, 1000 * 60, 100000, null);
                txtResult.Text = result;
            }
            catch
            {
                MessageBox.Show("系统访问API出差，请检查参数或者网络。");
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string requestURL = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + cmb_URL.Text;
                byte[] data = object_remote.getRemoteXMLRequestToByte("<root></root>", requestURL, 1000 * 60, 100000, null);
                MemoryStream ms = new MemoryStream();
                ms.Write(data, 0, data.Length);
                Image activeImage = Image.FromStream(ms);
                pic_bindata.Image = activeImage;
            }
            catch
            {
                MessageBox.Show("系统访问API出差，请检查参数或者网络。");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                string requestURL = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + cmb_URL.Text;
                string result = object_remote.getRemoteRequestToStringWithCookieHeader(txtInput.Text, requestURL, 1000 * 60, 100000);
                txtResult.Text = result;
            }
            catch
            {
                MessageBox.Show("系统访问API出差，请检查参数或者网络。");
            }
        }

        protected void Flush_ResourceLst()
        {
            try
            {
                string getArrUrl = "api_GetDataAggInfo.aspx";
                string requestURL = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + "/data/" + getArrUrl;
                string result = object_remote.getRemoteXMLRequestToString("<root></root>", requestURL, 1000 * 60, 100000, null);
                XmlDocument resultDoc = new XmlDocument();
                resultDoc.LoadXml(result);
                XmlNodeList msgNodeList = resultDoc.SelectNodes("/root/msg");
                if (msgNodeList.Count == 0)
                {
                    MessageBox.Show("没有发现数据。");
                    return;
                }
                else
                {
                    lst_resource.Items.Clear();
                    foreach (XmlNode activeMsgNode in msgNodeList)
                    {
                        string id = class_XmlHelper.GetAttrValue(activeMsgNode, "id");
                        ListViewItem lstRootItem = new ListViewItem();
                        lstRootItem.Text = id;
                        lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "symbol"));
                        lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "type"));
                        lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "produce"));
                        lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "isBinary"));
                        lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "isBase64"));
                        lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "isDES"));
                        lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "DESKey"));
                        lst_resource.Items.Add(lstRootItem);
                    }
                }
            }
            catch
            {
                MessageBox.Show("系统访问API出差，请检查参数或者网络。");
            }
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            Flush_ResourceLst();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ImportTextData form = new ImportTextData(this.object_remote);
            form.activeServerUrl = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text;
            form.ShowDialog();
            Flush_ResourceLst();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ImportBinData form = new ImportBinData(this.object_remote);
            form.activeServerUrl = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text;
            form.ShowDialog();
            Flush_ResourceLst();
        }
  
    }
}
