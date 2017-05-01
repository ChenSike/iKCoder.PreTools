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

namespace iKCoderDU.config_ikcoder
{
    public partial class form_importBinary : Forms_NoBorderBaseform
    {

        class_Net_RemoteRequest object_remote;

        public string activeServerUrl
        {
            set;
            get;
        }

        public form_importBinary(class_Net_RemoteRequest refRemoteObject)
        {
            object_remote = refRemoteObject;
            InitializeComponent();
        }

        private void form_importBinary_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
