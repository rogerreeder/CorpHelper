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
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrPreventSleep = new System.Windows.Forms.Timer(this.components);
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.menuItemToggleSleep = new System.Windows.Forms.ToolStripMenuItem();
            this.cmMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkbxSleepPrevention
            // 
            this.chkbxSleepPrevention.AutoSize = true;
            this.chkbxSleepPrevention.Location = new System.Drawing.Point(12, 12);
            this.chkbxSleepPrevention.Name = "chkbxSleepPrevention";
            this.chkbxSleepPrevention.Size = new System.Drawing.Size(143, 17);
            this.chkbxSleepPrevention.TabIndex = 0;
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
            this.menuItemExit,
            this.menuItemToggleSleep});
            this.cmMain.Name = "cmMain";
            this.cmMain.Size = new System.Drawing.Size(195, 48);
            this.cmMain.Text = "Corporate Helper Menu";
            this.cmMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmMain_ItemClicked);
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
            // menuItemToggleSleep
            // 
            this.menuItemToggleSleep.Name = "menuItemToggleSleep";
            this.menuItemToggleSleep.Size = new System.Drawing.Size(194, 22);
            this.menuItemToggleSleep.Text = "Toggle Sleep Preventer";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 271);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.chkbxSleepPrevention);
            this.MinimumSize = new System.Drawing.Size(500, 310);
            this.Name = "frmMain";
            this.Text = "Corporate Helper";
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
    }
}

