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
    public partial class ImportTextData : Forms_NoBorderBaseform
    {

        class_Net_RemoteRequest object_remote;
        CookieContainer activeContainer = new CookieContainer();

        public string activeServerUrl
        {
            set;
            get;
        }

        public ImportTextData()
        {
            InitializeComponent();
        }

        private void ImportTextData_Load(object sender, EventArgs e)
        {
            this.object_remote = new class_Net_RemoteRequest(ref activeContainer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(activeServerUrl))
            {
                if (!string.IsNullOrEmpty(txt_symbol.Text))
                {
                    if (!string.IsNullOrEmpty(cmb_produce.Text))
                    {
                        string verifiedSymbolExistedURL = activeServerUrl + "/Data/api_GetVerifySymbolExisted.aspx?symbol=" + txt_symbol.Text + "&produce=" + cmb_produce.Text;
                        string result = object_remote.getRemoteXMLRequestToString("<root></root>", activeServerUrl, 1000 * 60, 100000, null);                        
                        if(result.Contains("true"))
                        {
                            MessageBox.Show("很抱歉，您输入的标识数据已经存在，请更改后导入数据。");
                        }
                        else
                        {
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("很抱歉，归属产品不可空。");
                    }
                }
                else
                {
                    MessageBox.Show("很抱歉，数据标识不可空。");
                }
            }
            else
            {
                MessageBox.Show("没有选择正确的服务器配置，请先选择后再导入数据。");
            }
        }
    }
}
