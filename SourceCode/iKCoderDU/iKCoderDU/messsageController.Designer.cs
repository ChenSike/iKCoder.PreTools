namespace iKCoderDU
{
    partial class messsageController
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
            this.lst_message = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.istop = new System.Windows.Forms.CheckBox();
            this.cmb_to = new System.Windows.Forms.ComboBox();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmb_produce = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_message
            // 
            this.lst_message.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lst_message.GridLines = true;
            this.lst_message.Location = new System.Drawing.Point(637, 148);
            this.lst_message.Name = "lst_message";
            this.lst_message.Size = new System.Drawing.Size(551, 463);
            this.lst_message.TabIndex = 2;
            this.lst_message.UseCompatibleStateImageBehavior = false;
            this.lst_message.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "title";
            this.columnHeader2.Width = 413;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "KeyWord :";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(68, 106);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(546, 25);
            this.txt_title.TabIndex = 4;
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(95, 66);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(984, 25);
            this.txt_key.TabIndex = 5;
            // 
            // istop
            // 
            this.istop.AutoSize = true;
            this.istop.Location = new System.Drawing.Point(101, 153);
            this.istop.Name = "istop";
            this.istop.Size = new System.Drawing.Size(18, 17);
            this.istop.TabIndex = 6;
            this.istop.UseVisualStyleBackColor = true;
            // 
            // cmb_to
            // 
            this.cmb_to.FormattingEnabled = true;
            this.cmb_to.Items.AddRange(new object[] {
            "everyone"});
            this.cmb_to.Location = new System.Drawing.Point(101, 193);
            this.cmb_to.Name = "cmb_to";
            this.cmb_to.Size = new System.Drawing.Size(513, 27);
            this.cmb_to.TabIndex = 7;
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(14, 280);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(598, 331);
            this.txt_message.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1099, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Searching";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 628);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmb_produce
            // 
            this.cmb_produce.FormattingEnabled = true;
            this.cmb_produce.Items.AddRange(new object[] {
            "ikcoder",
            "all"});
            this.cmb_produce.Location = new System.Drawing.Point(99, 236);
            this.cmb_produce.Name = "cmb_produce";
            this.cmb_produce.Size = new System.Drawing.Size(513, 27);
            this.cmb_produce.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(665, 628);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1049, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "关闭";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // messsageController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iKCoderDU.Properties.Resources.messageCenter_fw;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmb_produce);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.cmb_to);
            this.Controls.Add(this.istop);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst_message);
            this.Name = "messsageController";
            this.Text = "messsageController";
            this.Load += new System.EventHandler(this.messsageController_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lst_message;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.CheckBox istop;
        private System.Windows.Forms.ComboBox cmb_to;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmb_produce;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}