namespace DofusFlashGenerator.Forms
{
    partial class MapFlashForm
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MapFlashForm));
            InformationLabel = new Label();
            ControlPanel = new Panel();
            CrackedPictureBox = new PictureBox();
            ToolTip = new ToolTip(components);
            MediaButtonsControl = new Components.MediaButtonsControl();
            ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CrackedPictureBox).BeginInit();
            SuspendLayout();
            // 
            // InformationLabel
            // 
            InformationLabel.AutoSize = true;
            InformationLabel.Font = new Font("Verdana", 14.25F);
            InformationLabel.ForeColor = Color.White;
            InformationLabel.Location = new Point(10, 8);
            InformationLabel.Name = "InformationLabel";
            InformationLabel.Size = new Size(0, 23);
            InformationLabel.TabIndex = 0;
            // 
            // ControlPanel
            // 
            ControlPanel.BackColor = Color.Black;
            ControlPanel.Controls.Add(MediaButtonsControl);
            ControlPanel.Controls.Add(CrackedPictureBox);
            ControlPanel.Controls.Add(InformationLabel);
            ControlPanel.Location = new Point(0, 720);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(1236, 40);
            ControlPanel.TabIndex = 1;
            // 
            // CrackedPictureBox
            // 
            CrackedPictureBox.BackColor = Color.Black;
            CrackedPictureBox.Image = Properties.Resources.cracked;
            CrackedPictureBox.Location = new Point(12, 5);
            CrackedPictureBox.Name = "CrackedPictureBox";
            CrackedPictureBox.Size = new Size(23, 30);
            CrackedPictureBox.TabIndex = 8;
            CrackedPictureBox.TabStop = false;
            ToolTip.SetToolTip(CrackedPictureBox, "Cracked map");
            CrackedPictureBox.Visible = false;
            // 
            // MediaButtonsControl
            // 
            MediaButtonsControl.BackColor = Color.Transparent;
            MediaButtonsControl.Location = new Point(983, 5);
            MediaButtonsControl.Name = "MediaButtonsControl";
            MediaButtonsControl.Size = new Size(246, 30);
            MediaButtonsControl.TabIndex = 9;
            // 
            // MapFlashForm
            // 
            BackColor = Color.Black;
            ClientSize = new Size(1236, 760);
            Controls.Add(ControlPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MapFlashForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Map";
            FormClosed += FlashForm_FormClosed;
            Load += MainForm_Load;
            ControlPanel.ResumeLayout(false);
            ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CrackedPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private void InitializeFlashComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapFlashForm));
            this.AxShockwaveFlash = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.SuspendLayout();
            //
            // axShockwaveFlash
            //
            this.AxShockwaveFlash.Location = new System.Drawing.Point(0, 0);
            this.AxShockwaveFlash.Margin = new System.Windows.Forms.Padding(0);
            this.AxShockwaveFlash.Name = "axShockwaveFlash";
            this.AxShockwaveFlash.OcxState = (System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash.OcxState"));
            this.AxShockwaveFlash.Size = new System.Drawing.Size(1236, 720);
            this.Controls.Add(AxShockwaveFlash);
            this.ResumeLayout(false);
        }

        private AxShockwaveFlashObjects.AxShockwaveFlash AxShockwaveFlash;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Panel ControlPanel;
        private PictureBox CrackedPictureBox;
        private ToolTip ToolTip;
        private Components.MediaButtonsControl MediaButtonsControl;
    }
}

