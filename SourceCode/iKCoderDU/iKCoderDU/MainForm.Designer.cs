﻿namespace iKCoderDU
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_server = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_produce = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_code = new System.Windows.Forms.ComboBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_vfolder = new System.Windows.Forms.ComboBox();
            this.lb_serverstatus = new System.Windows.Forms.Label();
            this.lst_cookies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmb_URL = new System.Windows.Forms.ComboBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新创建对应服务器的所有SPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qRCoderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pic_bindata = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bindata)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器：";
            // 
            // cmb_server
            // 
            this.cmb_server.FormattingEnabled = true;
            this.cmb_server.Items.AddRange(new object[] {
            "ikcoder.iok.la:24525",
            "localhost"});
            this.cmb_server.Location = new System.Drawing.Point(71, 90);
            this.cmb_server.Name = "cmb_server";
            this.cmb_server.Size = new System.Drawing.Size(176, 21);
            this.cmb_server.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "获取TOKEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(24, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "产品：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmb_produce
            // 
            this.cmb_produce.FormattingEnabled = true;
            this.cmb_produce.Items.AddRange(new object[] {
            "iKCoder"});
            this.cmb_produce.Location = new System.Drawing.Point(71, 151);
            this.cmb_produce.Name = "cmb_produce";
            this.cmb_produce.Size = new System.Drawing.Size(176, 21);
            this.cmb_produce.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(24, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "代码：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_code
            // 
            this.cmb_code.FormattingEnabled = true;
            this.cmb_code.Items.AddRange(new object[] {
            "12345678"});
            this.cmb_code.Location = new System.Drawing.Point(71, 185);
            this.cmb_code.Name = "cmb_code";
            this.cmb_code.Size = new System.Drawing.Size(176, 21);
            this.cmb_code.TabIndex = 6;
            // 
            // txtResult
            // 
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Location = new System.Drawing.Point(0, 0);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(931, 687);
            this.txtResult.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(24, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "目录：";
            // 
            // cmb_vfolder
            // 
            this.cmb_vfolder.FormattingEnabled = true;
            this.cmb_vfolder.Items.AddRange(new object[] {
            "PlatformAPI",
            "iKCoder"});
            this.cmb_vfolder.Location = new System.Drawing.Point(71, 120);
            this.cmb_vfolder.Name = "cmb_vfolder";
            this.cmb_vfolder.Size = new System.Drawing.Size(176, 21);
            this.cmb_vfolder.TabIndex = 10;
            this.cmb_vfolder.Text = "PlatformAPI";
            // 
            // lb_serverstatus
            // 
            this.lb_serverstatus.AutoSize = true;
            this.lb_serverstatus.BackColor = System.Drawing.Color.Transparent;
            this.lb_serverstatus.Location = new System.Drawing.Point(13, 262);
            this.lb_serverstatus.Name = "lb_serverstatus";
            this.lb_serverstatus.Size = new System.Drawing.Size(175, 13);
            this.lb_serverstatus.TabIndex = 11;
            this.lb_serverstatus.Text = "服务器状态：未获得服务器授权";
            // 
            // lst_cookies
            // 
            this.lst_cookies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lst_cookies.GridLines = true;
            this.lst_cookies.Location = new System.Drawing.Point(12, 277);
            this.lst_cookies.Name = "lst_cookies";
            this.lst_cookies.Size = new System.Drawing.Size(235, 132);
            this.lst_cookies.TabIndex = 0;
            this.lst_cookies.UseCompatibleStateImageBehavior = false;
            this.lst_cookies.View = System.Windows.Forms.View.Details;
            this.lst_cookies.SelectedIndexChanged += new System.EventHandler(this.lst_cookies_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cookie Name";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 281;
            // 
            // cmb_URL
            // 
            this.cmb_URL.FormattingEnabled = true;
            this.cmb_URL.Items.AddRange(new object[] {
            "/Account/SET_Reg.aspx",
            "/Data/GET_CheckCodeNUA.aspx?length=5&name=regusr&width=300&height=50",
            "/Account/api_VerifyAccountExisted.aspx?username=18675521735"});
            this.cmb_URL.Location = new System.Drawing.Point(304, 68);
            this.cmb_URL.Name = "cmb_URL";
            this.cmb_URL.Size = new System.Drawing.Size(884, 21);
            this.cmb_URL.TabIndex = 14;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(0, 3);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(931, 681);
            this.txtInput.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(9, 31);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(137, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新创建对应服务器的所有SPToolStripMenuItem});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.操作ToolStripMenuItem.Text = "操作";
            // 
            // 重新创建对应服务器的所有SPToolStripMenuItem
            // 
            this.重新创建对应服务器的所有SPToolStripMenuItem.Name = "重新创建对应服务器的所有SPToolStripMenuItem";
            this.重新创建对应服务器的所有SPToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.重新创建对应服务器的所有SPToolStripMenuItem.Text = "重新创建对应服务器的所有SP";
            this.重新创建对应服务器的所有SPToolStripMenuItem.Click += new System.EventHandler(this.重新创建对应服务器的所有SPToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qRCoderToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.退出ToolStripMenuItem.Text = "工具";
            // 
            // qRCoderToolStripMenuItem
            // 
            this.qRCoderToolStripMenuItem.Name = "qRCoderToolStripMenuItem";
            this.qRCoderToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.qRCoderToolStripMenuItem.Text = "QR Coder";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.accountToolStripMenuItem.Text = "Token Config";
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(272, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "API：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(262, 185);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(935, 713);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtInput);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(927, 687);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Input Document";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.txtResult);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(927, 687);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Response Result";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pic_bindata);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(927, 687);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Image Viewer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pic_bindata
            // 
            this.pic_bindata.Location = new System.Drawing.Point(0, 0);
            this.pic_bindata.Name = "pic_bindata";
            this.pic_bindata.Size = new System.Drawing.Size(100, 50);
            this.pic_bindata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_bindata.TabIndex = 0;
            this.pic_bindata.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.listView1);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(927, 687);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Resource Explorer";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(626, 328);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 353);
            this.textBox1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::iKCoderDU.Properties.Resources.prevImg_fw;
            this.pictureBox2.Location = new System.Drawing.Point(626, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 260);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Load";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 125);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(608, 556);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "id";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "symbol";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "type";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "produce";
            this.columnHeader6.Width = 98;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "isBinary";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "isBase64";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "isDES";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "DESKey";
            this.columnHeader10.Width = 90;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::iKCoderDU.Properties.Resources.resourceExplorer_fw;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(930, 680);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(304, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Post XML | Get String";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "GET | Get Binary";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(927, 687);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Relation Ship";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(94, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Import Data";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::iKCoderDU.Properties.Resources.mainform_fw;
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cmb_URL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lst_cookies);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_serverstatus);
            this.Controls.Add(this.cmb_vfolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_produce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_server);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bindata)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_server;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_produce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_vfolder;
        private System.Windows.Forms.Label lb_serverstatus;
        private System.Windows.Forms.ListView lst_cookies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cmb_URL;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem 重新创建对应服务器的所有SPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pic_bindata;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStripMenuItem qRCoderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button5;
    }
}

