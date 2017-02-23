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
using System.Drawing.Imaging;
using System.Xml;

namespace iKCoderDU
{
    public partial class EncoderMetrixImage : Forms_NoBorderBaseform
    {

        Bitmap bitMap;
        bool loaded = false;
        Color backColor;
        class_Net_RemoteRequest object_remote;

        public string activeServerUrl
        {
            set;
            get;
        }

        public EncoderMetrixImage(class_Net_RemoteRequest refNetObject)            
        {
            object_remote = refNetObject;
            InitializeComponent();
        }

        private void EncoderMetrixImage_Load(object sender, EventArgs e)
        {

        }

        public class pixelNode
        {
            public Color pixelColor;
            public int X;
            public int Y;
        }

        public class lineDataStruct
        {
            public int R;
            public int G;
            public int B;
            public int StartX;
            public int EndX;
            public int LineY;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                this.pictureBox1.Image = Image.FromFile(fileName);
                bitMap = new Bitmap(fileName);
                loaded = true;
                this.txt_filename.Text = fileName;                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
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
                            MessageBox.Show("很抱歉，您输入的标识数据已经存在，请更改后导入数据。");
                        }
                        else
                        {
                            string inputData = class_CommonUtil.Encoder_Base64(txt_metrixResult.Text);
                            string inputDoc = "<root><symbol>" + txt_symbol.Text + "</symbol><data>" + inputData + "</data><type>text</type></root>";
                            verifiedSymbolExistedURL = activeServerUrl + "/Data/api_SetMetaTextData.aspx?cid=" + GlobalVars.cid;
                            result = object_remote.getRemoteRequestToStringWithCookieHeader(inputDoc, verifiedSymbolExistedURL, 1000 * 60, 100000);
                            if (result.Contains("true"))
                            {
                                MessageBox.Show("您已经成功导入数据，点击确定返回主界面。");
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

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(loaded)
            {
                backColor = bitMap.GetPixel(e.X, e.Y);
                txt_bkcolor.Text = "RGB(" + backColor.R + "," + backColor.G + "," + backColor.B + ")";
            }
            else
            {
                MessageBox.Show("请先加载图片后选取.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(loaded)
            {                
                XmlDocument resultDoc = new XmlDocument();
                resultDoc.LoadXml("<root></root>");
                XmlNode rootNode = resultDoc.SelectSingleNode("/root");
                int maxWidth = 0;
                int maxHeight = 0;
                for (int height = 0; height < bitMap.Height; height++)
                {
                    List<pixelNode> lineData = new List<pixelNode>();
                    StringBuilder strLineData = new StringBuilder();
                    for (int width = 0; width < bitMap.Width; width++)
                    {
                        Color pixelResult = bitMap.GetPixel(width, height);
                        if (pixelResult == Color.Transparent || pixelResult == backColor)
                            continue;
                        else
                        {
                            pixelNode newItem = new pixelNode();
                            newItem.X = width;
                            newItem.Y = height;
                            newItem.pixelColor = pixelResult;
                            lineData.Add(newItem);
                        }
                    }
                    List<lineDataStruct> lineStructDataLst = new List<lineDataStruct>();
                    foreach (pixelNode activePixel in lineData)
                    {
                        if (lineStructDataLst.Count == 0)
                        {
                            lineDataStruct newLineDataStructItem = new lineDataStruct();
                            newLineDataStructItem.StartX = activePixel.X;
                            newLineDataStructItem.EndX = activePixel.X;
                            newLineDataStructItem.LineY = activePixel.Y;
                            newLineDataStructItem.R = activePixel.pixelColor.R;
                            newLineDataStructItem.G = activePixel.pixelColor.G;
                            newLineDataStructItem.B = activePixel.pixelColor.B;
                            lineStructDataLst.Add(newLineDataStructItem);
                        }
                        else
                        {
                            int lastIndex = lineStructDataLst.Count - 1;
                            lineDataStruct lastLineDataStruct = lineStructDataLst[lastIndex];
                            if (lastLineDataStruct.R == activePixel.pixelColor.R && lastLineDataStruct.G == activePixel.pixelColor.G && lastLineDataStruct.B == activePixel.pixelColor.B)
                                lastLineDataStruct.EndX = activePixel.X;
                            else
                            {
                                lineDataStruct newLineDataStructItem = new lineDataStruct();
                                newLineDataStructItem.StartX = activePixel.X;
                                newLineDataStructItem.EndX = activePixel.X;
                                newLineDataStructItem.LineY = activePixel.Y;
                                newLineDataStructItem.R = activePixel.pixelColor.R;
                                newLineDataStructItem.G = activePixel.pixelColor.G;
                                newLineDataStructItem.B = activePixel.pixelColor.B;
                                lineStructDataLst.Add(newLineDataStructItem);
                            }
                        }
                    }
                    foreach (lineDataStruct activeLineDataStruct in lineStructDataLst)
                    {
                        if (activeLineDataStruct.EndX > maxWidth)
                            maxWidth = activeLineDataStruct.EndX;
                        if (activeLineDataStruct.LineY > maxHeight)
                            maxHeight = activeLineDataStruct.LineY;
                        XmlNode newItemNode = class_XmlHelper.CreateNode(resultDoc, "item", "");
                        class_XmlHelper.SetAttrValue(newItemNode, "y", activeLineDataStruct.LineY.ToString());
                        class_XmlHelper.SetAttrValue(newItemNode, "c", "rgb(" + activeLineDataStruct.R + "," + activeLineDataStruct.G + "," + activeLineDataStruct.B + ")");
                        class_XmlHelper.SetAttrValue(newItemNode, "sx", activeLineDataStruct.StartX.ToString());
                        class_XmlHelper.SetAttrValue(newItemNode, "ex", activeLineDataStruct.EndX.ToString());
                        rootNode.AppendChild(newItemNode);
                    }
                }
                class_XmlHelper.SetAttribute(rootNode, "width", maxWidth.ToString());
                class_XmlHelper.SetAttribute(resultDoc.SelectSingleNode("/root"), "height", maxHeight.ToString());
                txt_metrixResult.Text = resultDoc.OuterXml;   
            }
            else
            {
                MessageBox.Show("请先加载图片后进行编码.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
