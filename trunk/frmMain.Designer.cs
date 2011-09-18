namespace Drakenbot
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uxMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuMinimize = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuTray = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.uxMenuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.uxMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuClient = new System.Windows.Forms.ToolStripMenuItem();
            this.uxCustomTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMapView = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSkin = new System.Windows.Forms.ToolStripMenuItem();
            this.uxHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.uxAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.uxBasicFunctions = new System.Windows.Forms.Button();
            this.uxTrainer = new System.Windows.Forms.Button();
            this.uxAutomatics = new System.Windows.Forms.Button();
            this.uxAlerts = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxMainMenu,
            this.uxMenuClient,
            this.uxSkin,
            this.uxHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(410, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uxMainMenu
            // 
            this.uxMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxMenuMinimize,
            this.uxMenuTray,
            this.toolStripSeparator2,
            this.uxMenuLoad,
            this.uxMenuSave,
            this.toolStripSeparator1,
            this.uxMenuExit});
            this.uxMainMenu.Name = "uxMainMenu";
            this.uxMainMenu.Size = new System.Drawing.Size(45, 20);
            this.uxMainMenu.Text = "Main";
            // 
            // uxMenuMinimize
            // 
            this.uxMenuMinimize.Name = "uxMenuMinimize";
            this.uxMenuMinimize.Size = new System.Drawing.Size(127, 22);
            this.uxMenuMinimize.Text = "Minimize";
            // 
            // uxMenuTray
            // 
            this.uxMenuTray.Name = "uxMenuTray";
            this.uxMenuTray.Size = new System.Drawing.Size(127, 22);
            this.uxMenuTray.Text = "Tray";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(124, 6);
            // 
            // uxMenuLoad
            // 
            this.uxMenuLoad.Name = "uxMenuLoad";
            this.uxMenuLoad.Size = new System.Drawing.Size(127, 22);
            this.uxMenuLoad.Text = "Load";
            // 
            // uxMenuSave
            // 
            this.uxMenuSave.Name = "uxMenuSave";
            this.uxMenuSave.Size = new System.Drawing.Size(127, 22);
            this.uxMenuSave.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // uxMenuExit
            // 
            this.uxMenuExit.Name = "uxMenuExit";
            this.uxMenuExit.Size = new System.Drawing.Size(127, 22);
            this.uxMenuExit.Text = "Exit";
            // 
            // uxMenuClient
            // 
            this.uxMenuClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxCustomTitle,
            this.uxMapView});
            this.uxMenuClient.Name = "uxMenuClient";
            this.uxMenuClient.Size = new System.Drawing.Size(49, 20);
            this.uxMenuClient.Text = "Client";
            // 
            // uxCustomTitle
            // 
            this.uxCustomTitle.CheckOnClick = true;
            this.uxCustomTitle.Name = "uxCustomTitle";
            this.uxCustomTitle.Size = new System.Drawing.Size(152, 22);
            this.uxCustomTitle.Text = "Custom Title";
            this.uxCustomTitle.Click += new System.EventHandler(this.uxCustomTitle_Click);
            // 
            // uxMapView
            // 
            this.uxMapView.Name = "uxMapView";
            this.uxMapView.Size = new System.Drawing.Size(152, 22);
            this.uxMapView.Text = "Map View";
            this.uxMapView.Click += new System.EventHandler(this.uxMapView_Click);
            // 
            // uxSkin
            // 
            this.uxSkin.Name = "uxSkin";
            this.uxSkin.Size = new System.Drawing.Size(41, 20);
            this.uxSkin.Text = "Skin";
            // 
            // uxHelp
            // 
            this.uxHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxAbout});
            this.uxHelp.Name = "uxHelp";
            this.uxHelp.Size = new System.Drawing.Size(43, 20);
            this.uxHelp.Text = "Help";
            // 
            // uxAbout
            // 
            this.uxAbout.Name = "uxAbout";
            this.uxAbout.Size = new System.Drawing.Size(113, 22);
            this.uxAbout.Text = "About";
            // 
            // uxBasicFunctions
            // 
            this.uxBasicFunctions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uxBasicFunctions.Location = new System.Drawing.Point(2, 27);
            this.uxBasicFunctions.Name = "uxBasicFunctions";
            this.uxBasicFunctions.Size = new System.Drawing.Size(100, 20);
            this.uxBasicFunctions.TabIndex = 1;
            this.uxBasicFunctions.Text = "Basic Functions";
            this.uxBasicFunctions.UseVisualStyleBackColor = true;
            // 
            // uxTrainer
            // 
            this.uxTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uxTrainer.Location = new System.Drawing.Point(104, 27);
            this.uxTrainer.Name = "uxTrainer";
            this.uxTrainer.Size = new System.Drawing.Size(100, 20);
            this.uxTrainer.TabIndex = 2;
            this.uxTrainer.Text = "Trainer";
            this.uxTrainer.UseVisualStyleBackColor = true;
            // 
            // uxAutomatics
            // 
            this.uxAutomatics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uxAutomatics.Location = new System.Drawing.Point(206, 27);
            this.uxAutomatics.Name = "uxAutomatics";
            this.uxAutomatics.Size = new System.Drawing.Size(100, 20);
            this.uxAutomatics.TabIndex = 3;
            this.uxAutomatics.Text = "Automatics";
            this.uxAutomatics.UseVisualStyleBackColor = true;
            // 
            // uxAlerts
            // 
            this.uxAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uxAlerts.Location = new System.Drawing.Point(308, 27);
            this.uxAlerts.Name = "uxAlerts";
            this.uxAlerts.Size = new System.Drawing.Size(100, 20);
            this.uxAlerts.TabIndex = 4;
            this.uxAlerts.Text = "Alerts";
            this.uxAlerts.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 50);
            this.Controls.Add(this.uxAlerts);
            this.Controls.Add(this.uxAutomatics);
            this.Controls.Add(this.uxTrainer);
            this.Controls.Add(this.uxBasicFunctions);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draken Bot";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uxMainMenu;
        private System.Windows.Forms.ToolStripMenuItem uxSkin;
        private System.Windows.Forms.ToolStripMenuItem uxHelp;
        private System.Windows.Forms.ToolStripMenuItem uxAbout;
        private System.Windows.Forms.ToolStripMenuItem uxMenuMinimize;
        private System.Windows.Forms.ToolStripMenuItem uxMenuTray;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem uxMenuLoad;
        private System.Windows.Forms.ToolStripMenuItem uxMenuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem uxMenuExit;
        private System.Windows.Forms.ToolStripMenuItem uxMenuClient;
        private System.Windows.Forms.ToolStripMenuItem uxCustomTitle;
        private System.Windows.Forms.Button uxBasicFunctions;
        private System.Windows.Forms.Button uxTrainer;
        private System.Windows.Forms.Button uxAutomatics;
        private System.Windows.Forms.Button uxAlerts;
        private System.Windows.Forms.ToolStripMenuItem uxMapView;
    }
}

