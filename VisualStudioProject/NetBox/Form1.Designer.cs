namespace NetBox
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.PanelNet = new System.Windows.Forms.Panel();
            this.lblBox = new System.Windows.Forms.Label();
            this.cmnBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.btnGetIP = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelSel = new System.Windows.Forms.Button();
            this.btnDeleteBox = new System.Windows.Forms.Button();
            this.btnEditbox = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtIPaddress = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.lblHostname = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnLoadNet = new System.Windows.Forms.Button();
            this.btnSaveNetAs = new System.Windows.Forms.Button();
            this.btnSaveNet = new System.Windows.Forms.Button();
            this.btnAddBoxList = new System.Windows.Forms.Button();
            this.cmdExitApp = new System.Windows.Forms.Button();
            this.btnArrange = new System.Windows.Forms.Button();
            this.btnAddBox = new System.Windows.Forms.Button();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteMenu = new System.Windows.Forms.Button();
            this.btnSaveCmd = new System.Windows.Forms.Button();
            this.btnCancelEditMenu = new System.Windows.Forms.Button();
            this.btnEditMenu = new System.Windows.Forms.Button();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.btnOkEditMenu = new System.Windows.Forms.Button();
            this.lblEditMode = new System.Windows.Forms.Label();
            this.lblMnuId = new System.Windows.Forms.Label();
            this.lblCursorPos = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.cboMnuText = new System.Windows.Forms.ComboBox();
            this.cboVarBox2 = new System.Windows.Forms.ComboBox();
            this.cboVarBox = new System.Windows.Forms.ComboBox();
            this.btnInserVar2 = new System.Windows.Forms.Button();
            this.btnInsertVar = new System.Windows.Forms.Button();
            this.txtArg = new System.Windows.Forms.TextBox();
            this.txtCustCmd = new System.Windows.Forms.TextBox();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtGridSize = new System.Windows.Forms.TextBox();
            this.chkAutoSaveNet = new System.Windows.Forms.CheckBox();
            this.chkSnapToGrid = new System.Windows.Forms.CheckBox();
            this.openfileNet = new System.Windows.Forms.OpenFileDialog();
            this.savefileNet = new System.Windows.Forms.SaveFileDialog();
            this.openfileBoxlist = new System.Windows.Forms.OpenFileDialog();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TimerDemo = new System.Windows.Forms.Timer(this.components);
            this.TimerGetCursorPos2 = new System.Windows.Forms.Timer(this.components);
            this.TimerPing = new System.Windows.Forms.Timer(this.components);
            this.TimerGetCursorPos = new System.Windows.Forms.Timer(this.components);
            this.TimerStart = new System.Windows.Forms.Timer(this.components);
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.PanelNet.SuspendLayout();
            this.cmnBox.SuspendLayout();
            this.PanelInfo.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(631, 474);
            this.TabControl1.TabIndex = 4;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.PanelNet);
            this.TabPage1.Controls.Add(this.PanelInfo);
            this.TabPage1.Controls.Add(this.Panel1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(623, 448);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Network";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // PanelNet
            // 
            this.PanelNet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PanelNet.Controls.Add(this.lblBox);
            this.PanelNet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelNet.Location = new System.Drawing.Point(3, 54);
            this.PanelNet.Name = "PanelNet";
            this.PanelNet.Size = new System.Drawing.Size(617, 286);
            this.PanelNet.TabIndex = 6;
            this.PanelNet.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelNet_Paint);
            this.PanelNet.DoubleClick += new System.EventHandler(this.PanelNet_DoubleClick);
            this.PanelNet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelNet_MouseClick);
            this.PanelNet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelNet_MouseDown);
            this.PanelNet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelNet_MouseMove);
            this.PanelNet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelNet_MouseUp);
            // 
            // lblBox
            // 
            this.lblBox.BackColor = System.Drawing.Color.LightYellow;
            this.lblBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBox.ContextMenuStrip = this.cmnBox;
            this.lblBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBox.Location = new System.Drawing.Point(5, 3);
            this.lblBox.Name = "lblBox";
            this.lblBox.Size = new System.Drawing.Size(90, 50);
            this.lblBox.TabIndex = 0;
            this.lblBox.Text = "PC0";
            this.lblBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBox.Visible = false;
            this.lblBox.DoubleClick += new System.EventHandler(this.lblBox_DoubleClick);
            this.lblBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblBox_MouseDown);
            this.lblBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblBox_MouseMove);
            this.lblBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblBox_MouseUp);
            // 
            // cmnBox
            // 
            this.cmnBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.ToolStripMenuItem1});
            this.cmnBox.Name = "cmnBox";
            this.cmnBox.Size = new System.Drawing.Size(108, 54);
            this.cmnBox.Opening += new System.ComponentModel.CancelEventHandler(this.cmnBox_Opening);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.EditToolStripMenuItem.Text = "Edit";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(104, 6);
            // 
            // PanelInfo
            // 
            this.PanelInfo.Controls.Add(this.btnGetIP);
            this.PanelInfo.Controls.Add(this.btnCancel);
            this.PanelInfo.Controls.Add(this.btnDelSel);
            this.PanelInfo.Controls.Add(this.btnDeleteBox);
            this.PanelInfo.Controls.Add(this.btnEditbox);
            this.PanelInfo.Controls.Add(this.btnSave);
            this.PanelInfo.Controls.Add(this.txtIPaddress);
            this.PanelInfo.Controls.Add(this.Label2);
            this.PanelInfo.Controls.Add(this.txtHostname);
            this.PanelInfo.Controls.Add(this.lblHostname);
            this.PanelInfo.Controls.Add(this.Label1);
            this.PanelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInfo.Location = new System.Drawing.Point(3, 340);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(617, 105);
            this.PanelInfo.TabIndex = 4;
            this.PanelInfo.Visible = false;
            // 
            // btnGetIP
            // 
            this.btnGetIP.Location = new System.Drawing.Point(271, 62);
            this.btnGetIP.Name = "btnGetIP";
            this.btnGetIP.Size = new System.Drawing.Size(49, 23);
            this.btnGetIP.TabIndex = 4;
            this.btnGetIP.Text = "Get IP";
            this.btnGetIP.UseVisualStyleBackColor = true;
            this.btnGetIP.Click += new System.EventHandler(this.btnGetIP_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(437, 58);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 31);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelSel
            // 
            this.btnDelSel.Location = new System.Drawing.Point(480, 13);
            this.btnDelSel.Name = "btnDelSel";
            this.btnDelSel.Size = new System.Drawing.Size(119, 31);
            this.btnDelSel.TabIndex = 5;
            this.btnDelSel.Text = "Delete Selected";
            this.btnDelSel.UseVisualStyleBackColor = true;
            this.btnDelSel.Click += new System.EventHandler(this.btnDelSel_Click);
            // 
            // btnDeleteBox
            // 
            this.btnDeleteBox.Enabled = false;
            this.btnDeleteBox.Location = new System.Drawing.Point(406, 13);
            this.btnDeleteBox.Name = "btnDeleteBox";
            this.btnDeleteBox.Size = new System.Drawing.Size(68, 31);
            this.btnDeleteBox.TabIndex = 5;
            this.btnDeleteBox.Text = "Delete";
            this.btnDeleteBox.UseVisualStyleBackColor = true;
            this.btnDeleteBox.Click += new System.EventHandler(this.btnDeleteBox_Click);
            // 
            // btnEditbox
            // 
            this.btnEditbox.Enabled = false;
            this.btnEditbox.Location = new System.Drawing.Point(332, 13);
            this.btnEditbox.Name = "btnEditbox";
            this.btnEditbox.Size = new System.Drawing.Size(68, 31);
            this.btnEditbox.TabIndex = 4;
            this.btnEditbox.Text = "Edit";
            this.btnEditbox.UseVisualStyleBackColor = true;
            this.btnEditbox.Click += new System.EventHandler(this.btnEditbox_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(363, 58);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 31);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Ok";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtIPaddress
            // 
            this.txtIPaddress.Enabled = false;
            this.txtIPaddress.Location = new System.Drawing.Point(87, 69);
            this.txtIPaddress.Name = "txtIPaddress";
            this.txtIPaddress.Size = new System.Drawing.Size(178, 20);
            this.txtIPaddress.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(16, 72);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 13);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "IP Address";
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(87, 44);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(178, 20);
            this.txtHostname.TabIndex = 2;
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostname.Location = new System.Drawing.Point(84, 13);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(70, 16);
            this.lblHostname.TabIndex = 0;
            this.lblHostname.Text = "Hostname";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(16, 47);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(55, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Hostname";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.btnLoadNet);
            this.Panel1.Controls.Add(this.btnSaveNetAs);
            this.Panel1.Controls.Add(this.btnSaveNet);
            this.Panel1.Controls.Add(this.btnAddBoxList);
            this.Panel1.Controls.Add(this.cmdExitApp);
            this.Panel1.Controls.Add(this.btnArrange);
            this.Panel1.Controls.Add(this.btnAddBox);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(3, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(617, 51);
            this.Panel1.TabIndex = 3;
            // 
            // btnLoadNet
            // 
            this.btnLoadNet.Location = new System.Drawing.Point(284, 12);
            this.btnLoadNet.Name = "btnLoadNet";
            this.btnLoadNet.Size = new System.Drawing.Size(68, 23);
            this.btnLoadNet.TabIndex = 9;
            this.btnLoadNet.Text = "Load Net";
            this.btnLoadNet.UseVisualStyleBackColor = true;
            this.btnLoadNet.Click += new System.EventHandler(this.btnLoadNet_Click);
            // 
            // btnSaveNetAs
            // 
            this.btnSaveNetAs.Location = new System.Drawing.Point(432, 12);
            this.btnSaveNetAs.Name = "btnSaveNetAs";
            this.btnSaveNetAs.Size = new System.Drawing.Size(78, 23);
            this.btnSaveNetAs.TabIndex = 9;
            this.btnSaveNetAs.Text = "Save Net As";
            this.btnSaveNetAs.UseVisualStyleBackColor = true;
            this.btnSaveNetAs.Click += new System.EventHandler(this.btnSaveNetAs_Click);
            // 
            // btnSaveNet
            // 
            this.btnSaveNet.Location = new System.Drawing.Point(358, 12);
            this.btnSaveNet.Name = "btnSaveNet";
            this.btnSaveNet.Size = new System.Drawing.Size(68, 23);
            this.btnSaveNet.TabIndex = 9;
            this.btnSaveNet.Text = "Save Net";
            this.btnSaveNet.UseVisualStyleBackColor = true;
            this.btnSaveNet.Visible = false;
            this.btnSaveNet.Click += new System.EventHandler(this.btnSaveNet_Click);
            // 
            // btnAddBoxList
            // 
            this.btnAddBoxList.Location = new System.Drawing.Point(84, 12);
            this.btnAddBoxList.Name = "btnAddBoxList";
            this.btnAddBoxList.Size = new System.Drawing.Size(113, 23);
            this.btnAddBoxList.TabIndex = 8;
            this.btnAddBoxList.Text = "Add Boxes from List";
            this.btnAddBoxList.UseVisualStyleBackColor = true;
            this.btnAddBoxList.Click += new System.EventHandler(this.btnAddBoxList_Click);
            // 
            // cmdExitApp
            // 
            this.cmdExitApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdExitApp.Location = new System.Drawing.Point(550, 0);
            this.cmdExitApp.Name = "cmdExitApp";
            this.cmdExitApp.Size = new System.Drawing.Size(67, 51);
            this.cmdExitApp.TabIndex = 8;
            this.cmdExitApp.Text = "Exit";
            this.cmdExitApp.UseVisualStyleBackColor = true;
            this.cmdExitApp.Click += new System.EventHandler(this.cmdExitApp_Click);
            // 
            // btnArrange
            // 
            this.btnArrange.Location = new System.Drawing.Point(203, 12);
            this.btnArrange.Name = "btnArrange";
            this.btnArrange.Size = new System.Drawing.Size(75, 23);
            this.btnArrange.TabIndex = 8;
            this.btnArrange.Text = "Arrange";
            this.btnArrange.UseVisualStyleBackColor = true;
            this.btnArrange.Click += new System.EventHandler(this.btnArrange_Click);
            // 
            // btnAddBox
            // 
            this.btnAddBox.Location = new System.Drawing.Point(3, 12);
            this.btnAddBox.Name = "btnAddBox";
            this.btnAddBox.Size = new System.Drawing.Size(75, 23);
            this.btnAddBox.TabIndex = 8;
            this.btnAddBox.Text = "Add Box";
            this.btnAddBox.UseVisualStyleBackColor = true;
            this.btnAddBox.Click += new System.EventHandler(this.btnAddBox_Click);
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.GroupBox1);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(623, 448);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Advanced";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnDeleteMenu);
            this.GroupBox1.Controls.Add(this.btnSaveCmd);
            this.GroupBox1.Controls.Add(this.btnCancelEditMenu);
            this.GroupBox1.Controls.Add(this.btnEditMenu);
            this.GroupBox1.Controls.Add(this.btnAddMenu);
            this.GroupBox1.Controls.Add(this.btnOkEditMenu);
            this.GroupBox1.Controls.Add(this.lblEditMode);
            this.GroupBox1.Controls.Add(this.lblMnuId);
            this.GroupBox1.Controls.Add(this.lblCursorPos);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.cboMnuText);
            this.GroupBox1.Controls.Add(this.cboVarBox2);
            this.GroupBox1.Controls.Add(this.cboVarBox);
            this.GroupBox1.Controls.Add(this.btnInserVar2);
            this.GroupBox1.Controls.Add(this.btnInsertVar);
            this.GroupBox1.Controls.Add(this.txtArg);
            this.GroupBox1.Controls.Add(this.txtCustCmd);
            this.GroupBox1.Controls.Add(this.RadioButton1);
            this.GroupBox1.Location = new System.Drawing.Point(8, 23);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(487, 417);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Custom Command";
            // 
            // btnDeleteMenu
            // 
            this.btnDeleteMenu.Enabled = false;
            this.btnDeleteMenu.Location = new System.Drawing.Point(184, 295);
            this.btnDeleteMenu.Name = "btnDeleteMenu";
            this.btnDeleteMenu.Size = new System.Drawing.Size(76, 36);
            this.btnDeleteMenu.TabIndex = 10;
            this.btnDeleteMenu.Text = "Delete";
            this.btnDeleteMenu.UseVisualStyleBackColor = true;
            this.btnDeleteMenu.Click += new System.EventHandler(this.btnDeleteMenu_Click);
            // 
            // btnSaveCmd
            // 
            this.btnSaveCmd.Location = new System.Drawing.Point(343, 295);
            this.btnSaveCmd.Name = "btnSaveCmd";
            this.btnSaveCmd.Size = new System.Drawing.Size(122, 36);
            this.btnSaveCmd.TabIndex = 13;
            this.btnSaveCmd.Text = "Save to File";
            this.btnSaveCmd.UseVisualStyleBackColor = true;
            this.btnSaveCmd.Click += new System.EventHandler(this.btnSaveCmd_Click);
            // 
            // btnCancelEditMenu
            // 
            this.btnCancelEditMenu.Location = new System.Drawing.Point(135, 337);
            this.btnCancelEditMenu.Name = "btnCancelEditMenu";
            this.btnCancelEditMenu.Size = new System.Drawing.Size(65, 36);
            this.btnCancelEditMenu.TabIndex = 12;
            this.btnCancelEditMenu.Text = "Cancel";
            this.btnCancelEditMenu.UseVisualStyleBackColor = true;
            this.btnCancelEditMenu.Visible = false;
            this.btnCancelEditMenu.Click += new System.EventHandler(this.btnCancelEditMenu_Click);
            // 
            // btnEditMenu
            // 
            this.btnEditMenu.Enabled = false;
            this.btnEditMenu.Location = new System.Drawing.Point(101, 295);
            this.btnEditMenu.Name = "btnEditMenu";
            this.btnEditMenu.Size = new System.Drawing.Size(77, 36);
            this.btnEditMenu.TabIndex = 9;
            this.btnEditMenu.Text = "Edit";
            this.btnEditMenu.UseVisualStyleBackColor = true;
            this.btnEditMenu.Click += new System.EventHandler(this.btnEditMenu_Click);
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Location = new System.Drawing.Point(18, 295);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(77, 36);
            this.btnAddMenu.TabIndex = 8;
            this.btnAddMenu.Text = "Add";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMnu_Click);
            // 
            // btnOkEditMenu
            // 
            this.btnOkEditMenu.Location = new System.Drawing.Point(64, 337);
            this.btnOkEditMenu.Name = "btnOkEditMenu";
            this.btnOkEditMenu.Size = new System.Drawing.Size(65, 36);
            this.btnOkEditMenu.TabIndex = 11;
            this.btnOkEditMenu.Text = "Ok";
            this.btnOkEditMenu.UseVisualStyleBackColor = true;
            this.btnOkEditMenu.Visible = false;
            this.btnOkEditMenu.Click += new System.EventHandler(this.btnOkEditMenu_Click);
            // 
            // lblEditMode
            // 
            this.lblEditMode.AutoSize = true;
            this.lblEditMode.Location = new System.Drawing.Point(68, 376);
            this.lblEditMode.Name = "lblEditMode";
            this.lblEditMode.Size = new System.Drawing.Size(10, 13);
            this.lblEditMode.TabIndex = 5;
            this.lblEditMode.Text = "-";
            // 
            // lblMnuId
            // 
            this.lblMnuId.AutoSize = true;
            this.lblMnuId.Location = new System.Drawing.Point(21, 270);
            this.lblMnuId.Name = "lblMnuId";
            this.lblMnuId.Size = new System.Drawing.Size(16, 13);
            this.lblMnuId.TabIndex = 5;
            this.lblMnuId.Text = "-1";
            this.lblMnuId.Visible = false;
            // 
            // lblCursorPos
            // 
            this.lblCursorPos.AutoSize = true;
            this.lblCursorPos.Location = new System.Drawing.Point(362, 71);
            this.lblCursorPos.Name = "lblCursorPos";
            this.lblCursorPos.Size = new System.Drawing.Size(13, 13);
            this.lblCursorPos.TabIndex = 5;
            this.lblCursorPos.Text = "0";
            this.lblCursorPos.Visible = false;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(21, 29);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(28, 13);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Text";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(21, 122);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(45, 13);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "Variable";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(21, 225);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(45, 13);
            this.Label6.TabIndex = 5;
            this.Label6.Text = "Variable";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(21, 172);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(58, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Argument :";
            // 
            // cboMnuText
            // 
            this.cboMnuText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMnuText.FormattingEnabled = true;
            this.cboMnuText.Location = new System.Drawing.Point(82, 26);
            this.cboMnuText.Name = "cboMnuText";
            this.cboMnuText.Size = new System.Drawing.Size(383, 26);
            this.cboMnuText.TabIndex = 1;
            this.cboMnuText.SelectedIndexChanged += new System.EventHandler(this.cboMnuText_SelectedIndexChanged);
            // 
            // cboVarBox2
            // 
            this.cboVarBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVarBox2.FormattingEnabled = true;
            this.cboVarBox2.Items.AddRange(new object[] {
            "net.Name",
            "net.IP"});
            this.cboVarBox2.Location = new System.Drawing.Point(82, 222);
            this.cboVarBox2.Name = "cboVarBox2";
            this.cboVarBox2.Size = new System.Drawing.Size(122, 26);
            this.cboVarBox2.TabIndex = 6;
            this.cboVarBox2.Text = "net.IP";
            // 
            // cboVarBox
            // 
            this.cboVarBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVarBox.FormattingEnabled = true;
            this.cboVarBox.Items.AddRange(new object[] {
            "net.Name",
            "net.IP"});
            this.cboVarBox.Location = new System.Drawing.Point(82, 119);
            this.cboVarBox.Name = "cboVarBox";
            this.cboVarBox.Size = new System.Drawing.Size(122, 26);
            this.cboVarBox.TabIndex = 3;
            this.cboVarBox.Text = "net.IP";
            // 
            // btnInserVar2
            // 
            this.btnInserVar2.Enabled = false;
            this.btnInserVar2.Location = new System.Drawing.Point(210, 220);
            this.btnInserVar2.Name = "btnInserVar2";
            this.btnInserVar2.Size = new System.Drawing.Size(75, 28);
            this.btnInserVar2.TabIndex = 7;
            this.btnInserVar2.Text = "Insert";
            this.btnInserVar2.UseVisualStyleBackColor = true;
            this.btnInserVar2.Click += new System.EventHandler(this.btnInserVar2_Click);
            // 
            // btnInsertVar
            // 
            this.btnInsertVar.Enabled = false;
            this.btnInsertVar.Location = new System.Drawing.Point(210, 117);
            this.btnInsertVar.Name = "btnInsertVar";
            this.btnInsertVar.Size = new System.Drawing.Size(75, 28);
            this.btnInsertVar.TabIndex = 4;
            this.btnInsertVar.Text = "Insert";
            this.btnInsertVar.UseVisualStyleBackColor = true;
            this.btnInsertVar.Click += new System.EventHandler(this.btnInsertVar_Click);
            // 
            // txtArg
            // 
            this.txtArg.Enabled = false;
            this.txtArg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArg.Location = new System.Drawing.Point(18, 190);
            this.txtArg.Name = "txtArg";
            this.txtArg.Size = new System.Drawing.Size(447, 24);
            this.txtArg.TabIndex = 5;
            this.txtArg.Click += new System.EventHandler(this.txtArg_Click);
            this.txtArg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArg_KeyDown);
            // 
            // txtCustCmd
            // 
            this.txtCustCmd.Enabled = false;
            this.txtCustCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustCmd.Location = new System.Drawing.Point(19, 87);
            this.txtCustCmd.Name = "txtCustCmd";
            this.txtCustCmd.Size = new System.Drawing.Size(446, 24);
            this.txtCustCmd.TabIndex = 2;
            this.txtCustCmd.Click += new System.EventHandler(this.txtCustCmd_Click);
            this.txtCustCmd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustCmd_KeyDown);
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Checked = true;
            this.RadioButton1.Location = new System.Drawing.Point(19, 64);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(88, 17);
            this.RadioButton1.TabIndex = 1;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Process.Start";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.GroupBox2);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(623, 448);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Preferences";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.txtGridSize);
            this.GroupBox2.Controls.Add(this.chkAutoSaveNet);
            this.GroupBox2.Controls.Add(this.chkSnapToGrid);
            this.GroupBox2.Location = new System.Drawing.Point(8, 16);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(483, 115);
            this.GroupBox2.TabIndex = 2;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Config";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(190, 27);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(49, 13);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Grid Size";
            // 
            // txtGridSize
            // 
            this.txtGridSize.Location = new System.Drawing.Point(245, 24);
            this.txtGridSize.Name = "txtGridSize";
            this.txtGridSize.Size = new System.Drawing.Size(61, 20);
            this.txtGridSize.TabIndex = 6;
            this.txtGridSize.Text = "10";
            // 
            // chkAutoSaveNet
            // 
            this.chkAutoSaveNet.AutoSize = true;
            this.chkAutoSaveNet.Location = new System.Drawing.Point(60, 68);
            this.chkAutoSaveNet.Name = "chkAutoSaveNet";
            this.chkAutoSaveNet.Size = new System.Drawing.Size(140, 17);
            this.chkAutoSaveNet.TabIndex = 5;
            this.chkAutoSaveNet.Text = "Auto-Save Net on Close";
            this.chkAutoSaveNet.UseVisualStyleBackColor = true;
            // 
            // chkSnapToGrid
            // 
            this.chkSnapToGrid.AutoSize = true;
            this.chkSnapToGrid.Location = new System.Drawing.Point(60, 26);
            this.chkSnapToGrid.Name = "chkSnapToGrid";
            this.chkSnapToGrid.Size = new System.Drawing.Size(85, 17);
            this.chkSnapToGrid.TabIndex = 4;
            this.chkSnapToGrid.Text = "Snap to Grid";
            this.chkSnapToGrid.UseVisualStyleBackColor = true;
            // 
            // openfileNet
            // 
            this.openfileNet.Filter = "Text file|*.txt";
            this.openfileNet.FileOk += new System.ComponentModel.CancelEventHandler(this.openfileNet_FileOk);
            // 
            // savefileNet
            // 
            this.savefileNet.Filter = "Text file|*.txt";
            this.savefileNet.FileOk += new System.ComponentModel.CancelEventHandler(this.savefileNet_FileOk);
            // 
            // openfileBoxlist
            // 
            this.openfileBoxlist.Filter = "Text file|*.txt";
            this.openfileBoxlist.FileOk += new System.ComponentModel.CancelEventHandler(this.openfileBoxlist_FileOk);
            // 
            // TimerDemo
            // 
            this.TimerDemo.Interval = 600000;
            // 
            // TimerGetCursorPos2
            // 
            this.TimerGetCursorPos2.Tick += new System.EventHandler(this.TimerGetCursorPos2_Tick);
            // 
            // TimerPing
            // 
            this.TimerPing.Interval = 5000;
            this.TimerPing.Tick += new System.EventHandler(this.TimerPing_Tick);
            // 
            // TimerGetCursorPos
            // 
            this.TimerGetCursorPos.Tick += new System.EventHandler(this.TimerGetCursorPos_Tick);
            // 
            // TimerStart
            // 
            this.TimerStart.Tick += new System.EventHandler(this.TimerStart_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 474);
            this.Controls.Add(this.TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NetBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.PanelNet.ResumeLayout(false);
            this.cmnBox.ResumeLayout(false);
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Panel PanelNet;
        internal System.Windows.Forms.Label lblBox;
        internal System.Windows.Forms.ContextMenuStrip cmnBox;
        internal System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        internal System.Windows.Forms.Panel PanelInfo;
        internal System.Windows.Forms.Button btnGetIP;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnDelSel;
        internal System.Windows.Forms.Button btnDeleteBox;
        internal System.Windows.Forms.Button btnEditbox;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.TextBox txtIPaddress;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtHostname;
        internal System.Windows.Forms.Label lblHostname;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnLoadNet;
        internal System.Windows.Forms.Button btnSaveNetAs;
        internal System.Windows.Forms.Button btnSaveNet;
        internal System.Windows.Forms.Button btnAddBoxList;
        internal System.Windows.Forms.Button cmdExitApp;
        internal System.Windows.Forms.Button btnArrange;
        internal System.Windows.Forms.Button btnAddBox;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnDeleteMenu;
        internal System.Windows.Forms.Button btnSaveCmd;
        internal System.Windows.Forms.Button btnCancelEditMenu;
        internal System.Windows.Forms.Button btnEditMenu;
        internal System.Windows.Forms.Button btnAddMenu;
        internal System.Windows.Forms.Button btnOkEditMenu;
        internal System.Windows.Forms.Label lblEditMode;
        internal System.Windows.Forms.Label lblMnuId;
        internal System.Windows.Forms.Label lblCursorPos;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cboMnuText;
        internal System.Windows.Forms.ComboBox cboVarBox2;
        internal System.Windows.Forms.ComboBox cboVarBox;
        internal System.Windows.Forms.Button btnInserVar2;
        internal System.Windows.Forms.Button btnInsertVar;
        internal System.Windows.Forms.TextBox txtArg;
        internal System.Windows.Forms.TextBox txtCustCmd;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtGridSize;
        internal System.Windows.Forms.CheckBox chkAutoSaveNet;
        internal System.Windows.Forms.CheckBox chkSnapToGrid;
        internal System.Windows.Forms.OpenFileDialog openfileNet;
        internal System.Windows.Forms.SaveFileDialog savefileNet;
        internal System.Windows.Forms.OpenFileDialog openfileBoxlist;
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal System.Windows.Forms.Timer TimerDemo;
        internal System.Windows.Forms.Timer TimerGetCursorPos2;
        internal System.Windows.Forms.Timer TimerPing;
        internal System.Windows.Forms.Timer TimerGetCursorPos;
        internal System.Windows.Forms.Timer TimerStart;
    }
}

