namespace iKCoderDU
{
    partial class Mainform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dv_datasource = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_vfolder = new System.Windows.Forms.ComboBox();
            this.lb_serverstatus = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lst_cookies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_datasource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器：";
            // 
            // cmb_server
            // 
            this.cmb_server.FormattingEnabled = true;
            this.cmb_server.Items.AddRange(new object[] {
            "ikcoder.iok.la:24525"});
            this.cmb_server.Location = new System.Drawing.Point(80, 16);
            this.cmb_server.Name = "cmb_server";
            this.cmb_server.Size = new System.Drawing.Size(168, 20);
            this.cmb_server.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "获取TOKEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "产品：";
            // 
            // cmb_produce
            // 
            this.cmb_produce.FormattingEnabled = true;
            this.cmb_produce.Items.AddRange(new object[] {
            "iKCoder"});
            this.cmb_produce.Location = new System.Drawing.Point(80, 51);
            this.cmb_produce.Name = "cmb_produce";
            this.cmb_produce.Size = new System.Drawing.Size(168, 20);
            this.cmb_produce.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "产品代码：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_code
            // 
            this.cmb_code.FormattingEnabled = true;
            this.cmb_code.Items.AddRange(new object[] {
            "12345678"});
            this.cmb_code.Location = new System.Drawing.Point(347, 51);
            this.cmb_code.Name = "cmb_code";
            this.cmb_code.Size = new System.Drawing.Size(168, 20);
            this.cmb_code.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dv_datasource);
            this.groupBox1.Location = new System.Drawing.Point(23, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 617);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据资源";
            // 
            // dv_datasource
            // 
            this.dv_datasource.AllowUserToOrderColumns = true;
            this.dv_datasource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_datasource.Location = new System.Drawing.Point(18, 20);
            this.dv_datasource.Name = "dv_datasource";
            this.dv_datasource.RowTemplate.Height = 23;
            this.dv_datasource.Size = new System.Drawing.Size(392, 576);
            this.dv_datasource.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(23, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(948, 41);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(867, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "退出";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "重新创建SP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "虚拟目录：";
            // 
            // cmb_vfolder
            // 
            this.cmb_vfolder.FormattingEnabled = true;
            this.cmb_vfolder.Items.AddRange(new object[] {
            "PlatformAPI"});
            this.cmb_vfolder.Location = new System.Drawing.Point(347, 16);
            this.cmb_vfolder.Name = "cmb_vfolder";
            this.cmb_vfolder.Size = new System.Drawing.Size(168, 20);
            this.cmb_vfolder.TabIndex = 10;
            this.cmb_vfolder.Text = "PlatformAPI";
            // 
            // lb_serverstatus
            // 
            this.lb_serverstatus.AutoSize = true;
            this.lb_serverstatus.Location = new System.Drawing.Point(650, 54);
            this.lb_serverstatus.Name = "lb_serverstatus";
            this.lb_serverstatus.Size = new System.Drawing.Size(173, 12);
            this.lb_serverstatus.TabIndex = 11;
            this.lb_serverstatus.Text = "服务器状态：未获得服务器授权";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lst_cookies);
            this.groupBox3.Location = new System.Drawing.Point(456, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 113);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cookies";
            // 
            // lst_cookies
            // 
            this.lst_cookies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lst_cookies.GridLines = true;
            this.lst_cookies.Location = new System.Drawing.Point(6, 20);
            this.lst_cookies.Name = "lst_cookies";
            this.lst_cookies.Size = new System.Drawing.Size(503, 78);
            this.lst_cookies.TabIndex = 0;
            this.lst_cookies.UseCompatibleStateImageBehavior = false;
            this.lst_cookies.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cookie Name";
            this.columnHeader1.Width = 173;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 281;
            // 
            // Mainform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 820);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lb_serverstatus);
            this.Controls.Add(this.cmb_vfolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_produce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_server);
            this.Controls.Add(this.label1);
            this.Name = "Mainform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dv_datasource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_vfolder;
        private System.Windows.Forms.Label lb_serverstatus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lst_cookies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.DataGridView dv_datasource;
    }
}

