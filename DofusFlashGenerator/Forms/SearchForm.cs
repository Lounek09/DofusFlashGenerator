using DofusFlashGenerator.Models;

namespace DofusFlashGenerator.Forms;

public partial class SearchForm : Form
{
    private readonly IFlashForm _owner;
    private readonly List<IData> _data;

    public SearchForm(IFlashForm owner, List<IData> data)
    {
        InitializeComponent();
        _owner = owner;
        _data = data;
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
                    NumericUpDown.Maximum = _data.Count;
                    break;
                case "IdRadioButton":
                    NumericUpDown.Maximum = _data.Max(x => x.Id);
                    break;
            }
        }
    }

    private void SearchButton_Click(object sender, EventArgs e)
    {
        var index = -1;

        if (IdRadioButton.Checked)
        {
            index = _data.FindIndex(x => x.Id == NumericUpDown.Value);

            if (index == -1)
            {
                MessageBox.Show($"Unable to find the key of for the id {NumericUpDown.Value}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else if (IndexRadioButton.Checked)
        {
            index = (int)NumericUpDown.Value - 1;
        }

        if (index > -1)
        {
            _owner.Display(index);
            Close();
        }
    }
}
