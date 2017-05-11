namespace iKCoderDU
{
    partial class MessageRegRouter
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
            this.cmb_symbols = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pushapi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_getapi = new System.Windows.Forms.TextBox();
            this.txt_produce = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_symbols
            // 
            this.cmb_symbols.FormattingEnabled = true;
            this.cmb_symbols.Location = new System.Drawing.Point(131, 67);
            this.cmb_symbols.Name = "cmb_symbols";
            this.cmb_symbols.Size = new System.Drawing.Size(520, 27);
            this.cmb_symbols.TabIndex = 0;
            this.cmb_symbols.SelectedIndexChanged += new System.EventHandler(this.cmb_symbols_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(669, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "刷新列表";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(1131, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 20);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "关闭";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(844, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "创建新的";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1019, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(39, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Push API :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_pushapi
            // 
            this.txt_pushapi.Location = new System.Drawing.Point(131, 120);
            this.txt_pushapi.Name = "txt_pushapi";
            this.txt_pushapi.Size = new System.Drawing.Size(1002, 25);
            this.txt_pushapi.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(49, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Get API :";
            // 
            // txt_getapi
            // 
            this.txt_getapi.Location = new System.Drawing.Point(131, 195);
            this.txt_getapi.Name = "txt_getapi";
            this.txt_getapi.Size = new System.Drawing.Size(1002, 25);
            this.txt_getapi.TabIndex = 21;
            // 
            // txt_produce
            // 
            this.txt_produce.Location = new System.Drawing.Point(131, 278);
            this.txt_produce.Name = "txt_produce";
            this.txt_produce.Size = new System.Drawing.Size(1002, 25);
            this.txt_produce.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(49, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Produce :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MessageRegRouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iKCoderDU.Properties.Resources.messageRouterCenter_fw;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.txt_produce);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_getapi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pushapi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cmb_symbols);
            this.Name = "MessageRegRouter";
            this.Text = "MessageRegRouter";
            this.Load += new System.EventHandler(this.MessageRegRouter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_symbols;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pushapi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_getapi;
        private System.Windows.Forms.TextBox txt_produce;
        private System.Windows.Forms.Label label3;
    }
}