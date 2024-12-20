﻿namespace DofusFlashGenerator.Forms
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
            AxShockwaveFlash = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ControlPanel = new Panel();
            CrackedPictureBox = new PictureBox();
            InformationLabel = new Label();
            MediaButtonsControl = new Components.MediaButtonsControl();
            ToolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)AxShockwaveFlash).BeginInit();
            ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CrackedPictureBox).BeginInit();
            SuspendLayout();
            // 
            // AxShockwaveFlash
            // 
            AxShockwaveFlash.Enabled = true;
            AxShockwaveFlash.Location = new Point(0, 0);
            AxShockwaveFlash.Margin = new Padding(0);
            AxShockwaveFlash.Name = "AxShockwaveFlash";
            AxShockwaveFlash.OcxState = (AxHost.State)resources.GetObject("AxShockwaveFlash.OcxState");
            AxShockwaveFlash.Size = new Size(1236, 720);
            AxShockwaveFlash.TabIndex = 0;
            // 
            // ControlPanel
            // 
            ControlPanel.BackColor = Color.Black;
            ControlPanel.Controls.Add(CrackedPictureBox);
            ControlPanel.Controls.Add(InformationLabel);
            ControlPanel.Controls.Add(MediaButtonsControl);
            ControlPanel.Location = new Point(0, 720);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(1236, 40);
            ControlPanel.TabIndex = 0;
            // 
            // CrackedPictureBox
            // 
            CrackedPictureBox.BackColor = Color.Black;
            CrackedPictureBox.Image = Properties.Resources.cracked;
            CrackedPictureBox.Location = new Point(12, 5);
            CrackedPictureBox.Name = "CrackedPictureBox";
            CrackedPictureBox.Size = new Size(23, 30);
            CrackedPictureBox.TabIndex = 0;
            CrackedPictureBox.TabStop = false;
            ToolTip.SetToolTip(CrackedPictureBox, "Cracked map");
            CrackedPictureBox.Visible = false;
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
            // MediaButtonsControl
            // 
            MediaButtonsControl.BackColor = Color.Transparent;
            MediaButtonsControl.Location = new Point(983, 5);
            MediaButtonsControl.Name = "MediaButtonsControl";
            MediaButtonsControl.Size = new Size(246, 30);
            MediaButtonsControl.TabIndex = 1;
            // 
            // MapFlashForm
            // 
            BackColor = Color.Black;
            ClientSize = new Size(1236, 760);
            Controls.Add(AxShockwaveFlash);
            Controls.Add(ControlPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MapFlashForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Map";
            FormClosed += MapFlashForm_FormClosed;
            Load += MapFlashForm_Load;
            ((System.ComponentModel.ISupportInitialize)AxShockwaveFlash).EndInit();
            ControlPanel.ResumeLayout(false);
            ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CrackedPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash AxShockwaveFlash;
        private Panel ControlPanel;
        private Label InformationLabel;
        private PictureBox CrackedPictureBox;
        private Components.MediaButtonsControl MediaButtonsControl;
        private ToolTip ToolTip;
    }
}

