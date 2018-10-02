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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "localhost",
            "Info",
            "02/10/18"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "MB670",
            "Error",
            "02/10/18 2:19AM"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmnBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.openfileNet = new System.Windows.Forms.OpenFileDialog();
            this.savefileNet = new System.Windows.Forms.SaveFileDialog();
            this.openfileBoxlist = new System.Windows.Forms.OpenFileDialog();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TimerDemo = new System.Windows.Forms.Timer(this.components);
            this.TimerGetCursorPos2 = new System.Windows.Forms.Timer(this.components);
            this.TimerPing = new System.Windows.Forms.Timer(this.components);
            this.TimerGetCursorPos = new System.Windows.Forms.Timer(this.components);
            this.TimerStart = new System.Windows.Forms.Timer(this.components);
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSnapToGrid = new System.Windows.Forms.CheckBox();
            this.chkAutoSaveNet = new System.Windows.Forms.CheckBox();
            this.txtGridSize = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.txtCustCmd = new System.Windows.Forms.TextBox();
            this.txtArg = new System.Windows.Forms.TextBox();
            this.btnInsertVar = new System.Windows.Forms.Button();
            this.btnInserVar2 = new System.Windows.Forms.Button();
            this.cboVarBox = new System.Windows.Forms.ComboBox();
            this.cboVarBox2 = new System.Windows.Forms.ComboBox();
            this.cboMnuText = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.lblCursorPos = new System.Windows.Forms.Label();
            this.lblMnuId = new System.Windows.Forms.Label();
            this.lblEditMode = new System.Windows.Forms.Label();
            this.btnOkEditMenu = new System.Windows.Forms.Button();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.btnEditMenu = new System.Windows.Forms.Button();
            this.btnCancelEditMenu = new System.Windows.Forms.Button();
            this.btnSaveCmd = new System.Windows.Forms.Button();
            this.btnDeleteMenu = new System.Windows.Forms.Button();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblHostname = new System.Windows.Forms.Label();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtIPaddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditbox = new System.Windows.Forms.Button();
            this.btnDeleteBox = new System.Windows.Forms.Button();
            this.btnDelSel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGetIP = new System.Windows.Forms.Button();
            this.PanelNet = new System.Windows.Forms.Panel();
            this.lblBox = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Hostname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.boxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxesFromListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmnBox.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.PanelInfo.SuspendLayout();
            this.PanelNet.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.GroupBox2);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(1011, 681);
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
            // txtGridSize
            // 
            this.txtGridSize.Location = new System.Drawing.Point(245, 24);
            this.txtGridSize.Name = "txtGridSize";
            this.txtGridSize.Size = new System.Drawing.Size(61, 20);
            this.txtGridSize.TabIndex = 6;
            this.txtGridSize.Text = "10";
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
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.groupBox3);
            this.TabPage2.Controls.Add(this.GroupBox1);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(803, 681);
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
            this.GroupBox1.Location = new System.Drawing.Point(168, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(487, 417);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Custom Command";
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
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(21, 172);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(58, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Argument :";
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
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(21, 122);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(45, 13);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "Variable";
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
            // lblEditMode
            // 
            this.lblEditMode.AutoSize = true;
            this.lblEditMode.Location = new System.Drawing.Point(68, 376);
            this.lblEditMode.Name = "lblEditMode";
            this.lblEditMode.Size = new System.Drawing.Size(10, 13);
            this.lblEditMode.TabIndex = 5;
            this.lblEditMode.Text = "-";
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
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.PanelNet);
            this.TabPage1.Controls.Add(this.PanelInfo);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(803, 681);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Network";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.TabPage1.Click += new System.EventHandler(this.TabPage1_Click);
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
            this.PanelInfo.Location = new System.Drawing.Point(3, 573);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(797, 105);
            this.PanelInfo.TabIndex = 4;
            this.PanelInfo.Visible = false;
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
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(87, 44);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(178, 20);
            this.txtHostname.TabIndex = 2;
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
            // txtIPaddress
            // 
            this.txtIPaddress.Enabled = false;
            this.txtIPaddress.Location = new System.Drawing.Point(87, 69);
            this.txtIPaddress.Name = "txtIPaddress";
            this.txtIPaddress.Size = new System.Drawing.Size(178, 20);
            this.txtIPaddress.TabIndex = 2;
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
            // PanelNet
            // 
            this.PanelNet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PanelNet.Controls.Add(this.toolStrip1);
            this.PanelNet.Controls.Add(this.lblBox);
            this.PanelNet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelNet.Location = new System.Drawing.Point(3, 3);
            this.PanelNet.Name = "PanelNet";
            this.PanelNet.Size = new System.Drawing.Size(797, 570);
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
            this.lblBox.Location = new System.Drawing.Point(19, 39);
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.toolStripButton4,
            this.toolStripLabel3,
            this.toolStripButton3,
            this.toolStripLabel4,
            this.toolStripButton1,
            this.toolStripLabel7,
            this.toolStripButton6,
            this.toolStripLabel1,
            this.toolStripDropDownButton1,
            this.toolStripLabel2,
            this.toolStripButton2,
            this.toolStripLabel6,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(797, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.btnArrange_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel1.Text = "Add";
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
            this.TabControl1.Size = new System.Drawing.Size(811, 707);
            this.TabControl1.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(1120, 707);
            this.splitContainer1.SplitterDistance = 811;
            this.splitContainer1.TabIndex = 5;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(305, 707);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(297, 681);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Summary";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.listView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(297, 681);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Log";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Hostname,
            this.Level,
            this.DateTime});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HoverSelection = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6});
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(291, 675);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Hostname
            // 
            this.Hostname.DisplayIndex = 1;
            this.Hostname.Text = "Hostname";
            this.Hostname.Width = 120;
            // 
            // Level
            // 
            this.Level.DisplayIndex = 0;
            this.Level.Text = "Level";
            this.Level.Width = 70;
            // 
            // DateTime
            // 
            this.DateTime.Text = "Date/Time";
            this.DateTime.Width = 90;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Load";
            this.toolStripButton3.Click += new System.EventHandler(this.btnLoadNet_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boxToolStripMenuItem,
            this.boxesFromListToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.btnAddBox_Click);
            // 
            // boxToolStripMenuItem
            // 
            this.boxToolStripMenuItem.Name = "boxToolStripMenuItem";
            this.boxToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.boxToolStripMenuItem.Text = "Box";
            this.boxToolStripMenuItem.Click += new System.EventHandler(this.btnAddBox_Click);
            // 
            // boxesFromListToolStripMenuItem
            // 
            this.boxesFromListToolStripMenuItem.Name = "boxesFromListToolStripMenuItem";
            this.boxesFromListToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.boxesFromListToolStripMenuItem.Text = "Boxes From List";
            this.boxesFromListToolStripMenuItem.Click += new System.EventHandler(this.btnAddBoxList_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel2.Text = "Arrange";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(33, 22);
            this.toolStripLabel3.Text = "Load";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.btnSaveNet_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel4.Text = "Save";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel5.Text = "New";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.cmdExitApp_Click);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(25, 22);
            this.toolStripLabel6.Text = "Exit";
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel7.Text = "Save As";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.Click += new System.EventHandler(this.btnSaveNetAs_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(153, 656);
            this.listBox1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 675);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Commands";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 707);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.Text = "NetBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmnBox.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabPage1.ResumeLayout(false);
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            this.PanelNet.ResumeLayout(false);
            this.PanelNet.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.ContextMenuStrip cmnBox;
        internal System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        internal System.Windows.Forms.OpenFileDialog openfileNet;
        internal System.Windows.Forms.SaveFileDialog savefileNet;
        internal System.Windows.Forms.OpenFileDialog openfileBoxlist;
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal System.Windows.Forms.Timer TimerDemo;
        internal System.Windows.Forms.Timer TimerGetCursorPos2;
        internal System.Windows.Forms.Timer TimerPing;
        internal System.Windows.Forms.Timer TimerGetCursorPos;
        internal System.Windows.Forms.Timer TimerStart;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtGridSize;
        internal System.Windows.Forms.CheckBox chkAutoSaveNet;
        internal System.Windows.Forms.CheckBox chkSnapToGrid;
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
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Panel PanelNet;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        internal System.Windows.Forms.Label lblBox;
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
        internal System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Hostname;
        private System.Windows.Forms.ColumnHeader Level;
        private System.Windows.Forms.ColumnHeader DateTime;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem boxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxesFromListToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

