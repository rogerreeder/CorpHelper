namespace CorpHelper
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.chkbxSleepPrevention = new System.Windows.Forms.CheckBox();
            this.notifyIconController = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuitemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemToggleSleep = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrPreventSleep = new System.Windows.Forms.Timer(this.components);
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.cbSleepPreventionInterval = new System.Windows.Forms.ComboBox();
            this.chRunOnStartup = new System.Windows.Forms.CheckBox();
            this.cmMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkbxSleepPrevention
            // 
            this.chkbxSleepPrevention.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkbxSleepPrevention.AutoSize = true;
            this.chkbxSleepPrevention.Location = new System.Drawing.Point(12, 35);
            this.chkbxSleepPrevention.Name = "chkbxSleepPrevention";
            this.chkbxSleepPrevention.Size = new System.Drawing.Size(134, 23);
            this.chkbxSleepPrevention.TabIndex = 1;
            this.chkbxSleepPrevention.Text = "Enable Sleep Prevention";
            this.chkbxSleepPrevention.UseVisualStyleBackColor = true;
            this.chkbxSleepPrevention.CheckedChanged += new System.EventHandler(this.chkbxSleepPrevention_CheckedChanged);
            // 
            // notifyIconController
            // 
            this.notifyIconController.BalloonTipText = "Info on Settings";
            this.notifyIconController.BalloonTipTitle = "Corporate Helper";
            this.notifyIconController.ContextMenuStrip = this.cmMain;
            this.notifyIconController.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconController.Icon")));
            this.notifyIconController.Text = "Corporate Helper";
            this.notifyIconController.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconController_MouseClick);
            this.notifyIconController.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconController_MouseDoubleClick);
            // 
            // cmMain
            // 
            this.cmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemOpen,
            this.toolStripSeparator2,
            this.menuItemToggleSleep,
            this.toolStripSeparator1,
            this.menuItemExit});
            this.cmMain.Name = "cmMain";
            this.cmMain.Size = new System.Drawing.Size(195, 82);
            this.cmMain.Text = "Corporate Helper Menu";
            this.cmMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmMain_ItemClicked);
            // 
            // menuitemOpen
            // 
            this.menuitemOpen.Name = "menuitemOpen";
            this.menuitemOpen.Size = new System.Drawing.Size(194, 22);
            this.menuitemOpen.Text = "Open";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // menuItemToggleSleep
            // 
            this.menuItemToggleSleep.Name = "menuItemToggleSleep";
            this.menuItemToggleSleep.Size = new System.Drawing.Size(194, 22);
            this.menuItemToggleSleep.Text = "Toggle Sleep Preventer";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(194, 22);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.ToolTipText = "Exit Application";
            // 
            // tmrPreventSleep
            // 
            this.tmrPreventSleep.Interval = 30000;
            this.tmrPreventSleep.Tick += new System.EventHandler(this.tmrPreventSleep_Tick);
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(12, 120);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatus.Size = new System.Drawing.Size(527, 139);
            this.txtStatus.TabIndex = 1;
            // 
            // cbSleepPreventionInterval
            // 
            this.cbSleepPreventionInterval.DisplayMember = "Key";
            this.cbSleepPreventionInterval.FormattingEnabled = true;
            this.cbSleepPreventionInterval.Location = new System.Drawing.Point(152, 37);
            this.cbSleepPreventionInterval.Name = "cbSleepPreventionInterval";
            this.cbSleepPreventionInterval.Size = new System.Drawing.Size(115, 21);
            this.cbSleepPreventionInterval.TabIndex = 2;
            this.cbSleepPreventionInterval.ValueMember = "Value";
            this.cbSleepPreventionInterval.SelectedIndexChanged += new System.EventHandler(this.cbSleepPreventionInterval_SelectedIndexChanged);
            // 
            // chRunOnStartup
            // 
            this.chRunOnStartup.Appearance = System.Windows.Forms.Appearance.Button;
            this.chRunOnStartup.AutoSize = true;
            this.chRunOnStartup.Location = new System.Drawing.Point(12, 12);
            this.chRunOnStartup.Name = "chRunOnStartup";
            this.chRunOnStartup.Size = new System.Drawing.Size(77, 23);
            this.chRunOnStartup.TabIndex = 0;
            this.chRunOnStartup.Text = "Run on login";
            this.chRunOnStartup.UseVisualStyleBackColor = true;
            this.chRunOnStartup.CheckedChanged += new System.EventHandler(this.chRunOnStartup_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 271);
            this.Controls.Add(this.chRunOnStartup);
            this.Controls.Add(this.cbSleepPreventionInterval);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.chkbxSleepPrevention);
            this.MinimumSize = new System.Drawing.Size(500, 310);
            this.Name = "frmMain";
            this.Text = "Corporate Helper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.cmMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbxSleepPrevention;
        private System.Windows.Forms.NotifyIcon notifyIconController;
        private System.Windows.Forms.ContextMenuStrip cmMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.Timer tmrPreventSleep;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ToolStripMenuItem menuItemToggleSleep;
        private System.Windows.Forms.ComboBox cbSleepPreventionInterval;
        private System.Windows.Forms.ToolStripMenuItem menuitemOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox chRunOnStartup;
    }
}

