namespace Drakenbot.Forms
{
    partial class frmMapView
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
            this.uxZoomOut = new System.Windows.Forms.Button();
            this.uxZoomIn = new System.Windows.Forms.Button();
            this.uxEnableMapView = new System.Windows.Forms.CheckBox();
            this.t_map_view = new System.Windows.Forms.Timer(this.components);
            this.uxMapView = new Tibia.Util.MapViewer();
            this.SuspendLayout();
            // 
            // uxZoomOut
            // 
            this.uxZoomOut.Location = new System.Drawing.Point(80, 219);
            this.uxZoomOut.Name = "uxZoomOut";
            this.uxZoomOut.Size = new System.Drawing.Size(62, 20);
            this.uxZoomOut.TabIndex = 15;
            this.uxZoomOut.Text = "Zoom Out";
            this.uxZoomOut.UseVisualStyleBackColor = true;
            this.uxZoomOut.Click += new System.EventHandler(this.uxZoomOut_Click);
            // 
            // uxZoomIn
            // 
            this.uxZoomIn.Location = new System.Drawing.Point(12, 219);
            this.uxZoomIn.Name = "uxZoomIn";
            this.uxZoomIn.Size = new System.Drawing.Size(62, 20);
            this.uxZoomIn.TabIndex = 14;
            this.uxZoomIn.Text = "Zoom In";
            this.uxZoomIn.UseVisualStyleBackColor = true;
            this.uxZoomIn.Click += new System.EventHandler(this.uxZoomIn_Click);
            // 
            // uxEnableMapView
            // 
            this.uxEnableMapView.AutoSize = true;
            this.uxEnableMapView.Location = new System.Drawing.Point(215, 221);
            this.uxEnableMapView.Name = "uxEnableMapView";
            this.uxEnableMapView.Size = new System.Drawing.Size(65, 17);
            this.uxEnableMapView.TabIndex = 17;
            this.uxEnableMapView.Text = "Enabled";
            this.uxEnableMapView.UseVisualStyleBackColor = true;
            this.uxEnableMapView.CheckedChanged += new System.EventHandler(this.uxEnableMapView_CheckedChanged);
            // 
            // t_map_view
            // 
            this.t_map_view.Tick += new System.EventHandler(this.t_map_view_Tick);
            // 
            // uxMapView
            // 
            this.uxMapView.Directory = "C:\\Documents and Settings\\Usuario\\Dados de aplicativos\\Tibia\\Automap\\";
            this.uxMapView.DrawCoors = true;
            this.uxMapView.DrawCrosshair = true;
            this.uxMapView.Location = new System.Drawing.Point(12, 12);
            this.uxMapView.Name = "uxMapView";
            this.uxMapView.OpenTibiaMaps = false;
            this.uxMapView.Size = new System.Drawing.Size(268, 201);
            this.uxMapView.TabIndex = 0;
            // 
            // frmMapView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 249);
            this.Controls.Add(this.uxEnableMapView);
            this.Controls.Add(this.uxZoomOut);
            this.Controls.Add(this.uxZoomIn);
            this.Controls.Add(this.uxMapView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMapView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map View";
            this.Load += new System.EventHandler(this.frmMapView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tibia.Util.MapViewer uxMapView;
        private System.Windows.Forms.Button uxZoomOut;
        private System.Windows.Forms.Button uxZoomIn;
        private System.Windows.Forms.CheckBox uxEnableMapView;
        private System.Windows.Forms.Timer t_map_view;
    }
}