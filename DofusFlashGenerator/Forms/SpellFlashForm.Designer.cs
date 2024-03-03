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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(SpellFlashForm));
            IndexLabel = new Label();
            AxShockwaveFlash = new AxShockwaveFlashObjects.AxShockwaveFlash();
            StyleComboBox = new ComboBox();
            ControlPanel = new Panel();
            InformationLabel = new Label();
            MediaButtonsControl = new Components.MediaButtonsControl();
            ToolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)AxShockwaveFlash).BeginInit();
            ControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // IndexLabel
            // 
            IndexLabel.AutoSize = true;
            IndexLabel.Font = new Font("Verdana", 11.25F);
            IndexLabel.ForeColor = Color.White;
            IndexLabel.Location = new Point(12, 9);
            IndexLabel.Name = "IndexLabel";
            IndexLabel.Size = new Size(0, 18);
            IndexLabel.TabIndex = 0;
            // 
            // AxShockwaveFlash
            // 
            AxShockwaveFlash.Enabled = true;
            AxShockwaveFlash.Location = new Point(92, 42);
            AxShockwaveFlash.Name = "AxShockwaveFlash";
            AxShockwaveFlash.OcxState = (AxHost.State)resources.GetObject("AxShockwaveFlash.OcxState");
            AxShockwaveFlash.Size = new Size(512, 512);
            AxShockwaveFlash.TabIndex = 0;
            AxShockwaveFlash.TabStop = false;
            // 
            // StyleComboBox
            // 
            StyleComboBox.BackColor = Color.Black;
            StyleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StyleComboBox.ForeColor = Color.White;
            StyleComboBox.FormattingEnabled = true;
            StyleComboBox.Items.AddRange(new object[] { "Remastered", "Contrast", "Classic White", "Classic Black" });
            StyleComboBox.Location = new Point(5, 564);
            StyleComboBox.Name = "StyleComboBox";
            StyleComboBox.Size = new Size(121, 23);
            StyleComboBox.TabIndex = 1;
            StyleComboBox.SelectedIndexChanged += StyleComboBox_SelectedIndexChanged;
            // 
            // ControlPanel
            // 
            ControlPanel.BackColor = Color.Black;
            ControlPanel.Controls.Add(InformationLabel);
            ControlPanel.Controls.Add(MediaButtonsControl);
            ControlPanel.Location = new Point(0, 592);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(696, 70);
            ControlPanel.TabIndex = 0;
            // 
            // InformationLabel
            // 
            InformationLabel.Font = new Font("Verdana", 11.25F);
            InformationLabel.ForeColor = Color.White;
            InformationLabel.Location = new Point(166, 8);
            InformationLabel.Name = "InformationLabel";
            InformationLabel.Size = new Size(364, 18);
            InformationLabel.TabIndex = 0;
            InformationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MediaButtonsControl
            // 
            MediaButtonsControl.BackColor = Color.Transparent;
            MediaButtonsControl.Location = new Point(226, 29);
            MediaButtonsControl.Name = "MediaButtonsControl";
            MediaButtonsControl.Size = new Size(246, 30);
            MediaButtonsControl.TabIndex = 2;
            // 
            // SpellFlashForm
            // 
            BackColor = Color.Black;
            ClientSize = new Size(696, 662);
            Controls.Add(IndexLabel);
            Controls.Add(AxShockwaveFlash);
            Controls.Add(StyleComboBox);
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
            ((System.ComponentModel.ISupportInitialize)AxShockwaveFlash).EndInit();
            ControlPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IndexLabel;
        private AxShockwaveFlashObjects.AxShockwaveFlash AxShockwaveFlash;
        private ComboBox StyleComboBox;
        private Panel ControlPanel;
        private Label InformationLabel;
        private Components.MediaButtonsControl MediaButtonsControl;
        private ToolTip ToolTip;
    }
}

