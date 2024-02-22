using DofusFlashGenerator.Utils;

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
        IndexRadioButton.Checked = true;
        NumericUpDown.Select();
        NumericUpDown.Select(0, NumericUpDown.Text.Length);
    }

    private void RadioButton_CheckedChanged(object sender, EventArgs e)
    {
        var radioButton = (RadioButton)sender;

        if (radioButton.Checked)
        {
            switch (radioButton.Name)
            {
                case "IndexRadioButton":
                    NumericUpDown.Maximum = _owner.GenericData.Count;
                    break;
                case "IdRadioButton":
                    NumericUpDown.Maximum = _owner.GenericData.Max(x => x.Id);
                    break;
            }
        }
    }

    private void SearchButton_Click(object sender, EventArgs e)
    {
        var index = -1;

        if (IdRadioButton.Checked)
        {
            index = _owner.GenericData.FindIndex(x => x.Id == NumericUpDown.Value);

            if (index == -1)
            {
                MessageBox.Show($"Unable to find the key of for the id {NumericUpDown.Value}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        else if (IndexRadioButton.Checked)
        {
            index = (int)NumericUpDown.Value - 1;
        }

        _owner.Display(index);
        Close();
    }
}
