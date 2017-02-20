﻿using System;
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
                        if(result.Contains("true"))
                        {
                            MessageBox.Show("很抱歉，您输入的标识数据已经存在，请更改后导入数据。");
                        }
                        else
                        {
                            string inputData = class_CommonUtil.Encoder_Base64(txt_data.Text);
                            string inputDoc = "<root><symbol>" + txt_symbol.Text + "</symbol><data>" + inputData + "</data><type>text</type></root>";
                            verifiedSymbolExistedURL = activeServerUrl + "/Data/api_SetMetaTextData.aspx?cid=" + GlobalVars.cid;
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
