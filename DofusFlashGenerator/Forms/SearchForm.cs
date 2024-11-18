using DofusFlashGenerator.Extensions;

namespace DofusFlashGenerator.Forms;

public partial class SearchForm : Form
{
    private readonly IFlashForm _owner;

    public SearchForm(IFlashForm owner)
    {
        InitializeComponent();

        _owner = owner;
    }

    private void SearchForm_Load(object sender, EventArgs e)
    {
        IdRadioButton.Checked = true;
        NumericUpDown.Select();
        NumericUpDown.Select(0, NumericUpDown.Text.Length);
    }

    private void RadioButton_CheckedChanged(object sender, EventArgs e)
    {
        if (sender is not RadioButton radioButton)
        {
            return;
        }

        if (radioButton.Checked)
        {
            NumericUpDown.Maximum = radioButton.Name switch
            {
                "IndexRadioButton" => _owner.GenericData.Count,
                "IdRadioButton" => _owner.GenericData.Max(x => x.Id),
                _ => NumericUpDown.Maximum
            };
        }
    }

    private void SearchButton_Click(object sender, EventArgs e)
    {
        var index = -1;

        if (IdRadioButton.Checked)
        {
            index = _owner.GenericData.FindIndex(x => x.Id == NumericUpDown.Value);
        }
        else if (IndexRadioButton.Checked)
        {
            index = (int)NumericUpDown.Value - 1;
        }

        if (index == -1)
        {
            MessageBox.Show($"Unable to find the key of for the id {NumericUpDown.Value}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _owner.Display(index);
        Close();
    }
}
