﻿namespace DofusFlashGenerator.Forms
{
    sealed partial class MainForm
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            OpenClientFolderButton = new Button();
            HelpClientLabel = new Label();
            MapApiUrlTextbox = new TextBox();
            DownloadMapKeysButton = new Button();
            ChangeMapApiUrlButton = new Button();
            LaunchMapButton = new Button();
            MapsLabel = new Label();
            MapKeysLabel = new Label();
            SeparatorPanel = new Panel();
            LaunchSpellsButton = new Button();
            SpellsLabel = new Label();
            SpellBacksLabel = new Label();
            SpellUpsLabel = new Label();
            InformationLabel = new Label();
            OpenOutputFolderButton = new Button();
            ToolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // OpenClientFolderButton
            // 
            OpenClientFolderButton.Location = new Point(116, 10);
            OpenClientFolderButton.Name = "OpenClientFolderButton";
            OpenClientFolderButton.Size = new Size(150, 23);
            OpenClientFolderButton.TabIndex = 1;
            OpenClientFolderButton.Text = "Open client";
            OpenClientFolderButton.UseVisualStyleBackColor = true;
            OpenClientFolderButton.Click += OpenClientFolderButton_Click;
            // 
            // HelpClientLabel
            // 
            HelpClientLabel.AutoSize = true;
            HelpClientLabel.Location = new Point(267, 14);
            HelpClientLabel.Name = "HelpClientLabel";
            HelpClientLabel.Size = new Size(12, 15);
            HelpClientLabel.TabIndex = 0;
            HelpClientLabel.Text = "?";
            ToolTip.SetToolTip(HelpClientLabel, "Add this files from the official client :\r\n    - clips/spells/icons/*\r\n    - clips/gfx/*.swf\r\n    - clips/cells.swf\r\n    - clips/ground.swf\r\n    - clips/objects.swf\r\n    - data/maps/*.swf");
            // 
            // MapApiUrlTextbox
            // 
            MapApiUrlTextbox.Location = new Point(12, 39);
            MapApiUrlTextbox.Name = "MapApiUrlTextbox";
            MapApiUrlTextbox.Size = new Size(120, 23);
            MapApiUrlTextbox.TabIndex = 3;
            MapApiUrlTextbox.Visible = false;
            MapApiUrlTextbox.KeyPress += MapApiUrlTextbox_KeyPress;
            // 
            // DownloadMapKeysButton
            // 
            DownloadMapKeysButton.Location = new Point(12, 39);
            DownloadMapKeysButton.Name = "DownloadMapKeysButton";
            DownloadMapKeysButton.Size = new Size(120, 23);
            DownloadMapKeysButton.TabIndex = 2;
            DownloadMapKeysButton.Text = "Update map keys";
            DownloadMapKeysButton.UseVisualStyleBackColor = true;
            DownloadMapKeysButton.Click += DownloadMapKeysButton_Click;
            // 
            // ChangeMapApiUrlButton
            // 
            ChangeMapApiUrlButton.Location = new Point(132, 39);
            ChangeMapApiUrlButton.Name = "ChangeMapApiUrlButton";
            ChangeMapApiUrlButton.Size = new Size(30, 23);
            ChangeMapApiUrlButton.TabIndex = 3;
            ChangeMapApiUrlButton.Text = "✏️";
            ToolTip.SetToolTip(ChangeMapApiUrlButton, "Change the map API URL where the keys are retrieved");
            ChangeMapApiUrlButton.UseVisualStyleBackColor = true;
            ChangeMapApiUrlButton.Click += ChangeMapApiUrlButton_Click;
            // 
            // LaunchMapButton
            // 
            LaunchMapButton.Location = new Point(12, 63);
            LaunchMapButton.Name = "LaunchMapButton";
            LaunchMapButton.Size = new Size(150, 23);
            LaunchMapButton.TabIndex = 4;
            LaunchMapButton.Text = "Launch maps";
            LaunchMapButton.UseVisualStyleBackColor = true;
            LaunchMapButton.Click += LaunchMapsButton_Click;
            // 
            // MapsLabel
            // 
            MapsLabel.AutoSize = true;
            MapsLabel.Font = new Font("Segoe UI", 11.25F);
            MapsLabel.Location = new Point(12, 89);
            MapsLabel.Name = "MapsLabel";
            MapsLabel.Size = new Size(64, 20);
            MapsLabel.TabIndex = 0;
            MapsLabel.Text = "Maps : 0";
            // 
            // MapKeysLabel
            // 
            MapKeysLabel.AutoSize = true;
            MapKeysLabel.Font = new Font("Segoe UI", 11.25F);
            MapKeysLabel.Location = new Point(12, 109);
            MapKeysLabel.Name = "MapKeysLabel";
            MapKeysLabel.Size = new Size(58, 20);
            MapKeysLabel.TabIndex = 0;
            MapKeysLabel.Text = "Keys : 0";
            // 
            // SeparatorPanel
            // 
            SeparatorPanel.BackColor = SystemColors.ControlDark;
            SeparatorPanel.Location = new Point(191, 39);
            SeparatorPanel.Name = "SeparatorPanel";
            SeparatorPanel.Size = new Size(2, 110);
            SeparatorPanel.TabIndex = 0;
            // 
            // LaunchSpellsButton
            // 
            LaunchSpellsButton.Location = new Point(222, 63);
            LaunchSpellsButton.Name = "LaunchSpellsButton";
            LaunchSpellsButton.Size = new Size(150, 23);
            LaunchSpellsButton.TabIndex = 5;
            LaunchSpellsButton.Text = "Launch spells";
            LaunchSpellsButton.UseVisualStyleBackColor = true;
            LaunchSpellsButton.Click += LaunchSpellsButton_Click;
            // 
            // SpellsLabel
            // 
            SpellsLabel.AutoSize = true;
            SpellsLabel.Font = new Font("Segoe UI", 11.25F);
            SpellsLabel.Location = new Point(222, 89);
            SpellsLabel.Name = "SpellsLabel";
            SpellsLabel.Size = new Size(67, 20);
            SpellsLabel.TabIndex = 0;
            SpellsLabel.Text = "Spells : 0";
            // 
            // SpellBacksLabel
            // 
            SpellBacksLabel.AutoSize = true;
            SpellBacksLabel.Font = new Font("Segoe UI", 11.25F);
            SpellBacksLabel.Location = new Point(222, 109);
            SpellBacksLabel.Name = "SpellBacksLabel";
            SpellBacksLabel.Size = new Size(65, 20);
            SpellBacksLabel.TabIndex = 0;
            SpellBacksLabel.Text = "Backs : 0";
            // 
            // SpellUpsLabel
            // 
            SpellUpsLabel.AutoSize = true;
            SpellUpsLabel.Font = new Font("Segoe UI", 11.25F);
            SpellUpsLabel.Location = new Point(222, 129);
            SpellUpsLabel.Name = "SpellUpsLabel";
            SpellUpsLabel.Size = new Size(53, 20);
            SpellUpsLabel.TabIndex = 0;
            SpellUpsLabel.Text = "Ups : 0";
            // 
            // InformationLabel
            // 
            InformationLabel.BackColor = SystemColors.ControlLightLight;
            InformationLabel.Location = new Point(20, 164);
            InformationLabel.Name = "InformationLabel";
            InformationLabel.Size = new Size(344, 61);
            InformationLabel.TabIndex = 0;
            InformationLabel.TextAlign = ContentAlignment.MiddleCenter;
            InformationLabel.TextChanged += InformationLabel_TextChanged;
            // 
            // OpenOutputFolderButton
            // 
            OpenOutputFolderButton.Font = new Font("Segoe UI", 8.25F);
            OpenOutputFolderButton.Location = new Point(295, 233);
            OpenOutputFolderButton.Name = "OpenOutputFolderButton";
            OpenOutputFolderButton.Size = new Size(85, 23);
            OpenOutputFolderButton.TabIndex = 6;
            OpenOutputFolderButton.Text = "Open output";
            OpenOutputFolderButton.UseVisualStyleBackColor = true;
            OpenOutputFolderButton.Click += OpenOutputFolderButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(OpenClientFolderButton);
            Controls.Add(HelpClientLabel);
            Controls.Add(MapApiUrlTextbox);
            Controls.Add(DownloadMapKeysButton);
            Controls.Add(ChangeMapApiUrlButton);
            Controls.Add(LaunchMapButton);
            Controls.Add(MapsLabel);
            Controls.Add(MapKeysLabel);
            Controls.Add(SeparatorPanel);
            Controls.Add(LaunchSpellsButton);
            Controls.Add(SpellsLabel);
            Controls.Add(SpellBacksLabel);
            Controls.Add(SpellUpsLabel);
            Controls.Add(InformationLabel);
            Controls.Add(OpenOutputFolderButton);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "DofusFlashGenerator";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenClientFolderButton;
        private Label HelpClientLabel;
        private TextBox MapApiUrlTextbox;
        private Button DownloadMapKeysButton;
        private Button ChangeMapApiUrlButton;
        private Button LaunchMapButton;
        private Label MapsLabel;
        private Label MapKeysLabel;
        private Panel SeparatorPanel;
        private Button LaunchSpellsButton;
        private Label SpellsLabel;
        private Label SpellBacksLabel;
        private Label SpellUpsLabel;
        private Label InformationLabel;
        private Button OpenOutputFolderButton;
        private ToolTip ToolTip;
    }
}
