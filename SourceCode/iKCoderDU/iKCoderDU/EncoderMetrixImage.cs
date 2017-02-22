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

namespace iKCoderDU
{
    public partial class EncoderMetrixImage : Forms_NoBorderBaseform
    {
        public EncoderMetrixImage()
        {
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
                Bitmap bitMap = new Bitmap(fileName);
                StringBuilder dataResult = new StringBuilder();
                dataResult.Append("<root>");
                for(int height=0;height<bitMap.Height;height++)
                {
                    List<pixelNode> lineData = new List<pixelNode>();
                    StringBuilder strLineData = new StringBuilder();
                    for (int width = 0; width < bitMap.Width; width++)
                    {
                        Color pixelResult = bitMap.GetPixel(width, height);
                        if(pixelResult == Color.Transparent || pixelResult == Color.White)                        
                            continue;
                        else
                        {
                            pixelNode newItem = new pixelNode();
                            newItem.X = width;
                            newItem.Y = height;
                            lineData.Add(newItem);
                        }                        
                    }
                    List<lineDataStruct> lineStructDataLst = new List<lineDataStruct>();
                    foreach(pixelNode activePixel in lineData)
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
                            if(lastLineDataStruct.R == activePixel.pixelColor.R && lastLineDataStruct.G == activePixel.pixelColor.G && lastLineDataStruct.B == activePixel.pixelColor.B)                            
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
                }
                
            }
        }
    }
}
