namespace DIY2WinForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            AddMakerBtn = new Button();
            AddModelBtn = new Button();
            Header = new Label();
            DatabaseTabControl = new TabControl();
            FindCarPage = new TabPage();
            SearchBox = new TextBox();
            CarDatabaseGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            makerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productionYearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            colorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carListBindingSource = new BindingSource(components);
            StatsPage = new TabPage();
            CountriesWithMostMakersGroupbox = new GroupBox();
            TestLabel4 = new Label();
            TestLabel3 = new Label();
            MakersWithMostModelsGroupbox = new GroupBox();
            TestLabel2 = new Label();
            TestLabel1 = new Label();
            TabControlImageList = new ImageList(components);
            label1 = new Label();
            label2 = new Label();
            DatabaseTabControl.SuspendLayout();
            FindCarPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CarDatabaseGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carListBindingSource).BeginInit();
            StatsPage.SuspendLayout();
            CountriesWithMostMakersGroupbox.SuspendLayout();
            MakersWithMostModelsGroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // AddMakerBtn
            // 
            AddMakerBtn.BackColor = Color.ForestGreen;
            AddMakerBtn.Cursor = Cursors.Hand;
            AddMakerBtn.FlatAppearance.BorderColor = Color.White;
            AddMakerBtn.FlatStyle = FlatStyle.Flat;
            AddMakerBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddMakerBtn.ForeColor = Color.White;
            AddMakerBtn.Location = new Point(5, 5);
            AddMakerBtn.Margin = new Padding(0, 0, 5, 0);
            AddMakerBtn.Name = "AddMakerBtn";
            AddMakerBtn.Size = new Size(151, 34);
            AddMakerBtn.TabIndex = 1;
            AddMakerBtn.TabStop = false;
            AddMakerBtn.Text = "Add Maker";
            AddMakerBtn.UseVisualStyleBackColor = false;
            AddMakerBtn.Click += AddMakerBtn_Click;
            // 
            // AddModelBtn
            // 
            AddModelBtn.BackColor = Color.ForestGreen;
            AddModelBtn.Cursor = Cursors.Hand;
            AddModelBtn.FlatAppearance.BorderColor = Color.White;
            AddModelBtn.FlatStyle = FlatStyle.Flat;
            AddModelBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddModelBtn.ForeColor = Color.White;
            AddModelBtn.Location = new Point(161, 5);
            AddModelBtn.Margin = new Padding(0, 0, 5, 0);
            AddModelBtn.Name = "AddModelBtn";
            AddModelBtn.Size = new Size(151, 34);
            AddModelBtn.TabIndex = 2;
            AddModelBtn.TabStop = false;
            AddModelBtn.Text = "Add Model";
            AddModelBtn.UseVisualStyleBackColor = false;
            AddModelBtn.Click += AddModelBtn_Click;
            // 
            // Header
            // 
            Header.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Header.ForeColor = Color.White;
            Header.Location = new Point(317, 5);
            Header.Margin = new Padding(0, 0, 0, 5);
            Header.Name = "Header";
            Header.Size = new Size(519, 34);
            Header.TabIndex = 2;
            Header.Text = "Car Database";
            Header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DatabaseTabControl
            // 
            DatabaseTabControl.Controls.Add(FindCarPage);
            DatabaseTabControl.Controls.Add(StatsPage);
            DatabaseTabControl.ImageList = TabControlImageList;
            DatabaseTabControl.Location = new Point(5, 49);
            DatabaseTabControl.Margin = new Padding(0, 10, 0, 0);
            DatabaseTabControl.Name = "DatabaseTabControl";
            DatabaseTabControl.SelectedIndex = 0;
            DatabaseTabControl.Size = new Size(831, 441);
            DatabaseTabControl.TabIndex = 4;
            DatabaseTabControl.TabStop = false;
            DatabaseTabControl.SelectedIndexChanged += DatabaseTabControl_SelectedIndexChanged;
            // 
            // FindCarPage
            // 
            FindCarPage.Controls.Add(SearchBox);
            FindCarPage.Controls.Add(CarDatabaseGridView);
            FindCarPage.ImageIndex = 1;
            FindCarPage.Location = new Point(4, 25);
            FindCarPage.Margin = new Padding(0);
            FindCarPage.Name = "FindCarPage";
            FindCarPage.Padding = new Padding(5);
            FindCarPage.Size = new Size(823, 412);
            FindCarPage.TabIndex = 0;
            FindCarPage.Text = "Find Car";
            FindCarPage.UseVisualStyleBackColor = true;
            // 
            // SearchBox
            // 
            SearchBox.BorderStyle = BorderStyle.FixedSingle;
            SearchBox.Location = new Point(5, 5);
            SearchBox.Margin = new Padding(0, 0, 0, 5);
            SearchBox.Name = "SearchBox";
            SearchBox.PlaceholderText = "Search for a car here";
            SearchBox.Size = new Size(813, 23);
            SearchBox.TabIndex = 0;
            SearchBox.TextAlign = HorizontalAlignment.Center;
            SearchBox.KeyDown += SearchBox_KeyDown;
            // 
            // CarDatabaseGridView
            // 
            CarDatabaseGridView.AllowUserToAddRows = false;
            CarDatabaseGridView.AllowUserToDeleteRows = false;
            CarDatabaseGridView.AllowUserToResizeRows = false;
            CarDatabaseGridView.AutoGenerateColumns = false;
            CarDatabaseGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarDatabaseGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, makerDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, productionYearDataGridViewTextBoxColumn, colorDataGridViewTextBoxColumn, countryDataGridViewTextBoxColumn });
            CarDatabaseGridView.DataSource = carListBindingSource;
            CarDatabaseGridView.Location = new Point(5, 33);
            CarDatabaseGridView.Margin = new Padding(0);
            CarDatabaseGridView.MultiSelect = false;
            CarDatabaseGridView.Name = "CarDatabaseGridView";
            CarDatabaseGridView.ReadOnly = true;
            CarDatabaseGridView.RowHeadersVisible = false;
            CarDatabaseGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CarDatabaseGridView.Size = new Size(813, 374);
            CarDatabaseGridView.TabIndex = 3;
            CarDatabaseGridView.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // makerDataGridViewTextBoxColumn
            // 
            makerDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            makerDataGridViewTextBoxColumn.DataPropertyName = "Maker";
            makerDataGridViewTextBoxColumn.HeaderText = "Maker";
            makerDataGridViewTextBoxColumn.Name = "makerDataGridViewTextBoxColumn";
            makerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            modelDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            modelDataGridViewTextBoxColumn.HeaderText = "Model";
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionYearDataGridViewTextBoxColumn
            // 
            productionYearDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productionYearDataGridViewTextBoxColumn.DataPropertyName = "ProductionYear";
            productionYearDataGridViewTextBoxColumn.HeaderText = "Year";
            productionYearDataGridViewTextBoxColumn.Name = "productionYearDataGridViewTextBoxColumn";
            productionYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            colorDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            colorDataGridViewTextBoxColumn.HeaderText = "Color";
            colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            countryDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            countryDataGridViewTextBoxColumn.HeaderText = "Country";
            countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carListBindingSource
            // 
            carListBindingSource.DataSource = typeof(Class.CarList);
            // 
            // StatsPage
            // 
            StatsPage.Controls.Add(CountriesWithMostMakersGroupbox);
            StatsPage.Controls.Add(MakersWithMostModelsGroupbox);
            StatsPage.ImageIndex = 0;
            StatsPage.Location = new Point(4, 25);
            StatsPage.Margin = new Padding(0);
            StatsPage.Name = "StatsPage";
            StatsPage.Padding = new Padding(5);
            StatsPage.Size = new Size(823, 412);
            StatsPage.TabIndex = 1;
            StatsPage.Text = "Statistics";
            StatsPage.UseVisualStyleBackColor = true;
            // 
            // CountriesWithMostMakersGroupbox
            // 
            CountriesWithMostMakersGroupbox.Controls.Add(TestLabel4);
            CountriesWithMostMakersGroupbox.Controls.Add(TestLabel3);
            CountriesWithMostMakersGroupbox.FlatStyle = FlatStyle.Flat;
            CountriesWithMostMakersGroupbox.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CountriesWithMostMakersGroupbox.Location = new Point(400, 5);
            CountriesWithMostMakersGroupbox.Margin = new Padding(0);
            CountriesWithMostMakersGroupbox.Name = "CountriesWithMostMakersGroupbox";
            CountriesWithMostMakersGroupbox.Padding = new Padding(5);
            CountriesWithMostMakersGroupbox.Size = new Size(418, 402);
            CountriesWithMostMakersGroupbox.TabIndex = 1;
            CountriesWithMostMakersGroupbox.TabStop = false;
            CountriesWithMostMakersGroupbox.Text = "Countries With Most Makers";
            // 
            // TestLabel4
            // 
            TestLabel4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TestLabel4.ForeColor = Color.Red;
            TestLabel4.Location = new Point(260, 21);
            TestLabel4.Margin = new Padding(0, 0, 0, 3);
            TestLabel4.Name = "TestLabel4";
            TestLabel4.Size = new Size(153, 20);
            TestLabel4.TabIndex = 3;
            TestLabel4.Text = "label1";
            TestLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TestLabel3
            // 
            TestLabel3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TestLabel3.Location = new Point(5, 21);
            TestLabel3.Margin = new Padding(0, 0, 5, 3);
            TestLabel3.Name = "TestLabel3";
            TestLabel3.Size = new Size(250, 20);
            TestLabel3.TabIndex = 2;
            TestLabel3.Text = "label1";
            TestLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MakersWithMostModelsGroupbox
            // 
            MakersWithMostModelsGroupbox.Controls.Add(label2);
            MakersWithMostModelsGroupbox.Controls.Add(label1);
            MakersWithMostModelsGroupbox.Controls.Add(TestLabel2);
            MakersWithMostModelsGroupbox.Controls.Add(TestLabel1);
            MakersWithMostModelsGroupbox.FlatStyle = FlatStyle.Flat;
            MakersWithMostModelsGroupbox.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MakersWithMostModelsGroupbox.Location = new Point(5, 5);
            MakersWithMostModelsGroupbox.Margin = new Padding(0, 0, 5, 0);
            MakersWithMostModelsGroupbox.Name = "MakersWithMostModelsGroupbox";
            MakersWithMostModelsGroupbox.Padding = new Padding(5);
            MakersWithMostModelsGroupbox.Size = new Size(390, 402);
            MakersWithMostModelsGroupbox.TabIndex = 0;
            MakersWithMostModelsGroupbox.TabStop = false;
            MakersWithMostModelsGroupbox.Text = "Makers With Most Models";
            // 
            // TestLabel2
            // 
            TestLabel2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TestLabel2.ForeColor = Color.Red;
            TestLabel2.Location = new Point(248, 21);
            TestLabel2.Margin = new Padding(0, 0, 0, 3);
            TestLabel2.Name = "TestLabel2";
            TestLabel2.Size = new Size(137, 20);
            TestLabel2.TabIndex = 1;
            TestLabel2.Text = "label1";
            TestLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TestLabel1
            // 
            TestLabel1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TestLabel1.Location = new Point(5, 21);
            TestLabel1.Margin = new Padding(0, 0, 5, 3);
            TestLabel1.Name = "TestLabel1";
            TestLabel1.Size = new Size(238, 20);
            TestLabel1.TabIndex = 0;
            TestLabel1.Text = "label1";
            TestLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TabControlImageList
            // 
            TabControlImageList.ColorDepth = ColorDepth.Depth32Bit;
            TabControlImageList.ImageStream = (ImageListStreamer)resources.GetObject("TabControlImageList.ImageStream");
            TabControlImageList.TransparentColor = Color.Transparent;
            TabControlImageList.Images.SetKeyName(0, "Icojam-Onebit-Stats.48.png");
            TabControlImageList.Images.SetKeyName(1, "Hopstarter-Sleek-Xp-Basic-Zoom.48.png");
            // 
            // label1
            // 
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 44);
            label1.Margin = new Padding(0, 0, 5, 3);
            label1.Name = "label1";
            label1.Size = new Size(238, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(248, 44);
            label2.Margin = new Padding(0, 0, 0, 3);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 3;
            label2.Text = "label1";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 70, 70);
            ClientSize = new Size(841, 495);
            Controls.Add(DatabaseTabControl);
            Controls.Add(Header);
            Controls.Add(AddModelBtn);
            Controls.Add(AddMakerBtn);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Database";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            DatabaseTabControl.ResumeLayout(false);
            FindCarPage.ResumeLayout(false);
            FindCarPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CarDatabaseGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)carListBindingSource).EndInit();
            StatsPage.ResumeLayout(false);
            CountriesWithMostMakersGroupbox.ResumeLayout(false);
            MakersWithMostModelsGroupbox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button AddMakerBtn;
        private Button AddModelBtn;
        private Label Header;
        private TabControl DatabaseTabControl;
        private TabPage FindCarPage;
        private TabPage StatsPage;
        private ImageList TabControlImageList;
        private DataGridView CarDatabaseGridView;
        private TextBox SearchBox;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn makerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productionYearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private BindingSource carListBindingSource;
        private GroupBox MakersWithMostModelsGroupbox;
        private GroupBox CountriesWithMostMakersGroupbox;
        private Label TestLabel2;
        private Label TestLabel1;
        private Label TestLabel4;
        private Label TestLabel3;
        private Label label2;
        private Label label1;
    }
}
