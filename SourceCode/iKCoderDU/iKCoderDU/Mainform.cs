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

namespace iKCoderDU
{
    public partial class Mainform : Forms_NoBorderBaseform
    {

        class_Net_RemoteRequest object_remote = new class_Net_RemoteRequest();
        List<Cookie> object_cookies = new List<Cookie>();
        bool is_connected = false;

        public Mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmb_server.Text) && !string.IsNullOrEmpty(cmb_produce.Text))
            {
                string input = "<root><name>" + cmb_produce.Text + "</name><code>" + cmb_code.Text + "</code></root>";
                string requestURL = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + "/Token/api_getToken.aspx";
                object_cookies = object_remote.getRemoteServerCookie(requestURL, input);
                if(object_cookies.Count>0)
                {
                    lst_cookies.Items.Clear();
                    foreach(Cookie activeCookie in object_cookies)
                    {
                        ListViewItem newItem = new ListViewItem(activeCookie.Name);
                        newItem.SubItems.Add(activeCookie.Value);
                        lst_cookies.Items.Add(newItem);
                    }
                    lb_serverstatus.Text = "服务器状态：已经取得服务器TOKEN授权.";
                    is_connected = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
