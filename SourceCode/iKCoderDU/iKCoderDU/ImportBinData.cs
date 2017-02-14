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
using System.IO;

namespace iKCoderDU
{
    public partial class ImportBinData : Forms_NoBorderBaseform
    {

        class_Net_RemoteRequest object_remote;
        bool isLoaded = false;
        string extendsname;
        string filename;       


        public string activeServerUrl
        {
            set;
            get;
        }

        public ImportBinData(class_Net_RemoteRequest refNetObject)
        {
            object_remote = refNetObject;
            InitializeComponent();
        }

        private void ImportBinData_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                string[] filenameinfo = filename.Split('\\');
                extendsname = filenameinfo[filenameinfo.Length - 1].Split('.')[1];
                FileStream newFS = new FileStream(filename, FileMode.Open);
                BinaryReader newBR = new BinaryReader(newFS);
                byte[] newBuffer = newBR.ReadBytes((int)newFS.Length);
                newBR.Close();
                newFS.Close();
                string base64data = class_CommonUtil.Encoder_Base64(newBuffer);
                txt_base64data.Text = base64data;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
