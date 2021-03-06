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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_base64data = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cmb_relationshipchild_symbolsearching = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_produce
            // 
            this.cmb_produce.FormattingEnabled = true;
            this.cmb_produce.Items.AddRange(new object[] {
            "iKCoder"});
            this.cmb_produce.Location = new System.Drawing.Point(139, 108);
            this.cmb_produce.Name = "cmb_produce";
            this.cmb_produce.Size = new System.Drawing.Size(333, 20);
            this.cmb_produce.TabIndex = 24;
            // 
            // chk_isBase64
            // 
            this.chk_isBase64.AutoSize = true;
            this.chk_isBase64.BackColor = System.Drawing.Color.Transparent;
            this.chk_isBase64.Enabled = false;
            this.chk_isBase64.Location = new System.Drawing.Point(1000, 137);
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
            this.chk_isDES.Location = new System.Drawing.Point(140, 137);
            this.chk_isDES.Name = "chk_isDES";
            this.chk_isDES.Size = new System.Drawing.Size(15, 14);
            this.chk_isDES.TabIndex = 22;
            this.chk_isDES.UseVisualStyleBackColor = false;
            // 
            // txt_DESKey
            // 
            this.txt_DESKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DESKey.Enabled = false;
            this.txt_DESKey.Location = new System.Drawing.Point(139, 157);
            this.txt_DESKey.Name = "txt_DESKey";
            this.txt_DESKey.Size = new System.Drawing.Size(1049, 21);
            this.txt_DESKey.TabIndex = 21;
            // 
            // txt_symbol
            // 
            this.txt_symbol.Location = new System.Drawing.Point(816, 71);
            this.txt_symbol.Name = "txt_symbol";
            this.txt_symbol.Size = new System.Drawing.Size(372, 21);
            this.txt_symbol.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(837, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "isBase64 / 是否用BASE64 ：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "DESKey / 加密Key ：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "isDES / 是否加密 ：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "Produce / 归属产品 ：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(719, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "Symbol / 标识 ：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1032, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "isLoaded / 是否加载 ：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(1171, 137);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Load Data From File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_base64data);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_url);
            this.groupBox1.Location = new System.Drawing.Point(12, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1174, 402);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base64 数据";
            // 
            // txt_base64data
            // 
            this.txt_base64data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_base64data.Location = new System.Drawing.Point(8, 20);
            this.txt_base64data.Multiline = true;
            this.txt_base64data.Name = "txt_base64data";
            this.txt_base64data.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_base64data.Size = new System.Drawing.Size(1160, 338);
            this.txt_base64data.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "取数据的API URL （自动生成）：";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_url
            // 
            this.txt_url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_url.Enabled = false;
            this.txt_url.Location = new System.Drawing.Point(204, 369);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(955, 21);
            this.txt_url.TabIndex = 31;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1035, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(883, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "导入数据";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(16, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 12);
            this.label8.TabIndex = 34;
            this.label8.Text = "Filetype / 数据类型 ：";
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "png",
            "gif",
            "dll",
            "jpeg",
            "exe",
            "apk",
            "jpg",
            "avi",
            "mp4"});
            this.cmb_type.Location = new System.Drawing.Point(139, 185);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(176, 20);
            this.cmb_type.TabIndex = 35;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(638, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 48;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmb_relationshipchild_symbolsearching
            // 
            this.cmb_relationshipchild_symbolsearching.FormattingEnabled = true;
            this.cmb_relationshipchild_symbolsearching.Location = new System.Drawing.Point(225, 71);
            this.cmb_relationshipchild_symbolsearching.Name = "cmb_relationshipchild_symbolsearching";
            this.cmb_relationshipchild_symbolsearching.Size = new System.Drawing.Size(407, 20);
            this.cmb_relationshipchild_symbolsearching.TabIndex = 47;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(182, 221);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 23);
            this.button5.TabIndex = 49;
            this.button5.Text = "Show Data Code";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(10, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 24);
            this.label9.TabIndex = 50;
            this.label9.Text = "Existed Symbol / 已经存在的标识 ：\r\n\r\n";
            // 
            // ImportBinData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iKCoderDU.Properties.Resources.importBinData_fw;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cmb_relationshipchild_symbolsearching);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_base64data;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cmb_relationshipchild_symbolsearching;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
    }
}