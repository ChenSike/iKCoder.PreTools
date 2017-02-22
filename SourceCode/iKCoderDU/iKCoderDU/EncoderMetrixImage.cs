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
            public bool isBack = true;
            public Color pixelColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                this.pictureBox1.Image = Image.FromFile(fileName);
                Bitmap bitMap = new Bitmap(fileName);
                for(int height=0;height<bitMap.Height;height++)
                {
                    Color prevPixel;
                    StringBuilder lineArr;

                    for (int width = 0; width < bitMap.Width; width++)
                    {
                        Color pixelResult = bitMap.GetPixel(width, height);
                        if(pixelResult == Color.Transparent || pixelResult == Color.White)                        
                            continue;
                        else
                        {
                            if(prevPixel == pixelResult)
                            {

                            }
                        }
                        
                    }
                }
                
            }
        }
    }
}
