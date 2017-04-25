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

        public string activeServerUrl
        {
            set;
            get;
        }

        public ImportTextData(class_Net_RemoteRequest refNetObject)
        {
            object_remote = refNetObject;
            InitializeComponent();
        }

        private void ImportTextData_Load(object sender, EventArgs e)
        {
            try
            {
                string getArrUrl = "api_GetDataAggInfo.aspx?cid=" + GlobalVars.cid;
                string requestURL = activeServerUrl + "/data/" + getArrUrl;
                string result = object_remote.getRemoteRequestToStringWithCookieHeader("<root></root>", requestURL, 1000 * 60, 100000);
                XmlDocument resultDoc = new XmlDocument();
                resultDoc.LoadXml(result);
                cmb_relationshipchild_symbolsearching.Items.Clear();
                if (cmb_relationshipchild_symbolsearching.Text == "")
                {
                    XmlNodeList msgNodeList = resultDoc.SelectNodes("/root/msg");
                    foreach (XmlNode activeMsgNode in msgNodeList)
                    {
                        string symbol = class_XmlHelper.GetAttrValue(activeMsgNode, "symbol");
                        cmb_relationshipchild_symbolsearching.Items.Add(symbol);
                    }
                }
                else
                {
                    XmlNode searchNode = resultDoc.SelectSingleNode("/root/msg[@symbol='" + cmb_relationshipchild_symbolsearching.Text + "']");
                    if (searchNode != null)
                    {
                        cmb_relationshipchild_symbolsearching.Items.Add(cmb_relationshipchild_symbolsearching.Text);
                    }
                }

            }
            catch
            {
                MessageBox.Show("系统访问API出差，请检查参数或者网络。");
            }
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
                        string verifiedSymbolExistedURL = activeServerUrl + "/Data/api_GetVerifySymbolExisted.aspx?symbol=" + txt_symbol.Text + "&cid=" + GlobalVars.cid;
                        string result = object_remote.getRemoteRequestToStringWithCookieHeader("<root></root>", verifiedSymbolExistedURL, 1000 * 60, 100000);
                        if (result.Contains("true"))
                        {
                            MessageBox.Show("您输入的标识数据已经存在，会刷新数据。");
                        }
                        string inputData = class_CommonUtil.Encoder_Base64(txt_data.Text);
                        string inputDoc = "<root><symbol>" + txt_symbol.Text + "</symbol><data>" + inputData + "</data><type>text</type></root>";
                        verifiedSymbolExistedURL = activeServerUrl + "/Data/api_SetOverMetaTextData.aspx?cid=" + GlobalVars.cid;
                        result = object_remote.getRemoteRequestToStringWithCookieHeader(inputDoc, verifiedSymbolExistedURL, 1000 * 60, 100000);
                        if (result.Contains("true"))
                        {
                            MessageBox.Show("您已经成功导入数据，点击确定返回主界面。");
                            txt_url.Text = activeServerUrl + "/Data/api_GetMetaText.aspx?symbol=" + txt_symbol.Text;
                            
                        }
                        else
                        {
                            MessageBox.Show("很抱歉，导入数据失败，无法处理此错误，请联系管理员。");
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmb_relationshipchild_symbolsearching.Text))
            {
                txt_symbol.Text = cmb_relationshipchild_symbolsearching.Text;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmb_relationshipchild_symbolsearching_SelectedIndexChanged(object sender, EventArgs e)
        {
            string url = activeServerUrl + "/Data/api_GetMetaTextBase64Data.aspx?cid=" + GlobalVars.cid + "&symbol=" + cmb_relationshipchild_symbolsearching.Text;
            string result = object_remote.getRemoteRequestToStringWithCookieHeader("<root></root>", url, 1000 * 60, 100000);
            XmlDocument resultDoc = new XmlDocument();
            resultDoc.LoadXml(result);
            XmlNode msgNode = resultDoc.SelectSingleNode("/root/msg");
            if (msgNode != null)
            {
                string data = class_XmlHelper.GetAttrValue(msgNode, "msg");
                txt_data.Text = class_CommonUtil.Decoder_Base64(data);
            }
            else
                MessageBox.Show("无法获取数据，请联系系统管理员.");
        }
    }
}
