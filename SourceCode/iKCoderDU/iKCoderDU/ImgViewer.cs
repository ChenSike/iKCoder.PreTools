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
    public partial class ImgViewer : Forms_NoBorderBaseform
    {

        public byte[] imageBuffer
        {
            set;
            get;
        }

        public ImgViewer()
        {
            InitializeComponent();
        }

        private void ImgViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
