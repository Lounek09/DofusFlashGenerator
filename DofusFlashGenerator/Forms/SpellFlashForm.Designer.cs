namespace DofusFlashGenerator.Forms
{
    partial class SpellFlashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpellFlashForm));
            ControlPanel = new Panel();
            InformationLabel = new Label();
            SearchButton = new Button();
            ScreenButton = new Button();
            NextButton = new Button();
            LastButton = new Button();
            PreviousButton = new Button();
            FirstButton = new Button();
            PlayPauseButton = new Button();
            ToolTip = new ToolTip(components);
            IndexLabel = new Label();
            StyleComboBox = new ComboBox();
            ControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ControlPanel
            // 
            ControlPanel.BackColor = Color.Black;
            ControlPanel.Controls.Add(InformationLabel);
            ControlPanel.Controls.Add(SearchButton);
            ControlPanel.Controls.Add(ScreenButton);
            ControlPanel.Controls.Add(NextButton);
            ControlPanel.Controls.Add(LastButton);
            ControlPanel.Controls.Add(PreviousButton);
            ControlPanel.Controls.Add(FirstButton);
            ControlPanel.Controls.Add(PlayPauseButton);
            ControlPanel.Location = new Point(0, 280);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(384, 70);
            ControlPanel.TabIndex = 1;
            // 
            // InformationLabel
            // 
            InformationLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            InformationLabel.ForeColor = Color.White;
            InformationLabel.Location = new Point(10, 8);
            InformationLabel.Name = "InformationLabel";
            InformationLabel.Size = new Size(364, 18);
            InformationLabel.TabIndex = 0;
            InformationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SearchButton
            // 
            SearchButton.BackgroundImage = Properties.Resources.search_disabled;
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.Enabled = false;
            SearchButton.FlatStyle = FlatStyle.Popup;
            SearchButton.Location = new Point(70, 35);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(30, 30);
            SearchButton.TabIndex = 2;
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.EnabledChanged += MediaButtons_EnabledChanged;
            SearchButton.Click += MediaButtons_Click;
            // 
            // ScreenButton
            // 
            ScreenButton.BackgroundImage = Properties.Resources.camera_disabled;
            ScreenButton.Cursor = Cursors.Hand;
            ScreenButton.Enabled = false;
            ScreenButton.FlatStyle = FlatStyle.Popup;
            ScreenButton.Location = new Point(285, 35);
            ScreenButton.Name = "ScreenButton";
            ScreenButton.Size = new Size(30, 30);
            ScreenButton.TabIndex = 8;
            ScreenButton.UseVisualStyleBackColor = true;
            ScreenButton.EnabledChanged += MediaButtons_EnabledChanged;
            ScreenButton.Click += MediaButtons_Click;
            // 
            // NextButton
            // 
            NextButton.BackgroundImage = Properties.Resources.next_disabled;
            NextButton.Cursor = Cursors.Hand;
            NextButton.Enabled = false;
            NextButton.FlatStyle = FlatStyle.Popup;
            NextButton.Location = new Point(213, 35);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(30, 30);
            NextButton.TabIndex = 6;
            NextButton.UseVisualStyleBackColor = true;
            NextButton.EnabledChanged += MediaButtons_EnabledChanged;
            NextButton.Click += MediaButtons_Click;
            // 
            // LastButton
            // 
            LastButton.BackgroundImage = Properties.Resources.last_disabled;
            LastButton.Cursor = Cursors.Hand;
            LastButton.Enabled = false;
            LastButton.FlatStyle = FlatStyle.Popup;
            LastButton.Location = new Point(249, 35);
            LastButton.Name = "LastButton";
            LastButton.Size = new Size(30, 30);
            LastButton.TabIndex = 7;
            LastButton.UseVisualStyleBackColor = true;
            LastButton.EnabledChanged += MediaButtons_EnabledChanged;
            LastButton.Click += MediaButtons_Click;
            // 
            // PreviousButton
            // 
            PreviousButton.BackgroundImage = Properties.Resources.previous_disabled;
            PreviousButton.Cursor = Cursors.Hand;
            PreviousButton.Enabled = false;
            PreviousButton.FlatStyle = FlatStyle.Popup;
            PreviousButton.Location = new Point(141, 35);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new Size(30, 30);
            PreviousButton.TabIndex = 4;
            PreviousButton.UseVisualStyleBackColor = true;
            PreviousButton.EnabledChanged += MediaButtons_EnabledChanged;
            PreviousButton.Click += MediaButtons_Click;
            // 
            // FirstButton
            // 
            FirstButton.BackgroundImage = Properties.Resources.first_disabled;
            FirstButton.Cursor = Cursors.Hand;
            FirstButton.Enabled = false;
            FirstButton.FlatStyle = FlatStyle.Popup;
            FirstButton.Location = new Point(105, 35);
            FirstButton.Name = "FirstButton";
            FirstButton.Size = new Size(30, 30);
            FirstButton.TabIndex = 3;
            FirstButton.UseVisualStyleBackColor = true;
            FirstButton.EnabledChanged += MediaButtons_EnabledChanged;
            FirstButton.Click += MediaButtons_Click;
            // 
            // PlayPauseButton
            // 
            PlayPauseButton.BackgroundImage = Properties.Resources.playpause_disabled;
            PlayPauseButton.Cursor = Cursors.Hand;
            PlayPauseButton.Enabled = false;
            PlayPauseButton.FlatStyle = FlatStyle.Popup;
            PlayPauseButton.Location = new Point(177, 35);
            PlayPauseButton.Name = "PlayPauseButton";
            PlayPauseButton.Size = new Size(30, 30);
            PlayPauseButton.TabIndex = 5;
            PlayPauseButton.UseVisualStyleBackColor = true;
            PlayPauseButton.EnabledChanged += MediaButtons_EnabledChanged;
            PlayPauseButton.Click += MediaButtons_Click;
            // 
            // IndexLabel
            // 
            IndexLabel.AutoSize = true;
            IndexLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            IndexLabel.ForeColor = Color.White;
            IndexLabel.Location = new Point(12, 9);
            IndexLabel.Name = "IndexLabel";
            IndexLabel.Size = new Size(0, 18);
            IndexLabel.TabIndex = 0;
            // 
            // StyleComboBox
            // 
            StyleComboBox.BackColor = Color.Black;
            StyleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StyleComboBox.ForeColor = Color.White;
            StyleComboBox.FormattingEnabled = true;
            StyleComboBox.Items.AddRange(new object[] { "Remastered", "Contrast", "Classic White", "Classic Black" });
            StyleComboBox.Location = new Point(5, 252);
            StyleComboBox.Name = "StyleComboBox";
            StyleComboBox.Size = new Size(121, 23);
            StyleComboBox.TabIndex = 1;
            StyleComboBox.SelectedIndexChanged += StyleComboBox_SelectedIndexChanged;
            // 
            // SpellFlashForm
            // 
            BackColor = Color.Black;
            ClientSize = new Size(384, 350);
            Controls.Add(StyleComboBox);
            Controls.Add(IndexLabel);
            Controls.Add(ControlPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SpellFlashForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Spell";
            FormClosed += FlashForm_FormClosed;
            Load += MainForm_Load;
            ControlPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
            this.AxShockwaveFlash.Location = new System.Drawing.Point(92, 42);
            this.AxShockwaveFlash.Margin = new System.Windows.Forms.Padding(0);
            this.AxShockwaveFlash.Name = "axShockwaveFlash";
            this.AxShockwaveFlash.OcxState = (System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash.OcxState"));
            this.AxShockwaveFlash.Size = new System.Drawing.Size(200, 200);
            this.Controls.Add(AxShockwaveFlash);
            this.ResumeLayout(false);
        }

        private AxShockwaveFlashObjects.AxShockwaveFlash AxShockwaveFlash;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button PlayPauseButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button ScreenButton;
        private System.Windows.Forms.Button SearchButton;
        private ToolTip ToolTip;
        private Label InformationLabel;
        private Label IndexLabel;
        private ComboBox StyleComboBox;
    }
}

