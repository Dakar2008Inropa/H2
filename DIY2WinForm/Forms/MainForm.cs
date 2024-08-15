using DIY2WinForm.Class;
using DIY2WinForm.Forms;

namespace DIY2WinForm
{
    public partial class MainForm : Form
    {
        private List<CarMaker> carMakers { get; set; }
        private List<CarModel> carModels { get; set; }
        private List<CarList> carList { get; set; }


        public MainForm()
        {
            carList = new List<CarList>();
            carMakers = CarMaker.LoadCarMakerData();
            carModels = CarModel.LoadCarModelData();

            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CarMaker.SaveCarMakerData(carMakers);
            CarModel.SaveCarModelData(carModels);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            carList = CarList.PopulateCarList(carMakers, carModels);

            carListBindingSource.DataSource = carList;
            carListBindingSource.ResetBindings(false);
        }

        private void DatabaseTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DatabaseTabControl.SelectedTab == FindCarPage)
            {
                carList = CarList.PopulateCarList(carMakers, carModels);

                carListBindingSource.DataSource = carList;
                carListBindingSource.ResetBindings(false);

                SearchBox.Focus();
            }
            else
            {
                PopulateMakersWithMostModels();
                PopulateCountriesWithMostMakers();
            }
        }

        private void AddMakerBtn_Click(object sender, EventArgs e)
        {
            AddMakerForm addMakerForm = new AddMakerForm(carMakers);
            if (addMakerForm.ShowDialog() == DialogResult.OK)
            {
                carMakers.Add(addMakerForm.CarMaker);
                carMakers = carMakers.OrderBy(x => x.Name).ToList();

                carList = CarList.PopulateCarList(carMakers, carModels);
                carListBindingSource.DataSource = carList;
                carListBindingSource.ResetBindings(false);
            }
        }

        private void AddModelBtn_Click(object sender, EventArgs e)
        {
            if (carMakers.Any())
            {
                AddModelForm addModelForm = new AddModelForm(carMakers, carModels);
                if (addModelForm.ShowDialog() == DialogResult.OK)
                {
                    carModels.Add(addModelForm.NewCarModel);
                    carModels = carModels.OrderBy(x => x.Model).ToList();

                    carList = CarList.PopulateCarList(carMakers, carModels);
                    carListBindingSource.DataSource = carList;
                    carListBindingSource.ResetBindings(false);
                }
            }
            else
            {
                MessageBox.Show("You must add a maker first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<CarList> searchCarList;
                searchCarList = CarList.SearchCarList(carList, SearchBox.Text);

                carListBindingSource.DataSource = searchCarList;
                carListBindingSource.ResetBindings(false);
            }
        }

        private void PopulateMakersWithMostModels()
        {
            var groupMakersWithMostModels = carList.GroupBy(x => x.Maker)
                .Select(x => new
                {
                    Maker = x.Key,
                    ModelCount = x.Count()
                })
                .OrderByDescending(x => x.ModelCount)
                .Take(10)
                .ToList();

            MakersWithMostModelsGroupbox.Controls.Clear();

            int startingY = 21;
            int increaseYWith = 23;

            for (int i = 0; i < groupMakersWithMostModels.Count; i++)
            {
                Label MakerLabel = new Label();
                MakerLabel.Name = $"MakerLabel{i}";
                MakerLabel.Text = $"{groupMakersWithMostModels[i].Maker}";
                MakerLabel.Location = new Point(TestLabel1.Location.X, startingY);
                MakerLabel.Size = TestLabel1.Size;
                MakerLabel.AutoSize = TestLabel1.AutoSize;
                MakerLabel.Font = TestLabel1.Font;
                MakerLabel.TextAlign = TestLabel1.TextAlign;

                Label CountLabel = new Label();
                CountLabel.Name = $"CountLabel{i}";
                CountLabel.Text = $"{groupMakersWithMostModels[i].ModelCount}";
                CountLabel.Location = new Point(TestLabel2.Location.X, startingY);
                CountLabel.Size = TestLabel2.Size;
                CountLabel.AutoSize = TestLabel2.AutoSize;
                CountLabel.Font = TestLabel2.Font;
                CountLabel.TextAlign = TestLabel2.TextAlign;
                CountLabel.ForeColor = TestLabel2.ForeColor;

                startingY += increaseYWith;

                MakersWithMostModelsGroupbox.Controls.Add(MakerLabel);
                MakersWithMostModelsGroupbox.Controls.Add(CountLabel);
            }
        }

        private void PopulateCountriesWithMostMakers()
        {
            var groupCountriesWithMostMakers = carList.GroupBy(x => x.Country)
                .Select(x => new
                {
                    Country = x.Key,
                    MakerCount = x.Select(y => y.Maker).Distinct().Count()
                })
                .OrderByDescending(x => x.MakerCount)
                .Take(10)
                .ToList();

            CountriesWithMostMakersGroupbox.Controls.Clear();

            int startingY = 21;
            int increaseYWith = 23;

            for (int i = 0; i < groupCountriesWithMostMakers.Count; i++)
            {
                Label CountryLabel = new Label();
                CountryLabel.Name = $"CountryLabel{i}";
                CountryLabel.Text = $"{groupCountriesWithMostMakers[i].Country}";
                CountryLabel.Location = new Point(TestLabel3.Location.X, startingY);
                CountryLabel.Size = TestLabel3.Size;
                CountryLabel.AutoSize = TestLabel3.AutoSize;
                CountryLabel.Font = TestLabel3.Font;
                CountryLabel.TextAlign = TestLabel3.TextAlign;

                Label CountLabel = new Label();
                CountLabel.Name = $"CountLabel{i}";
                CountLabel.Text = $"{groupCountriesWithMostMakers[i].MakerCount}";
                CountLabel.Location = new Point(TestLabel4.Location.X, startingY);
                CountLabel.Size = TestLabel4.Size;
                CountLabel.AutoSize = TestLabel4.AutoSize;
                CountLabel.Font = TestLabel4.Font;
                CountLabel.TextAlign = TestLabel4.TextAlign;
                CountLabel.ForeColor = TestLabel4.ForeColor;

                startingY += increaseYWith;

                CountriesWithMostMakersGroupbox.Controls.Add(CountryLabel);
                CountriesWithMostMakersGroupbox.Controls.Add(CountLabel);
            }
        }
    }
}