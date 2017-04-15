﻿namespace iKCoderDU
{
    partial class ImportTextData
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.txt_symbol = new System.Windows.Forms.TextBox();
            this.txt_DESKey = new System.Windows.Forms.TextBox();
            this.chk_isDES = new System.Windows.Forms.CheckBox();
            this.chk_isBase64 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmb_produce = new System.Windows.Forms.ComboBox();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_relationshipchild_symbolsearching = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Symbol / 标识 ：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produce / 归属产品 ：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "isDES / 是否加密 ：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "DESKey / 加密Key ：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "isBase64 / 是否用BASE64 ：";
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(31, 238);
            this.txt_data.Multiline = true;
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(730, 275);
            this.txt_data.TabIndex = 5;
            // 
            // txt_symbol
            // 
            this.txt_symbol.Location = new System.Drawing.Point(535, 70);
            this.txt_symbol.Name = "txt_symbol";
            this.txt_symbol.Size = new System.Drawing.Size(226, 21);
            this.txt_symbol.TabIndex = 6;
            // 
            // txt_DESKey
            // 
            this.txt_DESKey.Enabled = false;
            this.txt_DESKey.Location = new System.Drawing.Point(186, 157);
            this.txt_DESKey.Name = "txt_DESKey";
            this.txt_DESKey.Size = new System.Drawing.Size(575, 21);
            this.txt_DESKey.TabIndex = 7;
            // 
            // chk_isDES
            // 
            this.chk_isDES.AutoSize = true;
            this.chk_isDES.BackColor = System.Drawing.Color.Transparent;
            this.chk_isDES.Enabled = false;
            this.chk_isDES.Location = new System.Drawing.Point(186, 131);
            this.chk_isDES.Name = "chk_isDES";
            this.chk_isDES.Size = new System.Drawing.Size(15, 14);
            this.chk_isDES.TabIndex = 9;
            this.chk_isDES.UseVisualStyleBackColor = false;
            // 
            // chk_isBase64
            // 
            this.chk_isBase64.AutoSize = true;
            this.chk_isBase64.BackColor = System.Drawing.Color.Transparent;
            this.chk_isBase64.Enabled = false;
            this.chk_isBase64.Location = new System.Drawing.Point(186, 190);
            this.chk_isBase64.Name = "chk_isBase64";
            this.chk_isBase64.Size = new System.Drawing.Size(15, 14);
            this.chk_isBase64.TabIndex = 10;
            this.chk_isBase64.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "导入数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(686, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmb_produce
            // 
            this.cmb_produce.FormattingEnabled = true;
            this.cmb_produce.Items.AddRange(new object[] {
            "iKCoder"});
            this.cmb_produce.Location = new System.Drawing.Point(186, 99);
            this.cmb_produce.Name = "cmb_produce";
            this.cmb_produce.Size = new System.Drawing.Size(176, 20);
            this.cmb_produce.TabIndex = 13;
            // 
            // txt_url
            // 
            this.txt_url.Enabled = false;
            this.txt_url.Location = new System.Drawing.Point(228, 528);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(533, 21);
            this.txt_url.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 12);
            this.label7.TabIndex = 32;
            this.label7.Text = "取数据的API URL （自动生成）：";
            // 
            // cmb_relationshipchild_symbolsearching
            // 
            this.cmb_relationshipchild_symbolsearching.FormattingEnabled = true;
            this.cmb_relationshipchild_symbolsearching.Location = new System.Drawing.Point(186, 71);
            this.cmb_relationshipchild_symbolsearching.Name = "cmb_relationshipchild_symbolsearching";
            this.cmb_relationshipchild_symbolsearching.Size = new System.Drawing.Size(238, 20);
            this.cmb_relationshipchild_symbolsearching.TabIndex = 45;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(442, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 46;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ImportTextData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iKCoderDU.Properties.Resources.importTextData_fw;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmb_relationshipchild_symbolsearching);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_produce);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chk_isBase64);
            this.Controls.Add(this.chk_isDES);
            this.Controls.Add(this.txt_DESKey);
            this.Controls.Add(this.txt_symbol);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ImportTextData";
            this.Text = "ImportTextData";
            this.Load += new System.EventHandler(this.ImportTextData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.TextBox txt_symbol;
        private System.Windows.Forms.TextBox txt_DESKey;
        private System.Windows.Forms.CheckBox chk_isDES;
        private System.Windows.Forms.CheckBox chk_isBase64;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmb_produce;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_relationshipchild_symbolsearching;
        private System.Windows.Forms.Button button3;
    }
}