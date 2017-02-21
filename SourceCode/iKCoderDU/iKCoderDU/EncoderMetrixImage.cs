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

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                this.pictureBox1.Image = Image.FromFile(fileName);
            }
        }
    }
}
