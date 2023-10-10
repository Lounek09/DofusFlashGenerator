namespace DofusFlashGenerator.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            OpenClientFolderButton = new Button();
            UpdateMapKeysButton = new Button();
            LaunchMapButton = new Button();
            OpenOutputFolderButton = new Button();
            HelpClientLabel = new Label();
            ToolTip = new ToolTip(components);
            MapsLabel = new Label();
            MapKeysLabel = new Label();
            InformationLabel = new Label();
            LaunchSpellsButton = new Button();
            SpellUpsLabel = new Label();
            SpellBacksLabel = new Label();
            panel1 = new Panel();
            SpellsLabel = new Label();
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
            // UpdateMapKeysButton
            // 
            UpdateMapKeysButton.Location = new Point(12, 39);
            UpdateMapKeysButton.Name = "UpdateMapKeysButton";
            UpdateMapKeysButton.Size = new Size(150, 23);
            UpdateMapKeysButton.TabIndex = 2;
            UpdateMapKeysButton.Text = "Update map keys";
            UpdateMapKeysButton.UseVisualStyleBackColor = true;
            UpdateMapKeysButton.Click += UpdateMapKeysButton_Click;
            // 
            // LaunchMapButton
            // 
            LaunchMapButton.Location = new Point(12, 68);
            LaunchMapButton.Name = "LaunchMapButton";
            LaunchMapButton.Size = new Size(150, 23);
            LaunchMapButton.TabIndex = 3;
            LaunchMapButton.Text = "Launch maps";
            LaunchMapButton.UseVisualStyleBackColor = true;
            LaunchMapButton.Click += LaunchMapsButton_Click;
            // 
            // OpenOutputFolderButton
            // 
            OpenOutputFolderButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            OpenOutputFolderButton.Location = new Point(295, 228);
            OpenOutputFolderButton.Name = "OpenOutputFolderButton";
            OpenOutputFolderButton.Size = new Size(85, 23);
            OpenOutputFolderButton.TabIndex = 5;
            OpenOutputFolderButton.Text = "Open output";
            OpenOutputFolderButton.UseVisualStyleBackColor = true;
            OpenOutputFolderButton.Click += OpenOutputFolderButton_Click;
            // 
            // HelpClientLabel
            // 
            HelpClientLabel.AutoSize = true;
            HelpClientLabel.Location = new Point(267, 14);
            HelpClientLabel.Name = "HelpClientLabel";
            HelpClientLabel.Size = new Size(12, 15);
            HelpClientLabel.TabIndex = 0;
            HelpClientLabel.Text = "?";
            ToolTip.SetToolTip(HelpClientLabel, "Add this files from the official client :\r\n    - clips/spells/icons/*\r\n    - clips/gfx/*.swf\r\n    - clips/cells.swf\r\n    - clips/ground.swf\r\n    - objects.swf\r\n    - data/maps/*.swf");
            // 
            // MapsLabel
            // 
            MapsLabel.AutoSize = true;
            MapsLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            MapsLabel.Location = new Point(12, 94);
            MapsLabel.Name = "MapsLabel";
            MapsLabel.Size = new Size(56, 20);
            MapsLabel.TabIndex = 0;
            MapsLabel.Text = "Maps : ";
            // 
            // MapKeysLabel
            // 
            MapKeysLabel.AutoSize = true;
            MapKeysLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            MapKeysLabel.Location = new Point(12, 114);
            MapKeysLabel.Name = "MapKeysLabel";
            MapKeysLabel.Size = new Size(50, 20);
            MapKeysLabel.TabIndex = 0;
            MapKeysLabel.Text = "Keys : ";
            // 
            // InformationLabel
            // 
            InformationLabel.Location = new Point(20, 169);
            InformationLabel.Name = "InformationLabel";
            InformationLabel.Size = new Size(344, 46);
            InformationLabel.TabIndex = 0;
            InformationLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // LaunchSpellsButton
            // 
            LaunchSpellsButton.Location = new Point(222, 68);
            LaunchSpellsButton.Name = "LaunchSpellsButton";
            LaunchSpellsButton.Size = new Size(150, 23);
            LaunchSpellsButton.TabIndex = 4;
            LaunchSpellsButton.Text = "Launch spells";
            LaunchSpellsButton.UseVisualStyleBackColor = true;
            LaunchSpellsButton.Click += LaunchSpellsButton_Click;
            // 
            // SpellUpsLabel
            // 
            SpellUpsLabel.AutoSize = true;
            SpellUpsLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SpellUpsLabel.Location = new Point(222, 134);
            SpellUpsLabel.Name = "SpellUpsLabel";
            SpellUpsLabel.Size = new Size(45, 20);
            SpellUpsLabel.TabIndex = 0;
            SpellUpsLabel.Text = "Ups : ";
            // 
            // SpellBacksLabel
            // 
            SpellBacksLabel.AutoSize = true;
            SpellBacksLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SpellBacksLabel.Location = new Point(222, 114);
            SpellBacksLabel.Name = "SpellBacksLabel";
            SpellBacksLabel.Size = new Size(57, 20);
            SpellBacksLabel.TabIndex = 0;
            SpellBacksLabel.Text = "Backs : ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(191, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 115);
            panel1.TabIndex = 0;
            // 
            // SpellsLabel
            // 
            SpellsLabel.AutoSize = true;
            SpellsLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SpellsLabel.Location = new Point(222, 94);
            SpellsLabel.Name = "SpellsLabel";
            SpellsLabel.Size = new Size(59, 20);
            SpellsLabel.TabIndex = 0;
            SpellsLabel.Text = "Spells : ";
            // 
            // MainForm
            // 
            AcceptButton = LaunchMapButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 255);
            Controls.Add(SpellsLabel);
            Controls.Add(panel1);
            Controls.Add(SpellUpsLabel);
            Controls.Add(SpellBacksLabel);
            Controls.Add(LaunchSpellsButton);
            Controls.Add(InformationLabel);
            Controls.Add(MapKeysLabel);
            Controls.Add(MapsLabel);
            Controls.Add(HelpClientLabel);
            Controls.Add(OpenOutputFolderButton);
            Controls.Add(LaunchMapButton);
            Controls.Add(UpdateMapKeysButton);
            Controls.Add(OpenClientFolderButton);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
        private Button UpdateMapKeysButton;
        private Button LaunchMapButton;
        private Label InformationLabel;
        private Label MapsLabel;
        private Label MapKeysLabel;
        private Button OpenOutputFolderButton;
        private ToolTip ToolTip;
        private Button LaunchSpellsButton;
        private Label SpellUpsLabel;
        private Label SpellBacksLabel;
        private Panel panel1;
        private Label SpellsLabel;
    }
}