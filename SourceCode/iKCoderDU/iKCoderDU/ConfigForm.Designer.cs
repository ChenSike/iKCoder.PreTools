namespace iKCoderDU
{
    partial class ConfigForm
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
            this.txtConfigFile = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSessions = new System.Windows.Forms.ComboBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.lb_des_mode = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSessionValue = new System.Windows.Forms.TextBox();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.cmbSessionAttrs = new System.Windows.Forms.ComboBox();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.txtSessionAttrValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.txtItemNodeValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.linkLabel11 = new System.Windows.Forms.LinkLabel();
            this.cmbItemNodes = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabel12 = new System.Windows.Forms.LinkLabel();
            this.txtItemAttrValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel13 = new System.Windows.Forms.LinkLabel();
            this.linkLabel14 = new System.Windows.Forms.LinkLabel();
            this.cmbItemAttrs = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabel15 = new System.Windows.Forms.LinkLabel();
            this.linkLabel16 = new System.Windows.Forms.LinkLabel();
            this.linkLabel17 = new System.Windows.Forms.LinkLabel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.linkLabel18 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "活动的配置文件：";
            // 
            // txtConfigFile
            // 
            this.txtConfigFile.Location = new System.Drawing.Point(109, 47);
            this.txtConfigFile.Name = "txtConfigFile";
            this.txtConfigFile.Size = new System.Drawing.Size(267, 21);
            this.txtConfigFile.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(395, 50);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 12);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "加载文件";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Session：";
            // 
            // cmbSessions
            // 
            this.cmbSessions.FormattingEnabled = true;
            this.cmbSessions.Location = new System.Drawing.Point(77, 96);
            this.cmbSessions.Name = "cmbSessions";
            this.cmbSessions.Size = new System.Drawing.Size(299, 20);
            this.cmbSessions.TabIndex = 4;
            this.cmbSessions.SelectedIndexChanged += new System.EventHandler(this.cmbSessions_SelectedIndexChanged);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Location = new System.Drawing.Point(395, 99);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(29, 12);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "建立";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Location = new System.Drawing.Point(430, 99);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(29, 12);
            this.linkLabel3.TabIndex = 6;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "删除";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Session Attr：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(478, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "加密KEY：";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(533, 47);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(255, 21);
            this.txtKey.TabIndex = 10;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel4.Location = new System.Drawing.Point(798, 52);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(77, 12);
            this.linkLabel4.TabIndex = 11;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "切换加密模式";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // lb_des_mode
            // 
            this.lb_des_mode.AutoSize = true;
            this.lb_des_mode.BackColor = System.Drawing.Color.Transparent;
            this.lb_des_mode.Location = new System.Drawing.Point(774, 9);
            this.lb_des_mode.Name = "lb_des_mode";
            this.lb_des_mode.Size = new System.Drawing.Size(101, 12);
            this.lb_des_mode.TabIndex = 12;
            this.lb_des_mode.Text = "当前为非加密模式";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(478, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "Value：";
            // 
            // txtSessionValue
            // 
            this.txtSessionValue.Location = new System.Drawing.Point(533, 95);
            this.txtSessionValue.Name = "txtSessionValue";
            this.txtSessionValue.Size = new System.Drawing.Size(255, 21);
            this.txtSessionValue.TabIndex = 14;
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel5.Location = new System.Drawing.Point(808, 99);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(53, 12);
            this.linkLabel5.TabIndex = 15;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "更新数据";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // cmbSessionAttrs
            // 
            this.cmbSessionAttrs.FormattingEnabled = true;
            this.cmbSessionAttrs.Location = new System.Drawing.Point(97, 146);
            this.cmbSessionAttrs.Name = "cmbSessionAttrs";
            this.cmbSessionAttrs.Size = new System.Drawing.Size(279, 20);
            this.cmbSessionAttrs.TabIndex = 16;
            this.cmbSessionAttrs.SelectedIndexChanged += new System.EventHandler(this.cmbSessionAttrs_SelectedIndexChanged);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel6.Location = new System.Drawing.Point(808, 149);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(53, 12);
            this.linkLabel6.TabIndex = 21;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "更新数据";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // txtSessionAttrValue
            // 
            this.txtSessionAttrValue.Location = new System.Drawing.Point(533, 145);
            this.txtSessionAttrValue.Name = "txtSessionAttrValue";
            this.txtSessionAttrValue.Size = new System.Drawing.Size(255, 21);
            this.txtSessionAttrValue.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(478, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "Value：";
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel7.Location = new System.Drawing.Point(430, 151);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(29, 12);
            this.linkLabel7.TabIndex = 18;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "删除";
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel8.Location = new System.Drawing.Point(395, 151);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(29, 12);
            this.linkLabel8.TabIndex = 17;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "建立";
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // txtItemNodeValue
            // 
            this.txtItemNodeValue.Location = new System.Drawing.Point(533, 194);
            this.txtItemNodeValue.Name = "txtItemNodeValue";
            this.txtItemNodeValue.Size = new System.Drawing.Size(328, 21);
            this.txtItemNodeValue.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(478, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "Value：";
            // 
            // linkLabel10
            // 
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel10.Location = new System.Drawing.Point(430, 198);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(29, 12);
            this.linkLabel10.TabIndex = 25;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "删除";
            this.linkLabel10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel10_LinkClicked);
            // 
            // linkLabel11
            // 
            this.linkLabel11.AutoSize = true;
            this.linkLabel11.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel11.Location = new System.Drawing.Point(395, 198);
            this.linkLabel11.Name = "linkLabel11";
            this.linkLabel11.Size = new System.Drawing.Size(29, 12);
            this.linkLabel11.TabIndex = 24;
            this.linkLabel11.TabStop = true;
            this.linkLabel11.Text = "建立";
            this.linkLabel11.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel11_LinkClicked);
            // 
            // cmbItemNodes
            // 
            this.cmbItemNodes.FormattingEnabled = true;
            this.cmbItemNodes.Location = new System.Drawing.Point(77, 195);
            this.cmbItemNodes.Name = "cmbItemNodes";
            this.cmbItemNodes.Size = new System.Drawing.Size(299, 20);
            this.cmbItemNodes.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(12, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "Item Node：";
            // 
            // linkLabel12
            // 
            this.linkLabel12.AutoSize = true;
            this.linkLabel12.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel12.Location = new System.Drawing.Point(808, 247);
            this.linkLabel12.Name = "linkLabel12";
            this.linkLabel12.Size = new System.Drawing.Size(53, 12);
            this.linkLabel12.TabIndex = 35;
            this.linkLabel12.TabStop = true;
            this.linkLabel12.Text = "更新数据";
            // 
            // txtItemAttrValue
            // 
            this.txtItemAttrValue.Location = new System.Drawing.Point(533, 243);
            this.txtItemAttrValue.Name = "txtItemAttrValue";
            this.txtItemAttrValue.Size = new System.Drawing.Size(255, 21);
            this.txtItemAttrValue.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(478, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 33;
            this.label4.Text = "Value：";
            // 
            // linkLabel13
            // 
            this.linkLabel13.AutoSize = true;
            this.linkLabel13.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel13.Location = new System.Drawing.Point(430, 249);
            this.linkLabel13.Name = "linkLabel13";
            this.linkLabel13.Size = new System.Drawing.Size(29, 12);
            this.linkLabel13.TabIndex = 32;
            this.linkLabel13.TabStop = true;
            this.linkLabel13.Text = "删除";
            // 
            // linkLabel14
            // 
            this.linkLabel14.AutoSize = true;
            this.linkLabel14.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel14.Location = new System.Drawing.Point(395, 249);
            this.linkLabel14.Name = "linkLabel14";
            this.linkLabel14.Size = new System.Drawing.Size(29, 12);
            this.linkLabel14.TabIndex = 31;
            this.linkLabel14.TabStop = true;
            this.linkLabel14.Text = "建立";
            // 
            // cmbItemAttrs
            // 
            this.cmbItemAttrs.FormattingEnabled = true;
            this.cmbItemAttrs.Location = new System.Drawing.Point(77, 244);
            this.cmbItemAttrs.Name = "cmbItemAttrs";
            this.cmbItemAttrs.Size = new System.Drawing.Size(299, 20);
            this.cmbItemAttrs.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(12, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 12);
            this.label11.TabIndex = 29;
            this.label11.Text = "Item Attr：";
            // 
            // linkLabel15
            // 
            this.linkLabel15.AutoSize = true;
            this.linkLabel15.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel15.Location = new System.Drawing.Point(12, 294);
            this.linkLabel15.Name = "linkLabel15";
            this.linkLabel15.Size = new System.Drawing.Size(53, 12);
            this.linkLabel15.TabIndex = 36;
            this.linkLabel15.TabStop = true;
            this.linkLabel15.Text = "刷新文档";
            // 
            // linkLabel16
            // 
            this.linkLabel16.AutoSize = true;
            this.linkLabel16.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel16.Location = new System.Drawing.Point(75, 294);
            this.linkLabel16.Name = "linkLabel16";
            this.linkLabel16.Size = new System.Drawing.Size(53, 12);
            this.linkLabel16.TabIndex = 37;
            this.linkLabel16.TabStop = true;
            this.linkLabel16.Text = "保存文档";
            this.linkLabel16.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel16_LinkClicked);
            // 
            // linkLabel17
            // 
            this.linkLabel17.AutoSize = true;
            this.linkLabel17.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel17.Location = new System.Drawing.Point(808, 294);
            this.linkLabel17.Name = "linkLabel17";
            this.linkLabel17.Size = new System.Drawing.Size(53, 12);
            this.linkLabel17.TabIndex = 38;
            this.linkLabel17.TabStop = true;
            this.linkLabel17.Text = "关闭窗口";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(14, 347);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(861, 433);
            this.textBox7.TabIndex = 39;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML 配置文件|*.xml";
            // 
            // linkLabel18
            // 
            this.linkLabel18.AutoSize = true;
            this.linkLabel18.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel18.Location = new System.Drawing.Point(145, 294);
            this.linkLabel18.Name = "linkLabel18";
            this.linkLabel18.Size = new System.Drawing.Size(101, 12);
            this.linkLabel18.TabIndex = 40;
            this.linkLabel18.TabStop = true;
            this.linkLabel18.Text = "切换为非加密模式";
            this.linkLabel18.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel18_LinkClicked);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iKCoderDU.Properties.Resources.configForm_fw;
            this.ClientSize = new System.Drawing.Size(900, 772);
            this.Controls.Add(this.linkLabel18);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.linkLabel17);
            this.Controls.Add(this.linkLabel16);
            this.Controls.Add(this.linkLabel15);
            this.Controls.Add(this.linkLabel12);
            this.Controls.Add(this.txtItemAttrValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel13);
            this.Controls.Add(this.linkLabel14);
            this.Controls.Add(this.cmbItemAttrs);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtItemNodeValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.linkLabel10);
            this.Controls.Add(this.linkLabel11);
            this.Controls.Add(this.cmbItemNodes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.txtSessionAttrValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.linkLabel8);
            this.Controls.Add(this.cmbSessionAttrs);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.txtSessionValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_des_mode);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.cmbSessions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtConfigFile);
            this.Controls.Add(this.label1);
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfigFile;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSessions;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Label lb_des_mode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSessionValue;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.ComboBox cmbSessionAttrs;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.TextBox txtSessionAttrValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.TextBox txtItemNodeValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.LinkLabel linkLabel11;
        private System.Windows.Forms.ComboBox cmbItemNodes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabel12;
        private System.Windows.Forms.TextBox txtItemAttrValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel13;
        private System.Windows.Forms.LinkLabel linkLabel14;
        private System.Windows.Forms.ComboBox cmbItemAttrs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLabel15;
        private System.Windows.Forms.LinkLabel linkLabel16;
        private System.Windows.Forms.LinkLabel linkLabel17;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel linkLabel18;
    }
}