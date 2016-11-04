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
using System.IO;
using System.Xml;

namespace iKCoder.SecurityCoder
{
    public partial class Form_Main : iKCoder_Platform_SDK_Kit.Forms_NoBorderBaseform
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            ref_TextBox_DragDropFilename = txt_SourceFilePath;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ObjectFilePath_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string[] sourceFilePathItems = null;
                FileInfo sourceFile = null;
                string objectFilePath = "";
                if (txt_SourceFilePath.Text == "")
                {
                    MessageBox.Show("请选中需要进行编码的文件.");
                    return;
                }
                else if (txt_ObjectFilePath.Text == "")
                {
                    MessageBox.Show("目标文件夹为空,系统默认输出至源文件文件夹.");
                }
                else if (txt_CoderKey.Text == "")
                {
                    MessageBox.Show("编码KEY不可为空，使用默认KEY：ASDFGHJK");
                    txt_CoderKey.Text = "ASDFGHJK";
                }
                sourceFile = new FileInfo(txt_SourceFilePath.Text);
                sourceFilePathItems = txt_SourceFilePath.Text.Split('\\');
                if (sourceFile.Exists)
                {
                    byte[] fileData = iKCoder_Platform_SDK_Kit.Util_Common.Action_GetBytesFromFile(txt_SourceFilePath.Text);
                    string base64Result = iKCoder_Platform_SDK_Kit.Util_Common.Encoder_Base64(fileData);
                    iKCoder_Platform_SDK_Kit.Security_DES obj = new Security_DES(txt_CoderKey.Text);
                    string desContent = "";
                    obj.DESCoding(base64Result, out desContent);
                    XmlDocument doc = new XmlDocument();
                    string dataContent = "<root><source>" + sourceFilePathItems[sourceFilePathItems.Length - 1] + "</source><data>" + desContent + "</data></root>";
                    doc.LoadXml(dataContent);
                    objectFilePath = txt_SourceFilePath.Text + ".xml";
                    if (txt_ObjectFilePath.Text != "")
                    {
                        objectFilePath = txt_ObjectFilePath.Text + "\\" + sourceFilePathItems[sourceFilePathItems.Length - 1] + ".xml";
                    }
                    doc.Save(objectFilePath);
                    MessageBox.Show("编码文件完成.");
                }
                else
                {
                    MessageBox.Show("文件不存在，请检查.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("编码失败，请联系管理员.");
                return;
            }

        }

        private void txt_ObjectFilePath_MouseClick(object sender, MouseEventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_ObjectFilePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string[] sourceFilePathItems = null;
                FileInfo sourceFile = null;
                string objectFilePath = "";
                if (txt_SourceFilePath.Text == "")
                {
                    MessageBox.Show("请选中需要进行编码的文件.");
                    return;
                }
                else if (txt_ObjectFilePath.Text == "")
                {
                    MessageBox.Show("目标文件夹为空,系统默认输出至源文件文件夹.");
                }
                else if (txt_CoderKey.Text == "")
                {
                    MessageBox.Show("编码KEY不可为空，使用默认KEY：ASDFGHJK");
                    txt_CoderKey.Text = "ASDFGHJK";
                }    
                XmlDocument doc = new XmlDocument();
                doc.Load(txt_SourceFilePath.Text);
                string sourceFilePath = doc.SelectSingleNode("/root/source").InnerText;
                string dataContent = doc.SelectSingleNode("/root/data").InnerText;
                iKCoder_Platform_SDK_Kit.Security_DES obj = new Security_DES(txt_CoderKey.Text);
                string dataDesContent = "";
                obj.DESDecoding(dataContent, out dataDesContent);
                byte[] byteData = iKCoder_Platform_SDK_Kit.Util_Common.Decoder_Base64ToByte(dataDesContent);
                objectFilePath = (txt_ObjectFilePath.Text != "" ? txt_ObjectFilePath.Text : txt_SourceFilePath.Text) + "\\" + sourceFilePath;
                FileStream fs = new FileStream(objectFilePath, FileMode.Create);
                BinaryWriter bwObj = new BinaryWriter(fs);
                bwObj.Write(byteData);
                bwObj.Flush();
                bwObj.Close();
                fs.Close();
                MessageBox.Show("反编码文件完成.");
            }
            catch
            {
                MessageBox.Show("反编码失败，请联系管理员.");
                return;
            }
            
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        
    }
}
