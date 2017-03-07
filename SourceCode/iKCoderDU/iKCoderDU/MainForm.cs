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
using System.Net;
using System.Xml;
using System.IO;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;

namespace iKCoderDU
{
    public partial class MainForm : Forms_NoBorderBaseform
    {

        class_Net_RemoteRequest object_remote;
        List<Cookie> object_cookies = new List<Cookie>();
        bool is_connected = false;
        Dictionary<string, string> urlMap = new Dictionary<string, string>();
        CookieContainer activeContainer = new CookieContainer();
        Dictionary<string, XmlDocument> buffer_relationDoc = new Dictionary<string, XmlDocument>();
        Dictionary<string, bool> changedFlag_relationDoc = new Dictionary<string, bool>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.object_remote = new class_Net_RemoteRequest(ref activeContainer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmb_server.Text) && !string.IsNullOrEmpty(cmb_produce.Text))
            {
                string requestURL = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + "/Domain/api_RegDomain.aspx?cid=" + GlobalVars.cid + "&domain=http://ikcoder.iok.la:24525";
                object_remote.getRemoteRequestToStringWithCookieHeader("<root></root>", requestURL, 1000, 1024 * 1024);
                string input = "<root><name>" + cmb_produce.Text + "</name><code>" + cmb_code.Text + "</code></root>";
                requestURL = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + "/Token/api_getToken.aspx?cid=" + GlobalVars.cid;
                object_cookies = object_remote.getRemoteServerCookie(requestURL,input);
                if(object_cookies!=null && object_cookies.Count>0)
                {
                    lst_cookies.Items.Clear();                   
                    lb_serverstatus.Text = "服务器状态：已经取得服务器TOKEN授权.";
                    is_connected = true;                   
                    foreach (Cookie activeCookie in object_cookies)
                    {
                        ListViewItem newItem = new ListViewItem(activeCookie.Name);
                        newItem.SubItems.Add(activeCookie.Value);
                        lst_cookies.Items.Add(newItem);
                        activeContainer.Add(activeCookie);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void lst_cookies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void 重新创建对应服务器的所有SPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (is_connected)
            {
                string requestURL = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + "/Data/api_BuildAllSPS.aspx?keycode=AllowPlatformOperation";
                string responseFromServer = object_remote.getRemoteRequestToString("<root></root>", requestURL, 1000, 1000, null);
                XmlDocument responseDoc = new XmlDocument();
                responseDoc.LoadXml(responseFromServer);
                XmlNode msgNode = responseDoc.SelectSingleNode("/root/msg[@code='executed']");
                if (msgNode != null)
                    MessageBox.Show("已经成功完成自定动作.");
                else
                {
                    MessageBox.Show("无法完成指定动作,请点击确定后查看文档.");
                    MessageBox.Show(responseFromServer);
                }
            }
            else
                MessageBox.Show("请先取得服务器授权后再进行动作.");
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                string requestURL = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + cmb_URL.Text;
                string result = object_remote.getRemoteXMLRequestToString(txtInput.Text, requestURL, 1000 * 60, 100000, null);
                txtResult.Text = result;
            }
            catch
            {
                MessageBox.Show("系统访问API出差，请检查参数或者网络。");
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string requestURL = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + cmb_URL.Text;
                byte[] data = object_remote.getRemoteXMLRequestToByte("<root></root>", requestURL, 1000 * 60, 100000, null);
                MemoryStream ms = new MemoryStream();
                ms.Write(data, 0, data.Length);
                Image activeImage = Image.FromStream(ms);
                pic_bindata.Image = activeImage;
            }
            catch
            {
                MessageBox.Show("系统访问API出差，请检查参数或者网络。");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                string requestURL = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + cmb_URL.Text;
                string result = object_remote.getRemoteRequestToStringWithCookieHeader(txtInput.Text, requestURL, 1000 * 60, 100000);
                txtResult.Text = result;
            }
            catch
            {
                MessageBox.Show("系统访问API出差，请检查参数或者网络。");
            }
        }

        protected void Flush_ResourceLst()
        {
            try
            {
                string getArrUrl = "api_GetDataAggInfo.aspx?cid="+GlobalVars.cid;
                string requestURL = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + "/data/" + getArrUrl;
                string result = object_remote.getRemoteRequestToStringWithCookieHeader("<root></root>", requestURL, 1000 * 60, 100000);
                XmlDocument resultDoc = new XmlDocument();
                resultDoc.LoadXml(result);
                XmlNodeList msgNodeList = resultDoc.SelectNodes("/root/msg");
                if (msgNodeList.Count == 0)
                {
                    return;
                }
                else
                {
                    lst_resource.Items.Clear();
                    foreach (XmlNode activeMsgNode in msgNodeList)
                    {
                        string id = class_XmlHelper.GetAttrValue(activeMsgNode, "id");
                        ListViewItem lstRootItem = new ListViewItem();
                        lstRootItem.Text = id;
                        lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "symbol"));
                        lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "type"));
                        lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "produce"));
                        lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "isBinary"));
                        lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "isBase64"));
                        lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "isDES"));
                        lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "DESKey"));
                        lst_resource.Items.Add(lstRootItem);
                    }
                }
            }
            catch
            {
                MessageBox.Show("系统访问API出差，请检查参数或者网络。");
            }
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            Flush_ResourceLst();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ImportTextData form = new ImportTextData(this.object_remote);
            form.activeServerUrl = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text;
            form.ShowDialog();
            Flush_ResourceLst();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ImportBinData form = new ImportBinData(this.object_remote);
            form.activeServerUrl = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text;
            form.ShowDialog();
            Flush_ResourceLst();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string getArrUrl = "api_GetDataAggInfo.aspx";
                string requestURL = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + "/data/" + getArrUrl;
                string result = object_remote.getRemoteRequestToStringWithCookieHeader("<root></root>", requestURL, 1000 * 60, 100000);
                XmlDocument resultDoc = new XmlDocument();
                resultDoc.LoadXml(result);
                lst_resource.Items.Clear();
                XmlNodeList searchNodes = resultDoc.SelectNodes("/root/msg[@symbol='" + txt_datasearchkey.Text + "']");
                foreach (XmlNode activeMsgNode in searchNodes)
                {
                    string id = class_XmlHelper.GetAttrValue(activeMsgNode, "id");
                    ListViewItem lstRootItem = new ListViewItem();
                    lstRootItem.Text = id;
                    lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "symbol"));
                    lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "type"));
                    lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "produce"));
                    lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "isBinary"));
                    lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "isBase64"));
                    lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "isDES"));
                    lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "DESKey"));
                    lst_resource.Items.Add(lstRootItem);
                }

            }
            catch
            {
                MessageBox.Show("系统访问API出差，请检查参数或者网络。");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(lst_resource.SelectedItems.Count>0)
            {
                ListViewItem selectedItem = lst_resource.SelectedItems[0];
                string symbol = selectedItem.SubItems[1].Text;
                string type = selectedItem.SubItems[2].Text;
                if(type=="text")
                {
                    txt_getingdata.Text = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + "/Data/api_GetMetaText.aspx?cid=" + GlobalVars.cid + "&symbol=" + symbol;
                    string result = object_remote.getRemoteRequestToStringWithCookieHeader("<root></root>", txt_getingdata.Text, 1000 * 60, 100000);
                    XmlDocument resultDoc = new XmlDocument();
                    resultDoc.LoadXml(result);
                    XmlNode msgNode = resultDoc.SelectSingleNode("/root/msg");
                    if (msgNode != null)
                    {
                        string data = class_XmlHelper.GetAttrValue(msgNode, "msg");
                        txt_prevText.Text = class_CommonUtil.Decoder_Base64(data);
                    }
                    else                    
                        MessageBox.Show("无法获取数据，请联系系统管理员.");
                }
                else if (type == "png" || type == "jpg" || type == "jpeg" || type == "gif")
                {
                    txt_getingdata.Text = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + "/Data/api_GetBinData.aspx?cid=" + GlobalVars.cid + "&symbol=" + symbol;
                    byte[] result = object_remote.getRemoteRequestToByteWithCookieHeader("<root></root>", txt_getingdata.Text, 1000 * 60, 100000);
                    if (result != null && result.Length > 0)
                    {                        
                        FileStream tmpFileStream = new FileStream("tmpimage." + type, FileMode.Create);
                        BinaryWriter tmpBinWr = new BinaryWriter(tmpFileStream);
                        tmpBinWr.Write(result);
                        tmpBinWr.Flush();
                        tmpFileStream.Close();
                        pic_previmg.Image = Image.FromFile("tmpimage." + type);                                                
                    }
                    else
                        MessageBox.Show("无法获取数据，请联系系统管理员.");
                }
            }
        }

        private void imageCoderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncoderMetrixImage obj = new EncoderMetrixImage(object_remote);
            obj.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lst_resource.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lst_resource.SelectedItems[0];
                string symbol = selectedItem.SubItems[1].Text;
                string id = lst_resource.SelectedItems[0].Text;
                if (MessageBox.Show("请确认需要删除的数据：" + symbol + ",此次删除操作无法恢复！确定吗？","确定操作",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    txt_getingdata.Text = "不提供删除数据的URL，如有需要，请联系管理员。";
                    string actionUrl = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + "/Data/api_RemoveMetaData.aspx?cid=" + GlobalVars.cid + "&id=" + id;
                    string result = object_remote.getRemoteRequestToStringWithCookieHeader("<root></root>", actionUrl, 1000 * 60, 100000);
                    if(result.Contains("true"))                    
                        Flush_ResourceLst();
                    else
                    {
                        MessageBox.Show("无法执行操作，请联系系统管理员.");
                    }
                }
            }
            else
            {
                MessageBox.Show("无法删除数据，请先选择需要删除的数据.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_relationsymbol.Text))
                MessageBox.Show("请先填写标识后在执行操作.");
            else
            {
                string actionUrl = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + "/Data/api_SetNewRelationDoc.aspx?cid=" + GlobalVars.cid + "&symbol=" + txt_relationsymbol.Text + "&type=parent";
                string result = object_remote.getRemoteRequestToStringWithCookieHeader("<root></root>", actionUrl, 1000 * 60, 100000);
                if (result.Contains("true"))
                    Flush_ResourceLst();
                else
                {
                    MessageBox.Show("无法执行操作，请联系系统管理员.");
                    
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_relationship_childsymbol.Text))
                MessageBox.Show("请先填写标识后在执行操作.");
            else
            {
                string actionUrl = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + "/Relation/api_SetNewRelationDoc.aspx?cid=" + GlobalVars.cid + "&symbol=" + txt_relationsymbol.Text + "&type=child";
                string result = object_remote.getRemoteRequestToStringWithCookieHeader("<root></root>", actionUrl, 1000 * 60, 100000);
                if (result.Contains("true"))
                    Flush_ResourceLst();
                else
                {
                    MessageBox.Show("无法执行操作，请联系系统管理员.");

                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            flushChildDocument();
        }

        private void flushChildDocument()
        {
            lst_relationshipchild_doclist.Items.Clear();
            try
            {
                string getArrUrl = "api_GetShipList.aspx?cid=" + GlobalVars.cid + "&type=child";
                string requestURL = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + "/Relation/" + getArrUrl;
                string result = object_remote.getRemoteRequestToStringWithCookieHeader("<root></root>", requestURL, 1000 * 60, 100000);
                XmlDocument resultDoc = new XmlDocument();
                resultDoc.LoadXml(result);
                XmlNodeList msgNodeList = resultDoc.SelectNodes("/root/msg");
                if (msgNodeList.Count == 0)
                {
                    return;
                }
                else
                {
                    lst_resource.Items.Clear();
                    buffer_relationDoc.Clear();
                    foreach (XmlNode activeMsgNode in msgNodeList)
                    {
                        string id = class_XmlHelper.GetAttrValue(activeMsgNode, "id");
                        string strdoc = class_XmlHelper.GetAttrValue(activeMsgNode, "relationdoc");
                        string debase64doc = class_CommonUtil.Decoder_Base64(strdoc);
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(debase64doc);
                        buffer_relationDoc.Add(id.ToString(), doc);
                        XmlNodeList groupNodes = doc.SelectNodes("/root/group");
                        ListViewItem lstRootItem = new ListViewItem();
                        lstRootItem.Text = id;
                        lstRootItem.SubItems.Add(class_XmlHelper.GetAttrValue(activeMsgNode, "symbol"));
                        lstRootItem.SubItems.Add(groupNodes.Count.ToString());                       
                        lst_resource.Items.Add(lstRootItem);
                    }
                }
            }
            catch
            {
                MessageBox.Show("系统访问API出差，请检查参数或者网络。");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void lst_relationshipchild_doclist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_relationshipchild_doclist.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lst_relationshipchild_doclist.SelectedItems[0];
                string id = selectedItem.Text;
                XmlDocument activeDoc = buffer_relationDoc[id.ToString()];
                cmb_relationshipchild_groupname.Items.Clear();
                XmlNodeList groupNodes = activeDoc.SelectNodes("/root/group");
                foreach(XmlNode groupNode in groupNodes)
                {
                    string groupName = class_XmlHelper.GetNodeValue(groupNode);
                    cmb_relationshipchild_groupname.Items.Add(groupName);
                }

            }
        }

        private void lst_resource_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (lst_relationshipchild_doclist.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lst_relationshipchild_doclist.SelectedItems[0];
                string id = selectedItem.Text;
                XmlDocument activeDoc = buffer_relationDoc[id.ToString()];
                if (cmb_relationshipchild_groupname.Text != "")
                {
                    XmlNode existedNode = activeDoc.SelectSingleNode("/root/group[@name='" + cmb_relationshipchild_groupname.Text + "']");
                    if(existedNode!=null)
                    {
                        MessageBox.Show("Group 已经存在，不可使用重复的名称，请更换.");
                        return;
                    }
                    else
                    {
                        XmlNode newGroupNode = class_XmlHelper.CreateNode(activeDoc, "group", "");
                        class_XmlHelper.SetAttribute(newGroupNode, "name", cmb_relationshipchild_groupname.Text);
                        activeDoc.SelectSingleNode("/root").AppendChild(newGroupNode);
                        changedFlag_relationDoc[id] = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选择一个存在的Child Documnet后再进行操作.");
                return;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (lst_relationshipchild_doclist.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lst_relationshipchild_doclist.SelectedItems[0];
                string id = selectedItem.Text;
                XmlDocument activeDoc = buffer_relationDoc[id.ToString()];
                if (cmb_relationshipchild_groupname.Text != "")
                {
                    XmlNode existedNode = activeDoc.SelectSingleNode("/root/group[@name='" + cmb_relationshipchild_groupname.Text + "']");
                    if (existedNode == null)
                    {
                        MessageBox.Show("Group 不存在，无法删除不存在的节点.");
                        return;
                    }
                    else
                    {
                        XmlNode removedGroupNode = activeDoc.SelectSingleNode("/root/group[@name='" + cmb_relationshipchild_groupname.Text + "']");
                        activeDoc.SelectSingleNode("/root").RemoveChild(removedGroupNode);
                        cmb_relationshipchild_groupname.Items.Remove(cmb_relationshipchild_groupname.Text);
                        cmb_relationshipchild_groupname.Text = "";
                        changedFlag_relationDoc[id] = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选择一个存在的Child Documnet后再进行操作.");
                return;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (lst_relationshipchild_doclist.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lst_relationshipchild_doclist.SelectedItems[0];
                string id = selectedItem.Text;
                XmlDocument activeDoc = buffer_relationDoc[id.ToString()];
                if (cmb_relationshipchild_groupname.Text != "")
                {
                    XmlNode existedNode = activeDoc.SelectSingleNode("/root/group[@name='" + cmb_relationshipchild_groupname.Text + "']");
                    if (existedNode == null)
                    {
                        MessageBox.Show("Group 不存在，无法为不存在的节点添加属性.");
                        return;
                    }
                    else
                    {
                        if (cmb_relationshipchild_attrname.Text != "")
                        {
                            XmlNode activeGroupNode = activeDoc.SelectSingleNode("/root/group[@name='" + cmb_relationshipchild_groupname.Text + "']");
                            class_XmlHelper.SetAttribute(activeGroupNode, cmb_relationshipchild_attrname.Text, txt_relationshipchild_attrvalue.Text);
                            changedFlag_relationDoc[id] = true;
                            txt_relationshipchild_docsource.Text = activeDoc.OuterXml;
                        }
                        else
                        {
                            MessageBox.Show("属性名称不可为空，无法完成操作.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选择一个存在的Child Documnet后再进行操作.");
                return;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (lst_relationshipchild_doclist.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lst_relationshipchild_doclist.SelectedItems[0];
                string id = selectedItem.Text;
                XmlDocument activeDoc = buffer_relationDoc[id.ToString()];
                if (cmb_relationshipchild_groupname.Text != "")
                {
                    XmlNode existedNode = activeDoc.SelectSingleNode("/root/group[@name='" + cmb_relationshipchild_groupname.Text + "']");
                    if (existedNode == null)
                    {
                        MessageBox.Show("Group 不存在，无法为不存在的节点更新属性.");
                        return;
                    }
                    else
                    {
                        if (cmb_relationshipchild_attrname.Text != "")
                        {
                            XmlNode activeGroupNode = activeDoc.SelectSingleNode("/root/group[@name='" + cmb_relationshipchild_groupname.Text + "']");
                            class_XmlHelper.SetAttribute(activeGroupNode, cmb_relationshipchild_attrname.Text, txt_relationshipchild_attrvalue.Text);
                            changedFlag_relationDoc[id] = true;
                            txt_relationshipchild_docsource.Text = activeDoc.OuterXml;
                        }
                        else
                        {
                            MessageBox.Show("属性名称不可为空，无法完成操作.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选择一个存在的Child Documnet后再进行操作.");
                return;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (lst_relationshipchild_doclist.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lst_relationshipchild_doclist.SelectedItems[0];
                string id = selectedItem.Text;
                XmlDocument activeDoc = buffer_relationDoc[id.ToString()];
                if (cmb_relationshipchild_groupname.Text != "")
                {
                    XmlNode existedNode = activeDoc.SelectSingleNode("/root/group[@name='" + cmb_relationshipchild_groupname.Text + "']");
                    if (existedNode == null)
                    {
                        MessageBox.Show("Group 不存在，无法为不存在的节点更新属性.");
                        return;
                    }
                    else
                    {
                        if (cmb_relationshipchild_attrname.Text != "")
                        {
                            XmlNode activeGroupNode = activeDoc.SelectSingleNode("/root/group[@name='" + cmb_relationshipchild_groupname.Text + "']");
                            XmlAttribute activeAttr = activeGroupNode.Attributes[cmb_relationshipchild_attrname.Text];
                            if(activeAttr!=null)
                            {
                                activeGroupNode.Attributes.Remove(activeAttr);
                                cmb_relationshipchild_attrname.Items.Remove(cmb_relationshipchild_attrname.Text);
                                cmb_relationshipchild_attrname.Text = "";
                                txt_relationshipchild_docsource.Text = activeDoc.OuterXml;
                                changedFlag_relationDoc[id] = true;
                            }
                            else
                            {
                                MessageBox.Show("无法找到属性，无法完成操作.");
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("属性名称不可为空，无法完成操作.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选择一个存在的Child Documnet后再进行操作.");
                return;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                string getArrUrl = "api_GetDataAggInfo.aspx?cid=" + GlobalVars.cid;
                string requestURL = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + "/data/" + getArrUrl;
                string result = object_remote.getRemoteRequestToStringWithCookieHeader("<root></root>", requestURL, 1000 * 60, 100000);
                XmlDocument resultDoc = new XmlDocument();
                resultDoc.LoadXml(result);
                cmb_relationshipchild_symbolsearching.Items.Clear();
                if (cmb_relationshipchild_symbolsearching.Text == "")
                {
                    XmlNodeList msgNodeList = resultDoc.SelectNodes("/root/msg");
                    foreach (XmlNode activeMsgNode in msgNodeList)
                    {
                        string symbol = class_XmlHelper.GetAttrValue(activeMsgNode, "symbol");
                        cmb_relationshipchild_symbolsearching.Items.Add(symbol);
                    }
                }
                else
                {
                    XmlNode searchNode = resultDoc.SelectSingleNode("/root/msg[@symbol='" + cmb_relationshipchild_symbolsearching.Text + "']");
                    if(searchNode!=null)
                    {
                        cmb_relationshipchild_symbolsearching.Items.Add(cmb_relationshipchild_symbolsearching.Text);
                    }
                }

            }
            catch
            {
                MessageBox.Show("系统访问API出差，请检查参数或者网络。");
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (lst_relationshipchild_doclist.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lst_relationshipchild_doclist.SelectedItems[0];
                string id = selectedItem.Text;
                XmlDocument activeDoc = buffer_relationDoc[id.ToString()];
                if (cmb_relationshipchild_groupname.Text != "")
                {
                    XmlNode existedNode = activeDoc.SelectSingleNode("/root/group[@name='" + cmb_relationshipchild_groupname.Text + "']");
                    if (existedNode == null)
                    {
                        MessageBox.Show("Group 不存在，无法为不存在的节点添加属性.");
                        return;
                    }
                    else
                    {
                        if(cmb_relationshipchild_symbolsearching.Text != "")
                        {
                            XmlNode existedResourceNode = existedNode.SelectSingleNode("item[@resource='"+cmb_relationshipchild_symbolsearching.Text+"']");
                            if (existedResourceNode != null)
                            {
                                XmlNode newItemNode = class_XmlHelper.CreateNode(activeDoc, "item", "");
                                class_XmlHelper.SetAttribute(existedResourceNode, "resource", cmb_relationshipchild_symbolsearching.Text);
                                existedNode.AppendChild(newItemNode);
                                txt_relationshipchild_docsource.Text = activeDoc.OuterXml;
                                changedFlag_relationDoc[id] = true;
                            }
                            else
                            {
                                MessageBox.Show("添加的资源已经存在，无法重复添加.");
                                return;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选择一个存在的Child Documnet后再进行操作.");
                return;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (lst_relationshipchild_doclist.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lst_relationshipchild_doclist.SelectedItems[0];
                string id = selectedItem.Text;
                XmlDocument activeDoc = buffer_relationDoc[id.ToString()];
                if (cmb_relationshipchild_groupname.Text != "")
                {
                    XmlNode existedNode = activeDoc.SelectSingleNode("/root/group[@name='" + cmb_relationshipchild_groupname.Text + "']");
                    if (existedNode == null)
                    {
                        MessageBox.Show("Group 不存在，无法为不存在的节点添加属性.");
                        return;
                    }
                    else
                    {
                        if (cmb_relationshipchild_symbolsearching.Text != "")
                        {
                           XmlNode existedResourceNode = existedNode.SelectSingleNode("item[@resource='" + cmb_relationshipchild_symbolsearching.Text + "']");
                           if(existedResourceNode!=null)
                           {
                               existedResourceNode.RemoveChild(existedResourceNode);
                               txt_relationshipchild_docsource.Text = activeDoc.OuterXml;
                               changedFlag_relationDoc[id] = true;
                           }
                           else                           
                           {
                               MessageBox.Show("无法定位到资源配置，请检查后再操作.");
                               return;
                           }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选择一个存在的Child Documnet后再进行操作.");
                return;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lst_relationshipchild_doclist.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lst_relationshipchild_doclist.SelectedItems[0];
                string id = selectedItem.Text;
                XmlDocument activeDoc = buffer_relationDoc[id.ToString()];                
                txt_relationshipchild_docsource.Text = activeDoc.OuterXml;                               
            }
            else
            {
                MessageBox.Show("请先选择一个存在的Child Documnet后再进行操作.");
                return;
            }
           
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
           foreach(string activeID in changedFlag_relationDoc.Keys)
           {
               if (changedFlag_relationDoc[activeID])
               {
                   string id = activeID;
                   string doc = buffer_relationDoc[activeID].OuterXml;
                   string base64Doc = class_CommonUtil.Encoder_Base64(doc);
                   string inputDoc = "<root><id>" + id + "</id><doc>" + base64Doc + "</doc>";
                   string getArrUrl = "api_SetUpdateRelationDoc.aspx?cid=" + GlobalVars.cid;
                   string requestURL = "http://" + cmb_server.Text + "/" + cmb_vfolder.Text + "/Relation/" + getArrUrl;
                   string result = object_remote.getRemoteRequestToStringWithCookieHeader(inputDoc, requestURL, 1000 * 60, 100000);
                   if (result.Contains("true"))
                       MessageBox.Show("你已经成功更新了所有的关系文档.");
                   else
                       MessageBox.Show("更新关系文档失败，请联系管理员.");

               }
           }
        }
  
    }
}
