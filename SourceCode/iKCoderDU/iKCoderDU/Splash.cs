﻿using System;
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
    public partial class Splash : Forms_NoBorderBaseform
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void Splash_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            MainForm obj = new MainForm();
            obj.ShowDialog();
        }
    }
}
