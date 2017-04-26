using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iKCoder_Platform_SDK_Kit;
using System.Xml;

namespace iKCoderDU
{
    public partial class ConfigForm : Forms_NoBorderBaseform
    {

        public bool isLoaded = false;
        public class_Base_Config objConfig = new class_Base_Config();
        XmlNodeList sessions;

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                objConfig.DoOpen(openFileDialog1.FileName);
                isLoaded = true;
                flushSessions();
            }
        }

        protected void travelDocuments()
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (objConfig.Is_LoadedDoc)
            {
                if (!string.IsNullOrEmpty(txtKey.Text))
                {
                    objConfig.SwitchToDESModeON(txtKey.Text);
                    lb_des_mode.Text = "正常加密模式";
                }
                else
                    MessageBox.Show("加密KEY不可为空.请检查.");
            }
        }

        protected void flushSessions()
        {
            sessions = objConfig.GetSessionNodes();
            cmbSessions.Items.Clear();
            foreach(XmlNode session in sessions)
            {
                cmbSessions.Items.Add(objConfig.GetAttrValue(session, "name"));
            }
        }

        private void linkLabel18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(objConfig.Is_LoadedDoc)
            {
                objConfig.SwitchToDESModeOFF();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(!string.IsNullOrEmpty(cmbSessions.Text))
            {
                if(!cmbSessions.Items.Contains(cmbSessions.Text))
                {
                    objConfig.CreateNewSession(cmbSessions.Text, txtSessionValue.Text);
                    flushSessions();
                }
                else
                {
                    MessageBox.Show("Session 已经存在，请更换名称.");
                }
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbSessions.Text))
            {
                objConfig.SetSessionValue(cmbSessions.Text, txtSessionValue.Text);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbSessions.Text))
            {
                objConfig.RemoveSession(cmbSessions.Text);
                flushSessions();
            }
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(!string.IsNullOrEmpty(cmbSessionAttrs.Text) && !string.IsNullOrEmpty(cmbSessions.Text))
            {
                objConfig.SetSessionAttr(cmbSessions.Text, cmbSessionAttrs.Text, txtSessionAttrValue.Text);
                flushSessionAttrs();
            }
        }

        private void cmbSessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            flushSessionAttrs();
        }

        protected void flushSessionAttrs()
        {
            cmbSessionAttrs.Items.Clear();
            List<XmlAttribute> sessionAttrs = objConfig.GetSessionAttrs(cmbSessions.Text);
            foreach(XmlAttribute activeSessionAttr in sessionAttrs)
            {
                cmbSessionAttrs.Items.Add(activeSessionAttr.Name);
            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbSessionAttrs.Text) && !string.IsNullOrEmpty(cmbSessions.Text))
            {
                objConfig.SetSessionAttr(cmbSessions.Text, cmbSessionAttrs.Text, txtSessionAttrValue.Text);                
            }
        }

        private void cmbSessionAttrs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbSessionAttrs.Text) && !string.IsNullOrEmpty(cmbSessions.Text))
            {
                XmlNode sessionNode = objConfig.GetSessionNode(cmbSessions.Text);
                txtSessionAttrValue.Text = objConfig.GetAttrValue(sessionNode, cmbSessionAttrs.Text);               
            }
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbSessions.Text) && !string.IsNullOrEmpty(cmbItemNodes.Text))
            {
                XmlNode sessionNode = objConfig.GetSessionNode(cmbSessions.Text);
                objConfig.CreateItem(sessionNode, cmbItemNodes.Text, txtItemNodeValue.Text);
                flushItemNodes();
            }
        }

        protected void flushItemNodes()
        {
            if (!string.IsNullOrEmpty(cmbSessions.Text))
            {
                cmbItemNodes.Items.Clear();
                XmlNodeList itemNodes = objConfig.GetItemNodes(cmbSessions.Text);
                foreach(XmlNode activeItem in itemNodes)
                {
                    cmbItemNodes.Items.Add(class_XmlHelper.GetAttrValue(activeItem, "name"));
                }
            }
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbSessions.Text) && !string.IsNullOrEmpty(cmbItemNodes.Text))
            {
                objConfig.RemoveSessionItem(cmbSessions.Text, cmbItemNodes.Text);
                flushItemNodes();
            }
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbSessions.Text) && !string.IsNullOrEmpty(cmbItemNodes.Text))
            {
                XmlNode activeItemNode = objConfig.GetItemNode(cmbSessions.Text,cmbItemNodes.Text);
                flushItemNodes();
            }
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            objConfig.DoSave();
            MessageBox.Show("成功保存文档.");
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
