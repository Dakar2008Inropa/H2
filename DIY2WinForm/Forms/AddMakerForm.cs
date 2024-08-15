using DIY2WinForm.Class;
using DIY2WinForm.Class.Helper;

namespace DIY2WinForm.Forms
{
    public partial class AddMakerForm : Form
    {
        private List<CarMaker> CarMakers { get; set; }
        private List<CountryAPI> Countries { get; set; } = new List<CountryAPI>();
        public CarMaker CarMaker { get; set; }

        public AddMakerForm(List<CarMaker> carmakers)
        {
            CarMakers = carmakers;
            Countries = RestAPI.GetCountries();

            InitializeComponent();
        }

        private void AddMakerBtn_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(NameTextbox.Text) && MessageBox.Show("Please enter a maker name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
            {
                isValid = false;
                NameTextbox.SelectAll();
                NameTextbox.Focus();
            }
            if (CarMakers.Exists(x => x.Name == NameTextbox.Text) && MessageBox.Show("Maker already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
            {
                isValid = false;
                NameTextbox.SelectAll();
                NameTextbox.Focus();
            }
            if (isValid)
            {
                CarMaker = new CarMaker
                {
                    Name = NameTextbox.Text,
                    Country = CountryCombobox.SelectedItem.ToString()
                };

                DialogResult = DialogResult.OK;

                Close();
            }
        }

        private void AddMakerForm_Load(object sender, EventArgs e)
        {
            if (Countries.Any())
            {
                foreach (CountryAPI country in Countries)
                {
                    CountryCombobox.Items.Add(country.name.common);
                }

                CountryCombobox.SelectedIndex = 0;
            }
        }
    }
}