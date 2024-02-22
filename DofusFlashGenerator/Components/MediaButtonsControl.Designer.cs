namespace DofusFlashGenerator.Components;

partial class MediaButtonsControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        SearchButton = new Button();
        ScreenButton = new Button();
        NextButton = new Button();
        LastButton = new Button();
        PreviousButton = new Button();
        FirstButton = new Button();
        PlayPauseButton = new Button();
        SuspendLayout();
        // 
        // SearchButton
        // 
        SearchButton.BackgroundImage = Properties.Resources.search_disabled;
        SearchButton.Cursor = Cursors.Hand;
        SearchButton.Enabled = false;
        SearchButton.FlatStyle = FlatStyle.Popup;
        SearchButton.Location = new Point(0, 0);
        SearchButton.Name = "SearchButton";
        SearchButton.Size = new Size(30, 30);
        SearchButton.TabIndex = 1;
        SearchButton.UseVisualStyleBackColor = true;
        SearchButton.EnabledChanged += MediaButton_EnabledChanged;
        SearchButton.Click += MediaButton_Click;
        // 
        // ScreenButton
        // 
        ScreenButton.BackgroundImage = Properties.Resources.camera_disabled;
        ScreenButton.Cursor = Cursors.Hand;
        ScreenButton.Enabled = false;
        ScreenButton.FlatStyle = FlatStyle.Popup;
        ScreenButton.Location = new Point(216, 0);
        ScreenButton.Name = "ScreenButton";
        ScreenButton.Size = new Size(30, 30);
        ScreenButton.TabIndex = 7;
        ScreenButton.UseVisualStyleBackColor = true;
        ScreenButton.EnabledChanged += MediaButton_EnabledChanged;
        ScreenButton.Click += MediaButton_Click;
        // 
        // NextButton
        // 
        NextButton.BackgroundImage = Properties.Resources.next_disabled;
        NextButton.Cursor = Cursors.Hand;
        NextButton.Enabled = false;
        NextButton.FlatStyle = FlatStyle.Popup;
        NextButton.Location = new Point(144, 0);
        NextButton.Name = "NextButton";
        NextButton.Size = new Size(30, 30);
        NextButton.TabIndex = 5;
        NextButton.UseVisualStyleBackColor = true;
        NextButton.EnabledChanged += MediaButton_EnabledChanged;
        NextButton.Click += MediaButton_Click;
        // 
        // LastButton
        // 
        LastButton.BackgroundImage = Properties.Resources.last_disabled;
        LastButton.Cursor = Cursors.Hand;
        LastButton.Enabled = false;
        LastButton.FlatStyle = FlatStyle.Popup;
        LastButton.Location = new Point(180, 0);
        LastButton.Name = "LastButton";
        LastButton.Size = new Size(30, 30);
        LastButton.TabIndex = 6;
        LastButton.UseVisualStyleBackColor = true;
        LastButton.EnabledChanged += MediaButton_EnabledChanged;
        LastButton.Click += MediaButton_Click;
        // 
        // PreviousButton
        // 
        PreviousButton.BackgroundImage = Properties.Resources.previous_disabled;
        PreviousButton.Cursor = Cursors.Hand;
        PreviousButton.Enabled = false;
        PreviousButton.FlatStyle = FlatStyle.Popup;
        PreviousButton.Location = new Point(72, 0);
        PreviousButton.Name = "PreviousButton";
        PreviousButton.Size = new Size(30, 30);
        PreviousButton.TabIndex = 3;
        PreviousButton.UseVisualStyleBackColor = true;
        PreviousButton.EnabledChanged += MediaButton_EnabledChanged;
        PreviousButton.Click += MediaButton_Click;
        // 
        // FirstButton
        // 
        FirstButton.BackgroundImage = Properties.Resources.first_disabled;
        FirstButton.Cursor = Cursors.Hand;
        FirstButton.Enabled = false;
        FirstButton.FlatStyle = FlatStyle.Popup;
        FirstButton.Location = new Point(36, 0);
        FirstButton.Name = "FirstButton";
        FirstButton.Size = new Size(30, 30);
        FirstButton.TabIndex = 2;
        FirstButton.UseVisualStyleBackColor = true;
        FirstButton.EnabledChanged += MediaButton_EnabledChanged;
        FirstButton.Click += MediaButton_Click;
        // 
        // PlayPauseButton
        // 
        PlayPauseButton.BackgroundImage = Properties.Resources.playpause_disabled;
        PlayPauseButton.Cursor = Cursors.Hand;
        PlayPauseButton.Enabled = false;
        PlayPauseButton.FlatStyle = FlatStyle.Popup;
        PlayPauseButton.Location = new Point(108, 0);
        PlayPauseButton.Name = "PlayPauseButton";
        PlayPauseButton.Size = new Size(30, 30);
        PlayPauseButton.TabIndex = 4;
        PlayPauseButton.UseVisualStyleBackColor = true;
        PlayPauseButton.EnabledChanged += MediaButton_EnabledChanged;
        PlayPauseButton.Click += MediaButton_Click;
        // 
        // MediaButtonsControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Transparent;
        Controls.Add(SearchButton);
        Controls.Add(ScreenButton);
        Controls.Add(NextButton);
        Controls.Add(LastButton);
        Controls.Add(PreviousButton);
        Controls.Add(FirstButton);
        Controls.Add(PlayPauseButton);
        Name = "MediaButtonsControl";
        Size = new Size(246, 30);
        Load += MediaButtonsControl_Load;
        ResumeLayout(false);
    }

    #endregion

    public Button SearchButton;
    public Button ScreenButton;
    public Button NextButton;
    public Button LastButton;
    public Button PreviousButton;
    public Button FirstButton;
    public Button PlayPauseButton;
}
