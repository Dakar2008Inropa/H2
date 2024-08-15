using DIY2WinForm.Class;

namespace DIY2WinForm.Forms
{
    public partial class AddModelForm : Form
    {
        private List<CarMaker> CarMakers { get; set; } = new List<CarMaker>();
        private List<CarModel> CarModels { get; set; } = new List<CarModel>();
        private Color selectedColor { get; set; }

        public CarModel NewCarModel { get; set; }


        public AddModelForm(List<CarMaker> carmakers, List<CarModel> carmodels)
        {
            CarMakers = carmakers;
            CarModels = carmodels;
            InitializeComponent();
        }

        private void ColorBox_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ColorBox.BackColor = colorDialog1.Color;
            }
        }

        private void AddModelForm_Load(object sender, EventArgs e)
        {
            selectedColor = colorDialog1.Color;
            ColorBox.BackColor = colorDialog1.Color;

            if (CarMakers.Any())
            {
                MakerComboBox.DataSource = CarMakers;
                MakerComboBox.DisplayMember = "Name";
            }
        }

        private void AddModelBtn_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(ModelTextbox.Text) && MessageBox.Show("You must enter a model name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
            {
                isValid = false;
                ModelTextbox.SelectAll();
                ModelTextbox.Focus();
            }
            if (CarModels.Exists(x => x.Model == ModelTextbox.Text) && MessageBox.Show("Model already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
            {
                isValid = false;
                ModelTextbox.SelectAll();
                ModelTextbox.Focus();
            }
            if (isValid)
            {
                NewCarModel = new CarModel();
                NewCarModel.CarMakerId = ((CarMaker)MakerComboBox.SelectedItem).Id;
                NewCarModel.Maker = (CarMaker)MakerComboBox.SelectedItem;
                NewCarModel.Model = ModelTextbox.Text;
                NewCarModel.ProductionYear = (int)ProductionYearUpDown.Value;
                NewCarModel.Color = ColorTranslator.ToHtml(selectedColor);

                DialogResult = DialogResult.OK;

                Close();
            }
        }
    }
}