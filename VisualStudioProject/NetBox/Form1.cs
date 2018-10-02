using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Configuration;
using System.Threading.Tasks;

namespace NetBox
{
    public partial class Form1 : Form
    {
        #region init
        List<string> _myNet_Name = new List<string>();
        List<string> _myNet_IP = new List<string>();
        List<string> _myNet_Status = new List<string>();
        List<string> _mnuText = new List<string>();
        List<string> _mnuCmd = new List<string>();
        List<string> _mnuArg = new List<string>();
        Point pt_start = Point.Empty;
        Point pt_end = Point.Empty;
        bool NetMouseDown;
        Rectangle mRect;
        private bool MouseIsDown = false;
        int _myX;
        int _myY;
        bool bPinging;
        int _myWidth;
        int _myHeight;
        Ping pinger = new Ping();
        PingReply pReply;
        //file names moved to app.config
        string netlistPath = Path.Combine(Application.StartupPath, ConfigurationManager.AppSettings["netlist"]),
               netcmdPath = Path.Combine(Application.StartupPath, ConfigurationManager.AppSettings["netcmd"]),
               configPath = Path.Combine(Application.StartupPath, ConfigurationManager.AppSettings["config"]);
        #endregion

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        #region Initial loading
        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            LoadData();
        }
        /// <summary>
        /// Loads initial data and config.
        /// </summary>
        private void LoadData()
        {
            //read file netlist.txt
            try
            {
                //read net list file
                ReadNetList();

                //read cmd file
                ReadNetCmd();

                //read config file
                ReadConfig();

                TimerStart.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Read the config files and populate form.
        /// </summary>
        private void ReadConfig()
        {
            string fName = configPath;
            string[] lines = System.IO.File.ReadAllLines(fName);
            foreach (string line in lines)
            {

                if (line.Substring(0, 11) == "snaptogrid=")
                {
                    //snap to grip option
                    string[] aLine = line.Substring(11, (line.Length - 11)).Split(new[] { "," }, StringSplitOptions.None);
                    if (aLine.Length > 0)
                    {
                        chkSnapToGrid.Checked = Convert.ToBoolean(Convert.ToInt16(aLine[0]));
                        txtGridSize.Text = aLine[1];
                    }
                }
                else if (line.Substring(0, 12) == "autosavenet=")
                {
                    //auto save option
                    chkAutoSaveNet.Checked = Convert.ToBoolean(Convert.ToInt16(line.Substring(12, (line.Length - 12))));
                }
            }
        }
        /// <summary>
        /// Read commands file.
        /// </summary>
        private void ReadNetCmd()
        {
            string fName = netcmdPath;// Application.StartupPath + "\\netcmd.txt";
            string[] lines = System.IO.File.ReadAllLines(fName);
            foreach (string line in lines)
            {
                //not a header
                if (line != "[Text],[Command],[Argument] ,")
                {
                    string[] aLine = line.Split(new[] { "," }, StringSplitOptions.None);
                    if (aLine.Length > 0)
                    {
                        _mnuText.Add(aLine[0]);
                        _mnuCmd.Add(aLine[1]);
                        _mnuArg.Add(aLine[2]);
                        ToolStripMenuItem newMenu = new ToolStripMenuItem(_mnuText[_mnuText.Count - 1], null, cmnBox_Click);
                        cmnBox.Items.Add(newMenu);
                        cboMnuText.Items.Add(aLine[0]);
                    }
                }
            }
        }
        /// <summary>
        /// Read host list.
        /// </summary>
        private void ReadNetList()
        {
            string fName = netlistPath;
            string[] lines = System.IO.File.ReadAllLines(fName);
            foreach (string line in lines)
            {
                if (line.Substring(0, 8) == "WINSIZE=")
                {
                    //check if window size line
                    string[] aLine = (line.Substring(8, (line.Length - 8))).Split(new[] { "," }, StringSplitOptions.None);
                    if (aLine.Length > 0)
                    {
                        _myWidth = Convert.ToInt16(aLine[0]);
                        _myHeight = Convert.ToInt16(aLine[1]);
                    }
                }
                else if (line != "[No],[Name],[IP],")
                {
                    //case of normal record
                    string[] aLine = line.Split(new[] { "," }, StringSplitOptions.None);
                    if (aLine.Length > 0)
                    {
                        //_myNet_No.Add(_myNet_No.Count + 1)
                        _myNet_Name.Add(aLine[1]);
                        _myNet_IP.Add(aLine[2]);
                        _myNet_Status.Add("");
                        AddNewBox(aLine[1], Convert.ToInt16(aLine[3]), Convert.ToInt16(aLine[4]));
                    }
                }
                else
                {
                    //case of header, do nothing
                }

            }
        }
        #endregion

        /// <summary>
        /// Change window size
        /// </summary>
        /// <param name="_w"></param>
        /// <param name="_h"></param>
        public void tSize(int _w, int _h)
        {
            this.Width = _w;
            this.Height = _h;
        }
        /// <summary>
        /// Add new box
        /// </summary>
        /// <param name="sName">Name</param>
        /// <param name="iLeft">Left position</param>
        /// <param name="iTop">Top position</param>
        public void AddNewBox(string sName, int iLeft, int iTop)
        {
            Label newBox = new Label();
            //newBox.Tag = sName
            newBox.Text = sName;
            newBox.BorderStyle = lblBox.BorderStyle;
            newBox.Font = lblBox.Font;
            newBox.TextAlign = lblBox.TextAlign;
            newBox.Height = lblBox.Height;
            newBox.Width = lblBox.Width;
            newBox.BackColor = lblBox.BackColor;
            newBox.ContextMenuStrip = cmnBox;
            newBox.MouseDown += lblBox_MouseDown;
            newBox.MouseUp += lblBox_MouseUp;
            newBox.MouseMove += lblBox_MouseMove;
            newBox.DoubleClick += lblBox_DoubleClick;
            PanelNet.Controls.Add(newBox);
            PanelNet.Controls[PanelNet.Controls.Count - 1].Left = iLeft;
            PanelNet.Controls[PanelNet.Controls.Count - 1].Top = iTop;
        }

        private void btnAddBox_Click(System.Object sender, System.EventArgs e)
        {
            AddNewHost();
        }
        /// <summary>
        /// Adds new host to list, with checking for duplicates.
        /// </summary>
        private void AddNewHost()
        {
            string sBox = "";
            sBox = Interaction.InputBox("Hostname:", "New Box", "");
            if (!string.IsNullOrEmpty(sBox))
            {
                int iName = _myNet_Name.IndexOf(sBox);
                if (iName < 0)
                {
                    int i = PanelNet.Controls.Count;
                    //_myNet_No.Add(i)
                    _myNet_Name.Add(sBox);
                    _myNet_IP.Add(GetIPAddress(sBox));
                    _myNet_Status.Add("");
                    AddNewBox(sBox, (i * 10), (i * 10));
                }
                else
                {
                    Interaction.MsgBox("Duplicate Hostname!");
                }
            }
        }

        private void lblBox_DoubleClick(object sender, System.EventArgs e)
        {
            PanelInfo.Visible = true;
            Label tLabel = sender as Label;
            lblHostname.Text = tLabel.Text;
            txtHostname.Text = tLabel.Text;
            txtIPaddress.Text = _myNet_IP[_myNet_Name.IndexOf(tLabel.Text)];
            btnEditbox.Enabled = true;
            btnDeleteBox.Enabled = true;
        }

        private void lblBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _myX = e.X;
                //- sender.Left
                _myY = e.Y;
                //- sender.Top
                MouseIsDown = true;
            }
        }

