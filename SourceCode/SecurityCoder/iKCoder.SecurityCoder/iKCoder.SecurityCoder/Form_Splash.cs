using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iKCoder.SecurityCoder
{
    public partial class Form_Splash : iKCoder_Platform_SDK_Kit.Forms_NoBorderBaseform
    {
        public Form_Splash()
        {
            InitializeComponent();
        }

        private void Form_Splash_Load(object sender, EventArgs e)
        {

        }

        private void Form_Splash_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form_Main obj_FormMain = new Form_Main();
            obj_FormMain.Show();
            this.Hide();
        }
    }
}
