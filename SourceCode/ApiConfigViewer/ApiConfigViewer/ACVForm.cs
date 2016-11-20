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
using System.Xml;

namespace ApiConfigViewer
{
    public partial class ACVForm : Forms_NoBorderBaseform
    {
        XmlDocument _configDoc = new XmlDocument();

        public ACVForm()
        {
            InitializeComponent();
        }

        private void ACVForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                  _configDoc.Load(openFileDialog1.FileName);
                
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
