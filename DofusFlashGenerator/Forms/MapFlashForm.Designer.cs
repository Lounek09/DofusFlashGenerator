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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapFlashForm));
            InformationLabel = new Label();
            ControlPanel = new Panel();
            CrackedPictureBox = new PictureBox();
            SearchButton = new Button();
            ScreenButton = new Button();
            NextButton = new Button();
            LastButton = new Button();
            PreviousButton = new Button();
            FirstButton = new Button();
            PlayPauseButton = new Button();
            ToolTip = new ToolTip(components);
            ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CrackedPictureBox).BeginInit();
            SuspendLayout();
            // 
            // InformationLabel
            // 
            InformationLabel.AutoSize = true;
            InformationLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            InformationLabel.ForeColor = Color.White;
            InformationLabel.Location = new Point(10, 8);
            InformationLabel.Name = "InformationLabel";
            InformationLabel.Size = new Size(0, 23);
            InformationLabel.TabIndex = 0;
            // 
            // ControlPanel
            // 
            ControlPanel.BackColor = Color.Black;
            ControlPanel.Controls.Add(CrackedPictureBox);
            ControlPanel.Controls.Add(SearchButton);
            ControlPanel.Controls.Add(ScreenButton);
            ControlPanel.Controls.Add(NextButton);
            ControlPanel.Controls.Add(LastButton);
            ControlPanel.Controls.Add(PreviousButton);
            ControlPanel.Controls.Add(FirstButton);
            ControlPanel.Controls.Add(PlayPauseButton);
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
            // SearchButton
            // 
            SearchButton.BackgroundImage = Properties.Resources.search_disabled;
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.Enabled = false;
            SearchButton.FlatStyle = FlatStyle.Popup;
            SearchButton.Location = new Point(983, 5);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(30, 30);
            SearchButton.TabIndex = 1;
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
            ScreenButton.Location = new Point(1199, 5);
            ScreenButton.Name = "ScreenButton";
            ScreenButton.Size = new Size(30, 30);
            ScreenButton.TabIndex = 7;
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
            NextButton.Location = new Point(1127, 5);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(30, 30);
            NextButton.TabIndex = 5;
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
            LastButton.Location = new Point(1163, 5);
            LastButton.Name = "LastButton";
            LastButton.Size = new Size(30, 30);
            LastButton.TabIndex = 6;
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
            PreviousButton.Location = new Point(1055, 5);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new Size(30, 30);
            PreviousButton.TabIndex = 3;
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
            FirstButton.Location = new Point(1019, 5);
            FirstButton.Name = "FirstButton";
            FirstButton.Size = new Size(30, 30);
            FirstButton.TabIndex = 2;
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
            PlayPauseButton.Location = new Point(1091, 5);
            PlayPauseButton.Name = "PlayPauseButton";
            PlayPauseButton.Size = new Size(30, 30);
            PlayPauseButton.TabIndex = 4;
            PlayPauseButton.UseVisualStyleBackColor = true;
            PlayPauseButton.EnabledChanged += MediaButtons_EnabledChanged;
            PlayPauseButton.Click += MediaButtons_Click;
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
        private System.Windows.Forms.Button PlayPauseButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button ScreenButton;
        private System.Windows.Forms.Button SearchButton;
        private PictureBox CrackedPictureBox;
        private ToolTip ToolTip;
    }
}

