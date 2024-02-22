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
            ControlPanel = new Panel();
            MediaButtonsControl = new Components.MediaButtonsControl();
            InformationLabel = new Label();
            ToolTip = new ToolTip(components);
            IndexLabel = new Label();
            StyleComboBox = new ComboBox();
            ControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ControlPanel
            // 
            ControlPanel.BackColor = Color.Black;
            ControlPanel.Controls.Add(MediaButtonsControl);
            ControlPanel.Controls.Add(InformationLabel);
            ControlPanel.Location = new Point(0, 280);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(384, 70);
            ControlPanel.TabIndex = 1;
            // 
            // MediaButtonsControl
            // 
            MediaButtonsControl.BackColor = Color.Transparent;
            MediaButtonsControl.Location = new Point(70, 35);
            MediaButtonsControl.Name = "MediaButtonsControl";
            MediaButtonsControl.Size = new Size(246, 30);
            MediaButtonsControl.TabIndex = 1;
            // 
            // InformationLabel
            // 
            InformationLabel.Font = new Font("Verdana", 11.25F);
            InformationLabel.ForeColor = Color.White;
            InformationLabel.Location = new Point(10, 8);
            InformationLabel.Name = "InformationLabel";
            InformationLabel.Size = new Size(364, 18);
            InformationLabel.TabIndex = 0;
            InformationLabel.TextAlign = ContentAlignment.MiddleCenter;
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
        private ToolTip ToolTip;
        private Label InformationLabel;
        private Label IndexLabel;
        private ComboBox StyleComboBox;
        private Components.MediaButtonsControl MediaButtonsControl;
    }
}

