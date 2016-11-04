namespace iKCoder.SecurityCoder
{
    partial class Form_Main
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
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.txt_SourceFilePath = new System.Windows.Forms.TextBox();
            this.txt_ObjectFilePath = new System.Windows.Forms.TextBox();
            this.txt_CoderKey = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(352, 250);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "进行编码";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(430, 250);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(67, 13);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "进行反编码";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(516, 250);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(31, 13);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "退出";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // txt_SourceFilePath
            // 
            this.txt_SourceFilePath.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_SourceFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SourceFilePath.Location = new System.Drawing.Point(127, 92);
            this.txt_SourceFilePath.Name = "txt_SourceFilePath";
            this.txt_SourceFilePath.Size = new System.Drawing.Size(447, 13);
            this.txt_SourceFilePath.TabIndex = 3;
            this.txt_SourceFilePath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_ObjectFilePath
            // 
            this.txt_ObjectFilePath.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_ObjectFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ObjectFilePath.Location = new System.Drawing.Point(127, 125);
            this.txt_ObjectFilePath.Name = "txt_ObjectFilePath";
            this.txt_ObjectFilePath.Size = new System.Drawing.Size(447, 13);
            this.txt_ObjectFilePath.TabIndex = 4;
            this.txt_ObjectFilePath.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_ObjectFilePath_MouseClick);
            this.txt_ObjectFilePath.TextChanged += new System.EventHandler(this.txt_ObjectFilePath_TextChanged);
            // 
            // txt_CoderKey
            // 
            this.txt_CoderKey.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_CoderKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CoderKey.Location = new System.Drawing.Point(127, 162);
            this.txt_CoderKey.Name = "txt_CoderKey";
            this.txt_CoderKey.Size = new System.Drawing.Size(447, 13);
            this.txt_CoderKey.TabIndex = 5;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iKCoder.SecurityCoder.Properties.Resources.img_main_fw;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.txt_CoderKey);
            this.Controls.Add(this.txt_ObjectFilePath);
            this.Controls.Add(this.txt_SourceFilePath);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Form_Main";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.TextBox txt_SourceFilePath;
        private System.Windows.Forms.TextBox txt_ObjectFilePath;
        private System.Windows.Forms.TextBox txt_CoderKey;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}