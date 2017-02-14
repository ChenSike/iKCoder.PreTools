﻿namespace iKCoderDU
{
    partial class ImportBinData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmb_produce = new System.Windows.Forms.ComboBox();
            this.chk_isBase64 = new System.Windows.Forms.CheckBox();
            this.chk_isDES = new System.Windows.Forms.CheckBox();
            this.txt_DESKey = new System.Windows.Forms.TextBox();
            this.txt_symbol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_filetype = new System.Windows.Forms.TextBox();
            this.txt_getdata = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(615, 70);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 12);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "如何命名一个数据资源";
            // 
            // cmb_produce
            // 
            this.cmb_produce.FormattingEnabled = true;
            this.cmb_produce.Items.AddRange(new object[] {
            "iKCoder"});
            this.cmb_produce.Location = new System.Drawing.Point(179, 95);
            this.cmb_produce.Name = "cmb_produce";
            this.cmb_produce.Size = new System.Drawing.Size(176, 20);
            this.cmb_produce.TabIndex = 24;
            // 
            // chk_isBase64
            // 
            this.chk_isBase64.AutoSize = true;
            this.chk_isBase64.BackColor = System.Drawing.Color.Transparent;
            this.chk_isBase64.Enabled = false;
            this.chk_isBase64.Location = new System.Drawing.Point(179, 186);
            this.chk_isBase64.Name = "chk_isBase64";
            this.chk_isBase64.Size = new System.Drawing.Size(15, 14);
            this.chk_isBase64.TabIndex = 23;
            this.chk_isBase64.UseVisualStyleBackColor = false;
            // 
            // chk_isDES
            // 
            this.chk_isDES.AutoSize = true;
            this.chk_isDES.BackColor = System.Drawing.Color.Transparent;
            this.chk_isDES.Enabled = false;
            this.chk_isDES.Location = new System.Drawing.Point(179, 127);
            this.chk_isDES.Name = "chk_isDES";
            this.chk_isDES.Size = new System.Drawing.Size(15, 14);
            this.chk_isDES.TabIndex = 22;
            this.chk_isDES.UseVisualStyleBackColor = false;
            // 
            // txt_DESKey
            // 
            this.txt_DESKey.Enabled = false;
            this.txt_DESKey.Location = new System.Drawing.Point(179, 153);
            this.txt_DESKey.Name = "txt_DESKey";
            this.txt_DESKey.Size = new System.Drawing.Size(575, 21);
            this.txt_DESKey.TabIndex = 21;
            // 
            // txt_symbol
            // 
            this.txt_symbol.Location = new System.Drawing.Point(179, 67);
            this.txt_symbol.Name = "txt_symbol";
            this.txt_symbol.Size = new System.Drawing.Size(415, 21);
            this.txt_symbol.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "isBase64 / 是否用BASE64 ：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(64, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "DESKey / 加密Key ：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "isDES / 是否加密 ：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "Produce / 归属产品 ：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "Symbol / 标识 ：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "isLoaded / 是否已经读取 ：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(179, 214);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "读取数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(45, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 12);
            this.label7.TabIndex = 29;
            this.label7.Text = "Filetype / 数据类型 ：";
            // 
            // txt_filetype
            // 
            this.txt_filetype.Enabled = false;
            this.txt_filetype.Location = new System.Drawing.Point(179, 242);
            this.txt_filetype.Name = "txt_filetype";
            this.txt_filetype.Size = new System.Drawing.Size(176, 21);
            this.txt_filetype.TabIndex = 30;
            // 
            // txt_getdata
            // 
            this.txt_getdata.Location = new System.Drawing.Point(165, 507);
            this.txt_getdata.Name = "txt_getdata";
            this.txt_getdata.ReadOnly = true;
            this.txt_getdata.Size = new System.Drawing.Size(589, 21);
            this.txt_getdata.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 510);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 12);
            this.label8.TabIndex = 31;
            this.label8.Text = "取数据URL（自动生成） :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(679, 553);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(598, 553);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "导入数据";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ImportBinData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iKCoderDU.Properties.Resources.importBinData_fw;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_getdata);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_filetype);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cmb_produce);
            this.Controls.Add(this.chk_isBase64);
            this.Controls.Add(this.chk_isDES);
            this.Controls.Add(this.txt_DESKey);
            this.Controls.Add(this.txt_symbol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ImportBinData";
            this.Text = "ImportBinData";
            this.Load += new System.EventHandler(this.ImportBinData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cmb_produce;
        private System.Windows.Forms.CheckBox chk_isBase64;
        private System.Windows.Forms.CheckBox chk_isDES;
        private System.Windows.Forms.TextBox txt_DESKey;
        private System.Windows.Forms.TextBox txt_symbol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_filetype;
        private System.Windows.Forms.TextBox txt_getdata;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}