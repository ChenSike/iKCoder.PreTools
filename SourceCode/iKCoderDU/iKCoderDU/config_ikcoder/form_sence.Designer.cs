namespace iKCoderDU.config_ikcoder
{
    partial class form_sence
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
            this.txtConfig = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbSymbol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkFreeSence = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtConfig
            // 
            this.txtConfig.Location = new System.Drawing.Point(12, 115);
            this.txtConfig.Multiline = true;
            this.txtConfig.Name = "txtConfig";
            this.txtConfig.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConfig.Size = new System.Drawing.Size(1176, 549);
            this.txtConfig.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1099, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "关闭窗口";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(832, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "从服务器更新配置列表";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1013, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "更新配置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbSymbol
            // 
            this.cmbSymbol.FormattingEnabled = true;
            this.cmbSymbol.Location = new System.Drawing.Point(67, 65);
            this.cmbSymbol.Name = "cmbSymbol";
            this.cmbSymbol.Size = new System.Drawing.Size(544, 29);
            this.cmbSymbol.TabIndex = 11;
            this.cmbSymbol.SelectedIndexChanged += new System.EventHandler(this.cmbSymbol_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Symbol:";
            // 
            // chkFreeSence
            // 
            this.chkFreeSence.AutoSize = true;
            this.chkFreeSence.BackColor = System.Drawing.Color.Transparent;
            this.chkFreeSence.Location = new System.Drawing.Point(631, 69);
            this.chkFreeSence.Name = "chkFreeSence";
            this.chkFreeSence.Size = new System.Drawing.Size(132, 25);
            this.chkFreeSence.TabIndex = 16;
            this.chkFreeSence.Text = "是否免费课程";
            this.chkFreeSence.UseVisualStyleBackColor = false;
            // 
            // form_sence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iKCoderDU.Properties.Resources.Form_ikcoder_config_workspace_sence_fw;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.chkFreeSence);
            this.Controls.Add(this.txtConfig);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbSymbol);
            this.Controls.Add(this.label1);
            this.Name = "form_sence";
            this.Text = "form_sence";
            this.Load += new System.EventHandler(this.form_sence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConfig;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbSymbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkFreeSence;
    }
}