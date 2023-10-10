namespace DofusFlashGenerator.Forms
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            IdRadioButton = new RadioButton();
            IndexRadioButton = new RadioButton();
            NumericUpDown = new NumericUpDown();
            SearchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // IdRadioButton
            // 
            IdRadioButton.AutoSize = true;
            IdRadioButton.Location = new Point(76, 14);
            IdRadioButton.Margin = new Padding(4, 3, 4, 3);
            IdRadioButton.Name = "IdRadioButton";
            IdRadioButton.Size = new Size(35, 19);
            IdRadioButton.TabIndex = 2;
            IdRadioButton.Text = "Id";
            IdRadioButton.UseVisualStyleBackColor = true;
            IdRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // IndexRadioButton
            // 
            IndexRadioButton.AutoSize = true;
            IndexRadioButton.Location = new Point(14, 14);
            IndexRadioButton.Margin = new Padding(4, 3, 4, 3);
            IndexRadioButton.Name = "IndexRadioButton";
            IndexRadioButton.Size = new Size(54, 19);
            IndexRadioButton.TabIndex = 1;
            IndexRadioButton.Text = "Index";
            IndexRadioButton.UseVisualStyleBackColor = true;
            IndexRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // NumericUpDown
            // 
            NumericUpDown.Location = new Point(14, 42);
            NumericUpDown.Margin = new Padding(4, 3, 4, 3);
            NumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericUpDown.Name = "NumericUpDown";
            NumericUpDown.Size = new Size(97, 23);
            NumericUpDown.TabIndex = 3;
            NumericUpDown.ThousandsSeparator = true;
            NumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SearchButton
            // 
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.Location = new Point(14, 72);
            SearchButton.Margin = new Padding(4, 3, 4, 3);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(97, 27);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchForm
            // 
            AcceptButton = SearchButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(125, 106);
            Controls.Add(SearchButton);
            Controls.Add(NumericUpDown);
            Controls.Add(IndexRadioButton);
            Controls.Add(IdRadioButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SearchForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search";
            TopMost = true;
            Load += SearchForm_Load;
            ((System.ComponentModel.ISupportInitialize)NumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RadioButton IdRadioButton;
        private System.Windows.Forms.RadioButton IndexRadioButton;
        private System.Windows.Forms.NumericUpDown NumericUpDown;
        private System.Windows.Forms.Button SearchButton;
    }
}