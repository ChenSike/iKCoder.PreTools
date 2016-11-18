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

namespace ApiTestor
{
    public partial class Form : iKCoder_Platform_SDK_Kit.Forms_NoBorderBaseform
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            class_Net_RemoteRequest netObject = new class_Net_RemoteRequest();
            Output.Text= netObject.getRemoteRequestToString(Input.Text, url.Text, 9999, 4096, null);
        }
    }
}
