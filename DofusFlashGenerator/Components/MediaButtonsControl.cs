using DofusFlashGenerator.Forms;
using DofusFlashGenerator.Properties;
using DofusFlashGenerator.Utils;

namespace DofusFlashGenerator.Components;

public partial class MediaButtonsControl : UserControl
{
    private IFlashForm _owner = default!;

    public MediaButtonsControl()
    {
        InitializeComponent();
    }

    private void MediaButtonsControl_Load(object sender, EventArgs e)
    {
        var owner = this.GetNearestParentAs<IFlashForm>()
            ?? throw new InvalidOperationException("Parent form must implement IFlashForm");

        _owner = owner;
    }

    private async void MediaButton_Click(object sender, EventArgs e)
    {
        var button = (Button)sender;

        switch (button.Name)
        {
            case "SearchButton":
                SearchForm searchForm = new(_owner) { Owner = this.GetNearestParentAs<Form>()! };
                searchForm.Show();
                break;
            case "FirstButton":
                await _owner.Display(0);
                break;
            case "PreviousButton":
                await _owner.Display(_owner.Index == 0 ? _owner.LastIndex : _owner.Index - 1);
                break;
            case "PlayPauseButton":
                await _owner.AutoPlay(!_owner.IsAutoPlay);
                break;
            case "NextButton":
                await _owner.Display(_owner.Index == _owner.LastIndex ? 0 : _owner.Index + 1);
                break;
            case "LastButton":
                await _owner.Display(_owner.LastIndex);
                break;
            case "ScreenButton":
                _owner.Screen();
                break;
        }
    }

    private void MediaButton_EnabledChanged(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var enabled = button.Enabled;

        switch (button.Name)
        {
            case "SearchButton":
                button.BackgroundImage = enabled ? Resources.search_enabled : Resources.search_disabled;
                break;
            case "FirstButton":
                button.BackgroundImage = enabled ? Resources.first_enabled : Resources.first_disabled;
                break;
            case "PreviousButton":
                button.BackgroundImage = enabled ? Resources.previous_enabled : Resources.previous_disabled;
                break;
            case "PlayPauseButton":
                button.BackgroundImage = enabled ? Resources.playpause_enabled : Resources.playpause_disabled;
                break;
            case "NextButton":
                button.BackgroundImage = enabled ? Resources.next_enabled : Resources.next_disabled;
                break;
            case "LastButton":
                button.BackgroundImage = enabled ? Resources.last_enabled : Resources.last_disabled;
                break;
            case "ScreenButton":
                button.BackgroundImage = enabled ? Resources.camera_enabled : Resources.camera_disabled;
                break;
        }
    }

    public void EnableMediaButtons(bool enabled)
    {
        SearchButton.Enabled = enabled;
        FirstButton.Enabled = enabled && _owner.Index != 0;
        PreviousButton.Enabled = enabled;
        PlayPauseButton.Enabled = (enabled && _owner.Index != _owner.LastIndex) || _owner.IsAutoPlay;
        NextButton.Enabled = enabled;
        LastButton.Enabled = enabled && _owner.Index != _owner.LastIndex;
        ScreenButton.Enabled = enabled;
    }
}