        /// <summary>
        /// Mouse up event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblBox_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseIsDown = false;
                if (chkSnapToGrid.Checked == true)
                {
                    Control sCtrl = (Control)sender;
                    if ((String)sCtrl.Tag != "Selected")
                    {
                        int iX = (sCtrl.Left + e.X) - _myX;
                        int iY = (sCtrl.Top + e.Y) - _myY;
                        int iG = Convert.ToInt16(txtGridSize.Text);
                        iX = (iX / iG) * iG;
                        iY = (iY / iG) * iG;
                        sCtrl.Left = iX;
                        sCtrl.Top = iY;
                    }
                    foreach (Control ctrl in PanelNet.Controls)
                    {
                        if (ctrl.Tag != null && ctrl.Tag.ToString() == "Selected")
                        {
                            int iX = (ctrl.Left + e.X) - _myX;
                            int iY = (ctrl.Top + e.Y) - _myY;
                            int iG = Convert.ToInt16(txtGridSize.Text);
                            iX = (iX / iG) * iG;
                            iY = (iY / iG) * iG;
                            ctrl.Left = iX;
                            ctrl.Top = iY;
                        }
                    }
                }
            }
        }

        private void btnSave_Click(System.Object sender, System.EventArgs e)
        {
            int iB = _myNet_Name.IndexOf(lblHostname.Text);
            //_myNet_No(iB) = txtBoxno.Text
            lblHostname.Text = txtHostname.Text;
            _myNet_Name[iB] = txtHostname.Text;
            _myNet_IP[iB] = txtIPaddress.Text;
            PanelNet.Controls[iB + 1].Text = txtHostname.Text;
            btnCancel_Click(null, null);
        }

        private void btnEditbox_Click(System.Object sender, System.EventArgs e)
        {
            btnEditbox.Enabled = false;
            btnDeleteBox.Enabled = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnCancel_Click(System.Object sender, System.EventArgs e)
        {
            int iB = _myNet_Name.IndexOf(lblHostname.Text);
            txtHostname.Text = _myNet_Name[iB];
            txtIPaddress.Text = _myNet_IP[iB];
            btnEditbox.Enabled = true;
            btnDeleteBox.Enabled = true;
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }

        private void btnDeleteBox_Click(System.Object sender, System.EventArgs e)
        {
            if (Interaction.MsgBox("Are you sure want to Delete:" + Constants.vbNewLine + lblHostname.Text, Constants.vbYesNo) == Constants.vbYes)
            {
                DeleteBox(lblHostname.Text);
                lblHostname.Text = "";
                txtHostname.Text = "";
                txtIPaddress.Text = "";
                btnEditbox.Enabled = false;
                btnDeleteBox.Enabled = false;
            }
        }
        /// <summary>
        /// Deletes a box of the list by name.
        /// </summary>
        /// <param name="sName">The name of the box to delete.</param>
        public void DeleteBox(string sName)
        {
            int iB = _myNet_Name.IndexOf(sName);
            if (iB == 0)
            {
                if (_myNet_Name.Count == 1)
                {
                    //_myNet_No.Clear()
                    _myNet_Name.Clear();
                    _myNet_IP.Clear();
                    _myNet_Status.Clear();
                }
                else
                {
                    //MsgBox("Can not Delete item 0")
                    //Exit Sub
                    int i;
                    for (i = 0; i <= _myNet_Name.Count - 2; i++)
                    {
                        _myNet_Name[i] = _myNet_Name[i + 1];
                        _myNet_IP[i] = _myNet_IP[i + 1];
                        _myNet_Status[i] = _myNet_Status[i + 1];
                    }
                    _myNet_Name.RemoveAt(_myNet_Name.Count - 1);
                    _myNet_IP.RemoveAt(_myNet_Name.Count - 1);
                    _myNet_Status.RemoveAt(_myNet_Name.Count - 1);
                }
            }
            else
            {
                //_myNet_No.RemoveAt(iB)
                _myNet_Name.RemoveAt(iB);
                _myNet_IP.RemoveAt(iB);
                _myNet_Status.RemoveAt(iB);
            }
            PanelNet.Controls.Remove(PanelNet.Controls[iB + 1]);
        }

        private void TimerPing_Tick(System.Object sender, System.EventArgs e)
        {
            if (bPinging == true)
                return;
            UpdatePingStats();
        }

        private void UpdatePingStats()
        {
            try
            {
                //System.Threading.Thread t = new System.Threading.Thread(PingNet);
                //t.Start();
                //System.Threading.Thread t2 = new System.Threading.Thread(GetIPs);
                //t2.Start();

                var t = Task.Factory.StartNew(() => {
                    PingNet();
                });
                var t2 = Task.Factory.StartNew(() =>
                {
                    GetIPs();
                });
                t.Start();
                t2.Start();

                var tWait = Task.Factory.StartNew(() =>
                {
                    Task.WaitAll(t, t2);

                    for (int i = 0; i <= _myNet_Name.Count - 1; i++)
                    {
                        ToolTip1.SetToolTip(PanelNet.Controls[i + 1], _myNet_Status[i]);
                    }    
                });

                tWait.Start();

                

            }
            catch (Exception ex)
            {
            }
        }

        public void PingNet()
        {
            bPinging = true;
            try
            {
                var ptimeout = int.Parse(ConfigurationManager.AppSettings["pingtimeout"]);
                int i;
                for (i = 0; i <= _myNet_Name.Count - 1; i++)
                {
                    if (!string.IsNullOrEmpty(_myNet_Name[i]) & !string.IsNullOrEmpty(_myNet_IP[i]))
                    {
                        string sHost = _myNet_Name[i];
                        try
                        {
                            pReply = pinger.Send(sHost, ptimeout);
                            if (pReply.Status == IPStatus.Success)
                            {
                                _myNet_Status[i] = "OK";
                                if (PanelNet.Controls[i + 1].Tag != null && PanelNet.Controls[i + 1].Tag.ToString() == "Selected")
                                {
                                    PanelNet.Controls[i + 1].BackColor = Color.DarkGreen;
                                }
                                else
                                {
                                    PanelNet.Controls[i + 1].BackColor = Color.LightGreen;
                                }
                            }
                            else
                            {
                                _myNet_Status[i] = "RTO";
                                if (PanelNet.Controls[i + 1].Tag != null && PanelNet.Controls[i + 1].Tag.ToString() == "Selected")
                                {
                                    PanelNet.Controls[i + 1].BackColor = Color.DarkRed;
                                }
                                else
                                {
                                    PanelNet.Controls[i + 1].BackColor = Color.Red;
                                }
                            }
                        }
                        catch (Exception)
                        {
                            _myNet_Status[i] = "RTO";
                            if (PanelNet.Controls[i + 1].Tag != null && PanelNet.Controls[i + 1].Tag.ToString() == "Selected")
                            {
                                PanelNet.Controls[i + 1].BackColor = Color.DarkRed;
                            }
                            else
                            {
                                PanelNet.Controls[i + 1].BackColor = Color.Red;
                            }
                        }
                    }
                    else
                    {
                        if (_myNet_Status[i] == "DNS lookup fail")
                        {
                            PanelNet.Controls[i + 1].BackColor = Color.Gray;
                        }
                    }
                    //ToolTip1.SetToolTip(PanelNet.Controls(i + 1), _myNet_Status(i))
                }
            }
            catch (Exception)
            {
                //MsgBox(ex.Message)
            }
            bPinging = false;
        }

        private void btnSaveNet_Click(System.Object sender, System.EventArgs e)
        {
            SaveState();
        }

        private void SaveState()
        {
            //write file netlist.txt
            try
            {
                int fNum = FileSystem.FreeFile();
                string fName = netlistPath;
                FileSystem.FileOpen(fNum, fName, OpenMode.Output, OpenAccess.Write, OpenShare.Shared);
                string sPrint = null;
                sPrint = "WINSIZE=" + this.Width + "," + this.Height + Constants.vbNewLine;
                sPrint = sPrint + "[No],[Name],[IP]," + Constants.vbNewLine;
                int i;
                for (i = 0; i <= _myNet_Name.Count - 1; i++)
                {
                    sPrint += (i + 1) + "," + _myNet_Name[i] + "," + _myNet_IP[i] + "," + PanelNet.Controls[i + 1].Left + "," + PanelNet.Controls[i + 1].Top + "," + Constants.vbNewLine;
                }
                FileSystem.Print(fNum, sPrint);
                FileSystem.FileClose(fNum);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void EditToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            string sName = cmnBox.SourceControl.Text;
            int iB = _myNet_Name.IndexOf(sName);
            if (iB < 0)
            {
            }
            else
            {
                lblBox_DoubleClick(cmnBox.SourceControl, null);
                btnEditbox_Click(null, null);
            }
        }

        private void DeleteToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {
            string sName = cmnBox.SourceControl.Text;
            int iB = _myNet_Name.IndexOf(sName);
            if (iB < 0)
            {
            }
            else
            {
                if (cmnBox.SourceControl.Tag != null && cmnBox.SourceControl.Tag.ToString() == "Selected")
                {
                    btnDelSel_Click(null, null);
                }
                else
                {
                    lblHostname.Text = sName;
                    btnDeleteBox_Click(null, null);
                }
            }
        }

        private void PanelNet_DoubleClick(object sender, System.EventArgs e)
        {
            if (btnSave.Visible == false)
            {
                PanelInfo.Visible = false;
            }
        }

        private void txtCustCmd_Click(object sender, System.EventArgs e)
        {
            TimerGetCursorPos.Start();
        }
        private void txtCustCmd_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            TimerGetCursorPos.Start();
        }
        private void TimerGetCursorPos_Tick(System.Object sender, System.EventArgs e)
        {
            TimerGetCursorPos.Stop();
            GetCursorPos(txtCustCmd);
        }
        private void txtArg_Click(object sender, System.EventArgs e)
        {
            TimerGetCursorPos2.Start();
        }
        private void txtArg_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            TimerGetCursorPos2.Start();
        }
        private void TimerGetCursorPos2_Tick(System.Object sender, System.EventArgs e)
        {
            TimerGetCursorPos2.Stop();
            GetCursorPos(txtArg);
        }
        /// <summary>
        /// Gets the cursor index position  from textbox
        /// </summary>
        /// <param name="tBox"></param>
        private void GetCursorPos(TextBox tBox)
        {
            int index = tBox.SelectionStart;
            int currentLine = tBox.GetLineFromCharIndex(index);
            int currentColumn = index - tBox.GetFirstCharIndexFromLine(currentLine);
            lblCursorPos.Text = Convert.ToString(currentColumn);
        }

        private void btnInsertVar_Click(System.Object sender, System.EventArgs e)
        {
            string sVar = "[" + cboVarBox.Text + "]";
            string sBef = Strings.Left(txtCustCmd.Text, Convert.ToInt16(lblCursorPos.Text));
            string sAft = Strings.Right(txtCustCmd.Text, txtCustCmd.Text.Length - Convert.ToInt16(lblCursorPos.Text));
            txtCustCmd.Text = sBef + sVar + sAft;
        }

        private void cmnBox_Click(object sender, System.EventArgs e)
        {
            try
            {
                bool done = false;
                for (int x = 0; x < PanelNet.Controls.Count; x++)
                {
                    if ((string)PanelNet.Controls[x].Tag == "Selected")
                    {
                        done = true;
                        string sName = PanelNet.Controls[x].Text;
                        int iB = _myNet_Name.IndexOf(sName);
                        string mnuText = null;
                        mnuText = ((ToolStripMenuItem)sender).Text;
                        for (int i = 0; i <= _mnuText.Count - 1; i++)
                        {
                            if (Strings.Trim(mnuText) == Strings.Trim(_mnuText[i]))
                            {
                                //cek variable for Command
                                string[] aCmd = Strings.Split(_mnuCmd[i], "[");
                                string sCmd = null;
                                if (aCmd.Length > 0)
                                {
                                    sCmd = aCmd[0];
                                    int j;
                                    for (j = 1; j <= aCmd.Length - 1; j++)
                                    {
                                        string[] aVar = Strings.Split(aCmd[j], "]");
                                        int k;
                                        for (k = 0; k <= aVar.Length - 1; k++)
                                        {
                                            if (k == 0)
                                            {
                                                string sVar = aVar[0];
                                                switch (sVar)
                                                {
                                                    case "net.Name":
                                                        sCmd = sCmd + _myNet_Name[iB];
                                                        break;
                                                    case "net.IP":
                                                        sCmd = sCmd + _myNet_IP[iB];
                                                        break;
                                                }
                                            }
                                            else
                                            {
                                                sCmd = sCmd + aVar[k];
                                            }
                                        }

                                    }
                                }
                                else
                                {
                                    sCmd = _mnuCmd[i];
                                }

                                //cek variable for Argument
                                string[] aArg = Strings.Split(_mnuArg[i], "[");
                                string sArg = null;
                                if (aArg.Length > 0)
                                {
                                    sArg = aArg[0];
                                    int j;
                                    for (j = 1; j <= aArg.Length - 1; j++)
                                    {
                                        string[] aVar = Strings.Split(aArg[j], "]");
                                        int k;
                                        for (k = 0; k <= aVar.Length - 1; k++)
                                        {
                                            if (k == 0)
                                            {
                                                string sVar = aVar[0];
                                                switch (sVar)
                                                {
                                                    case "net.Name":
                                                        sArg = sArg + _myNet_Name[iB];
                                                        break;
                                                    case "net.IP":
                                                        sArg = sArg + _myNet_IP[iB];
                                                        break;
                                                }
                                            }
                                            else
                                            {
                                                sArg = sArg + aVar[k];
                                            }
                                        }

                                    }
                                }
                                else
                                {
                                    sArg = _mnuArg[i];
                                }

                                Process.Start(sCmd, sArg);
                            }
                        }
                    }
                }

                if (!done)
                {
                    string sName = cmnBox.SourceControl.Text;
                    int iB = _myNet_Name.IndexOf(sName);
                    string mnuText = null;
                    mnuText = ((ToolStripMenuItem)sender).Text;
                    int i;
                    for (i = 0; i <= _mnuText.Count - 1; i++)
                    {
                        if (Strings.Trim(mnuText) == Strings.Trim(_mnuText[i]))
                        {
                            //cek variable for Command
                            string[] aCmd = Strings.Split(_mnuCmd[i], "[");
                            string sCmd = null;
                            if (aCmd.Length > 0)
                            {
                                sCmd = aCmd[0];
                                int j;
                                for (j = 1; j <= aCmd.Length - 1; j++)
                                {
                                    string[] aVar = Strings.Split(aCmd[j], "]");
                                    int k;
                                    for (k = 0; k <= aVar.Length - 1; k++)
                                    {
                                        if (k == 0)
                                        {
                                            string sVar = aVar[0];
                                            switch (sVar)
                                            {
                                                case "net.Name":
                                                    sCmd = sCmd + _myNet_Name[iB];
                                                    break;
                                                case "net.IP":
                                                    sCmd = sCmd + _myNet_IP[iB];
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            sCmd = sCmd + aVar[k];
                                        }
                                    }

                                }
                            }
                            else
                            {
                                sCmd = _mnuCmd[i];
                            }

                            //cek variable for Argument
                            string[] aArg = Strings.Split(_mnuArg[i], "[");
                            string sArg = null;
                            if (aArg.Length > 0)
                            {
                                sArg = aArg[0];
                                int j;
                                for (j = 1; j <= aArg.Length - 1; j++)
                                {
                                    string[] aVar = Strings.Split(aArg[j], "]");
                                    int k;
                                    for (k = 0; k <= aVar.Length - 1; k++)
                                    {
                                        if (k == 0)
                                        {
                                            string sVar = aVar[0];
                                            switch (sVar)
                                            {
                                                case "net.Name":
                                                    sArg = sArg + _myNet_Name[iB];
                                                    break;
                                                case "net.IP":
                                                    sArg = sArg + _myNet_IP[iB];
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            sArg = sArg + aVar[k];
                                        }
                                    }

                                }
                            }
                            else
                            {
                                sArg = _mnuArg[i];
                            }

                            Process.Start(sCmd, sArg);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void cboMnuText_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            int i = cboMnuText.SelectedIndex;
            if (i >= 0)
            {
                txtCustCmd.Text = _mnuCmd[i];
                txtArg.Text = _mnuArg[i];
            }
            lblMnuId.Text = Convert.ToString(i);
            btnEditMenu.Enabled = true;
            btnDeleteMenu.Enabled = true;
        }

        private void btnEditMenu_Click(System.Object sender, System.EventArgs e)
        {
            if (Conversion.Val(lblMnuId.Text) >= 0)
            {
                btnOkEditMenu.Visible = true;
                btnCancelEditMenu.Visible = true;
                btnEditMenu.Enabled = false;
                btnDeleteMenu.Enabled = false;
                txtCustCmd.Enabled = true;
                txtArg.Enabled = true;
                btnInsertVar.Enabled = true;
                btnInserVar2.Enabled = true;
                lblEditMode.Text = "Edit";
            }
        }

        private void btnCancelEditMenu_Click(System.Object sender, System.EventArgs e)
        {
            btnOkEditMenu.Visible = false;
            btnCancelEditMenu.Visible = false;
            btnAddMenu.Enabled = true;
            txtCustCmd.Enabled = false;
            txtArg.Enabled = false;
            btnInsertVar.Enabled = false;
            btnInserVar2.Enabled = false;
            if (lblEditMode.Text == "Edit")
            {
                btnEditMenu.Enabled = true;
                btnDeleteMenu.Enabled = true;
                int id = Convert.ToInt16(lblMnuId.Text);
                cboMnuText.Text = _mnuText[id];
                txtCustCmd.Text = _mnuCmd[id];
                txtArg.Text = _mnuArg[id];
            }
            else
            {
                cboMnuText.Text = "";
                txtCustCmd.Text = "";
                txtArg.Text = "";
            }
            lblEditMode.Text = "";
        }

        private void btnOkEditMenu_Click(System.Object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(cboMnuText.Text))
            {
                Interaction.MsgBox("Text is empty !");
                return;
            }
            int id = 0;
            switch (lblEditMode.Text)
            {
                case "Add":
                    //id = _mnuCmd.Count
                    _mnuCmd.Add(txtCustCmd.Text);
                    _mnuArg.Add(txtArg.Text);
                    _mnuText.Add(cboMnuText.Text);
                    cboMnuText.Items.Add(cboMnuText.Text);
                    //cboMnuText.Items.Clear()
                    //For i = 0 To _mnuText.Count - 1
                    //    cboMnuText.Items.Add(_mnuText(i))
                    //Next
                    ToolStripMenuItem newMenu = new ToolStripMenuItem(cboMnuText.Text, null, cmnBox_Click);
                    cmnBox.Items.Add(newMenu);
                    break;
                case "Edit":
                    id = Convert.ToInt16(lblMnuId.Text);
                    _mnuCmd[id] = txtCustCmd.Text;
                    _mnuArg[id] = txtArg.Text;
                    _mnuText[id] = cboMnuText.Text;
                    cboMnuText.Items[id] = _mnuText[id];
                    cmnBox.Items[id + 3].Text = _mnuText[id];
                    break;
                //cboMnuText.Items.Clear()
                //For i = 0 To _mnuText.Count - 1
                //    cboMnuText.Items.Add(_mnuText(i))
                //    cmnBox.Items(i + 3).Text = _mnuText(i)
                //Next
            }

            btnCancelEditMenu_Click(null, null);
        }

        private void btnAddMnu_Click(System.Object sender, System.EventArgs e)
        {
            cboMnuText.Text = "";
            txtCustCmd.Text = "";
            txtArg.Text = "";
            txtCustCmd.Enabled = true;
            txtArg.Enabled = true;
            btnInsertVar.Enabled = true;
            btnInserVar2.Enabled = true;
            btnAddMenu.Enabled = false;
            btnEditMenu.Enabled = false;
            btnDeleteMenu.Enabled = false;
            btnOkEditMenu.Visible = true;
            btnCancelEditMenu.Visible = true;
            lblEditMode.Text = "Add";
            lblMnuId.Text = Convert.ToString(cboMnuText.Items.Count);
        }

        private void btnDeleteMenu_Click(System.Object sender, System.EventArgs e)
        {
            int iB = Convert.ToInt16(lblMnuId.Text);
            if (iB < 0)
                return;
            if (Interaction.MsgBox("Are you sure want to Delete?", Constants.vbYesNo) == Constants.vbYes)
            {
                if (iB == 0)
                {
                    if (_mnuText.Count == 1)
                    {
                        _mnuText.Clear();
                        _mnuCmd.Clear();
                        _mnuArg.Clear();
                        cboMnuText.Items.Clear();
                    }
                    else
                    {
                        int i;
                        for (i = 0; i <= _mnuText.Count - 2; i++)
                        {
                            _mnuText[i] = _mnuText[i + 1];
                            _mnuCmd[i] = _mnuCmd[i + 1];
                            _mnuArg[i] = _mnuArg[i + 1];
                        }
                        _mnuText.RemoveAt(_mnuText.Count - 1);
                        _mnuCmd.RemoveAt(_mnuText.Count - 1);
                        _mnuArg.RemoveAt(_mnuText.Count - 1);
                        cboMnuText.Items.Remove(cboMnuText.Items[0]);
                        //MsgBox("Can not Delete item 0")
                        //Exit Sub
                    }
                }
                else
                {
                    _mnuText.RemoveAt(iB);
                    _mnuCmd.RemoveAt(iB);
                    _mnuArg.RemoveAt(iB);
                    cboMnuText.Items.RemoveAt(iB);
                }
                cmnBox.Items.RemoveAt(iB + 3);
                cboMnuText.Text = "";
                txtCustCmd.Text = "";
                txtArg.Text = "";
                lblMnuId.Text = "-1";
            }
        }

        private void btnSaveCmd_Click(System.Object sender, System.EventArgs e)
        {
            SaveCommands();
        }

        private void SaveCommands()
        {
            //write file netcmd.txt
            try
            {
                int fNum = FileSystem.FreeFile();
                string fName = netcmdPath;
                FileSystem.FileOpen(fNum, fName, OpenMode.Output, OpenAccess.Write, OpenShare.Shared);
                string sPrint = null;
                sPrint = "[Text],[Command],[Argument] ," + Constants.vbNewLine;
                int i;
                for (i = 0; i <= _mnuText.Count - 1; i++)
                {
                    sPrint += _mnuText[i] + Constants.vbTab + _mnuCmd[i] + Constants.vbTab + _mnuArg[i] + Constants.vbTab + Constants.vbNewLine;
                }
                FileSystem.Print(fNum, sPrint);
                FileSystem.FileClose(fNum);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void btnInserVar2_Click(System.Object sender, System.EventArgs e)
        {
            string sVar = "[" + cboVarBox2.Text + "]";
            string sBef = Strings.Left(txtArg.Text, Convert.ToInt16(lblCursorPos.Text));
            string sAft = Strings.Right(txtArg.Text, Strings.Len(txtArg.Text) - Convert.ToInt16(lblCursorPos.Text));
            txtArg.Text = sBef + sVar + sAft;
        }

        private void TimerDemo_Tick(System.Object sender, System.EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void lblBox_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (MouseIsDown == true)
            {
                Control sCtrl = (Control)sender;
                //' Move the control according to mouse movement
                if (sCtrl.Tag != "Selected")
                {
                    sCtrl.Left = (sCtrl.Left + e.X) - _myX;
                    sCtrl.Top = (sCtrl.Top + e.Y) - _myY;
                }
                //' Ensure moved control stays on top of anything it is dragged on to
                //'ctrl.BringToFront()

                foreach (Control ctrl in PanelNet.Controls)
                {
                    if (ctrl.Tag != null && ctrl.Tag.ToString() == "Selected")
                    {
                        ctrl.Left = (ctrl.Left + e.X) - _myX;
                        ctrl.Top = (ctrl.Top + e.Y) - _myY;
                    }
                }
            }
        }

        private void btnLoadNet_Click(System.Object sender, System.EventArgs e)
        {
            openfileNet.ShowDialog();
        }
        /// <summary>
        /// Fires after choosing file using OpenFileDialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openfileNet_FileOk(System.Object sender, System.ComponentModel.CancelEventArgs e)
        {
            openfileNet.Dispose();
            //clear all box
            //_myNet_No.Clear()
            _myNet_Name.Clear();
            _myNet_IP.Clear();
            _myNet_Status.Clear();
            int iT = PanelNet.Controls.Count - 1;
            int i;
            for (i = 1; i <= iT; i++)
            {
                PanelNet.Controls.RemoveAt(PanelNet.Controls.Count - 1);
            }

            //read file .txt
            int fNum = FileSystem.FreeFile();
            string fName = openfileNet.FileName;
            try
            {
                FileSystem.FileOpen(fNum, fName, OpenMode.Input, OpenAccess.Read, OpenShare.Shared);
                while (!(FileSystem.EOF(fNum)))
                {
                    string sLine = "";
                    sLine = Strings.Trim(FileSystem.LineInput(fNum));
                    //not a header
                    if (sLine != "[No],[Name],[IP],")
                    {
                        if (Strings.Mid(sLine, 1, 8) == "WINSIZE=")
                        {
                            string[] aLine = Strings.Split(Strings.Mid(sLine, 9, Strings.Len(sLine) - 8), ",");
                            if (aLine.Length > 0)
                            {
                                this.Width = Convert.ToInt16(aLine[0]);
                                this.Height = Convert.ToInt16(aLine[1]);
                            }
                        }
                        else
                        {
                            string[] aLine = Strings.Split(sLine, ",");
                            if (aLine.Length > 0)
                            {
                                //_myNet_No.Add(aLine(0))
                                _myNet_Name.Add(aLine[1]);
                                _myNet_IP.Add(aLine[2]);
                                _myNet_Status.Add("");
                                AddNewBox(aLine[1], Convert.ToInt16(aLine[3]), Convert.ToInt16(aLine[4]));
                            }
                        }
                    }
                }
                FileSystem.FileClose(fNum);

                //save to netlist.txt
                btnSaveNet_Click(null, null);

            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void savefileNet_FileOk(System.Object sender, System.ComponentModel.CancelEventArgs e)
        {
            //write file .txt
            SaveFileAs();
        }

        private void SaveFileAs()
        {
            try
            {
                int fNum = FileSystem.FreeFile();
                string fName = savefileNet.FileName;
                FileSystem.FileOpen(fNum, fName, OpenMode.Output, OpenAccess.Write, OpenShare.Shared);
                string sPrint = null;
                sPrint = "WINSIZE=" + this.Width + "," + this.Height + Constants.vbNewLine;
                sPrint = sPrint + "[No],[Name],[IP]," + Constants.vbNewLine;
                int i;
                for (i = 0; i <= _myNet_Name.Count - 1; i++)
                {
                    sPrint += (i + 1) + "," + _myNet_Name[i] + "," + _myNet_IP[i] + "," + PanelNet.Controls[i + 1].Left + "," + PanelNet.Controls[i + 1].Top + "," + Constants.vbNewLine;
                }
                FileSystem.Print(fNum, sPrint);
                FileSystem.FileClose(fNum);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void btnSaveNetAs_Click(System.Object sender, System.EventArgs e)
        {
            savefileNet.ShowDialog();
        }

        /// <summary>
        /// Updates net IPs list with DNS-resolved name results.
        /// </summary>
        public void GetIPs()
        {
            Parallel.ForEach(_myNet_Name, (item, dummy, il) =>
            {
                int i = (int)il;
                try
                {
                    _myNet_IP[i] = Convert.ToString(System.Net.Dns.GetHostEntry(item).AddressList[0]);
                }
                catch (Exception)
                {
                    try
                    {
                        _myNet_IP[i] = "";
                        _myNet_Status[i] = "DNS lookup fail";
                    }
                    catch (Exception)
                    { }
                }
            });
            //int i;
            //for (i = 0; i <= _myNet_Name.Count - 1; i++)
            //{
            //    try
            //    {
            //        _myNet_IP[i] = Convert.ToString(System.Net.Dns.GetHostEntry(_myNet_Name[i]).AddressList[0]);
            //    }
            //    catch (Exception ex)
            //    {
            //        try
            //        {
            //            _myNet_IP[i] = "";
            //            _myNet_Status[i] = "DNS lookup fail";
            //        }
            //        catch (Exception)
            //        { }
            //    }
            //}
        }
        /// <summary>
        /// Gets IP address using hostname
        /// </summary>
        /// <param name="strHostName">The host name to get IP address for.</param>
        /// <returns></returns>
        private string GetIPAddress(string strHostName)
        {
            string strIPAddress = "";
            try
            {
                this.Cursor = Cursors.WaitCursor;
                strIPAddress = Convert.ToString(System.Net.Dns.GetHostEntry(strHostName).AddressList[0]);
            }
            catch (Exception ex)
            {
                //
            }
            this.Cursor = Cursors.Default;
            return strIPAddress;
        }

        private void btnGetIP_Click(System.Object sender, System.EventArgs e)
        {
            txtIPaddress.Text = GetIPAddress(txtHostname.Text);
        }

        private void openfileBoxlist_FileOk(System.Object sender, System.ComponentModel.CancelEventArgs e)
        {
            openfileBoxlist.Dispose();
            try
            {
                //read file .txt
                int fNum = FileSystem.FreeFile();
                string fName = openfileBoxlist.FileName;
                FileSystem.FileOpen(fNum, fName, OpenMode.Input, OpenAccess.Read, OpenShare.Shared);
                int i = 0;
                int _X = 10;
                int _Y = 10;
                while (!(FileSystem.EOF(fNum)))
                {
                    string sLine = "";
                    sLine = FileSystem.LineInput(fNum);
                    string sBox = Strings.Trim(sLine);
                    int iName = _myNet_Name.IndexOf(sBox);
                    if (iName < 0)
                    {
                        //_myNet_No.Add(i)
                        _myNet_Name.Add(sBox);
                        _myNet_IP.Add("");
                        //_myNet_IP.Add(GetIPAddress(sBox));
                        _myNet_Status.Add("");
                        _X = (i * 90) + ((i + 1) * 10);
                        if (_X + 90 > PanelNet.Width)
                        {
                            _X = 10;
                            _Y = (_Y + 60);
                            i = 0;
                        }
                        AddNewBox(sBox, _X, _Y);
                        i += 1;
                    }
                }
                FileSystem.FileClose(fNum);
            }
            catch (Exception ex)
            {
                //
            }
        }

        private void btnAddBoxList_Click(System.Object sender, System.EventArgs e)
        {
            openfileBoxlist.ShowDialog();
        }
        /// <summary>
        /// Arranges boxes in hosts panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArrange_Click(System.Object sender, System.EventArgs e)
        {
            int iG = Convert.ToInt16(txtGridSize.Text);
            int _X = iG;
            int _Y = iG;
            int i = 0;
            int j;
            for (j = 1; j <= PanelNet.Controls.Count - 1; j++)
            {
                _X = (i * 90) + ((i + 1) * iG);
                if (_X + 90 > PanelNet.Width)
                {
                    _X = iG;
                    _Y = (_Y + 50 + iG);
                    i = 0;
                }
                if (chkSnapToGrid.Checked == true)
                {
                    _X = (_X / iG) * iG;
                    _Y = (_Y / iG) * iG;
                }
                PanelNet.Controls[j].Left = _X;
                PanelNet.Controls[j].Top = _Y;
                i += 1;
            }
        }
        /// <summary>
        /// Shows selected box in grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelNet_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int i;
            for (i = 1; i <= PanelNet.Controls.Count - 1; i++)
            {
                Control _with1 = PanelNet.Controls[i];
                if (_with1.Tag != null && _with1.Tag.ToString() == "Selected")
                {
                    if (_with1.BackColor == Color.DarkGreen)
                    {
                        _with1.BackColor = Color.LightGreen;
                    }
                    else if (_with1.BackColor == Color.DarkRed)
                    {
                        _with1.BackColor = Color.Red;
                    }
                    else if (_with1.BackColor == Color.DarkGray)
                    {
                        _with1.BackColor = Color.Gray;
                    }
                    _with1.Tag = "";
                }
            }
        }

        private void PanelNet_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            NetMouseDown = true;
            mRect = new Rectangle(e.X, e.Y, 0, 0);
            pt_start = e.Location;
            PanelNet.Invalidate();
        }

        private void PanelNet_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //If e.Button = Windows.Forms.MouseButtons.Left Then
            //    mRect = New Rectangle(mRect.Left, mRect.Top, e.X - mRect.Left, e.Y - mRect.Top)
            //    PanelNet.Invalidate()
            //End If

            if (NetMouseDown)
            {
                Point minPoint = new Point(Math.Min(e.Location.X, pt_start.X), Math.Min(e.Location.Y, pt_start.Y));
                Point maxPoint = new Point(Math.Max(e.Location.X, pt_start.X), Math.Max(e.Location.Y, pt_start.Y));
                mRect = new Rectangle(minPoint, new Size(maxPoint.X - minPoint.X, maxPoint.Y - minPoint.Y));
                PanelNet.Invalidate();
            }
        }

        private void PanelNet_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (NetMouseDown == true)
            {
                int _x1 = mRect.Left;
                int _x2 = mRect.Left + mRect.Width;
                int _y1 = mRect.Top;
                int _y2 = mRect.Top + mRect.Height;
                int i;
                for (i = 1; i <= PanelNet.Controls.Count - 1; i++)
                {
                    Control _with2 = PanelNet.Controls[i];
                    if (_with2.Left >= _x1 & (_with2.Left + _with2.Width) <= _x2 & _with2.Top >= _y1 & (_with2.Top + _with2.Height) <= _y2)
                    {
                        if (_with2.Tag != "Selected")
                        {
                            if (_with2.BackColor == Color.LightGreen)
                            {
                                _with2.BackColor = Color.DarkGreen;
                            }
                            else if (_with2.BackColor == Color.Red)
                            {
                                _with2.BackColor = Color.DarkRed;
                            }
                            else
                            {
                                _with2.BackColor = Color.DarkGray;
                            }
                            _with2.Tag = "Selected";
                        }
                    }
                }
            }
            else
            {
                //
            }
            NetMouseDown = false;
            mRect = new Rectangle(e.X, e.Y, 0, 0);
            PanelNet.Invalidate();
        }
        /// <summary>
        /// Paint event hanbdler for main panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelNet_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Yellow, 2))
            {
                e.Graphics.DrawRectangle(pen, mRect);
            }
        }


        private void btnDelSel_Click(System.Object sender, System.EventArgs e)
        {
            DeleteBoxes();
        }
        /// <summary>
        /// Confirms deleting boxes, and if OK, deletes them.
        /// </summary>
        private void DeleteBoxes()
        {
            bool bDel = false;
            if (Interaction.MsgBox("Are you sure want to Delete All Selected Boxes ?" + Constants.vbNewLine, Constants.vbYesNo) == Constants.vbYes)
            {
                bDel = true;
            }
            if (bDel == true)
            {
                try
                {
                    List<string> delBoxes = new List<string>();
                    foreach (Control ctrl in PanelNet.Controls)
                    {
                        if (ctrl.Tag != null && ctrl.Tag.ToString() == "Selected")
                        {
                            delBoxes.Add(ctrl.Text);
                        }
                    }
                    int i;
                    for (i = 0; i <= delBoxes.Count - 1; i++)
                    {
                        DeleteBox(delBoxes[i]);
                    }
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox(ex.Message);
                }
            }
        }

        private void cmdExitApp_Click(System.Object sender, System.EventArgs e)
        {
            if (chkAutoSaveNet.Checked)
            {
                btnSaveNet_Click(null, null);
            }

            SaveConfig();

            System.Environment.Exit(0);
        }

        private void SaveConfig()
        {
            try
            {
                int fNum = FileSystem.FreeFile();
                string fName = configPath;// Application.StartupPath + "\\config.txt";
                FileSystem.FileOpen(fNum, fName, OpenMode.Output, OpenAccess.Write, OpenShare.Shared);
                string sPrint = null;
                sPrint = "snaptogrid=" + Math.Abs(Conversion.Val(chkSnapToGrid.Checked)) + "," + txtGridSize.Text + Constants.vbNewLine;
                sPrint = sPrint + "autosavenet=" + Math.Abs(Conversion.Val(chkAutoSaveNet.Checked)) + Constants.vbNewLine;
                FileSystem.Print(fNum, sPrint);
                FileSystem.FileClose(fNum);
            }
            catch (Exception)
            { }
        }

        private void cmnBox_Opening(object sender, CancelEventArgs e)
        {

        }

        private void TimerStart_Tick(System.Object sender, System.EventArgs e)
        {
            TimerStart.Stop();

            this.Width = _myWidth;
            this.Height = _myHeight;

            TimerPing.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            cmdExitApp_Click(null, null);
        }


    }
}
