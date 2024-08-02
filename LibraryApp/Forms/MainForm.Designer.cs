namespace LibraryApp
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
            LibraryTabControl = new TabControl();
            BookPage = new TabPage();
            SearchForBookTextbox = new MaskedTextBox();
            SearchBookLabel = new Label();
            DeleteBookBtn = new Button();
            BooksDataGridView = new DataGridView();
            iSBNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isAvailableDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            bookBindingSource = new BindingSource(components);
            AddNewBookBtn = new Button();
            UserPage = new TabPage();
            SearchForUserByIdTextbox = new TextBox();
            SearchForUserByIdLabel = new Label();
            DeleteUserBtn = new Button();
            UserDataGridView = new DataGridView();
            userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loanLimitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            AddUserBtn = new Button();
            PremiumUserPage = new TabPage();
            SearchForPremiumUserTextbox = new TextBox();
            PremiumUserLabel = new Label();
            DeletePremiumUserBtn = new Button();
            PremiumUserDataGridView = new DataGridView();
            userIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            loanLimitDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            premiumUserBindingSource = new BindingSource(components);
            AddPremiumUserBtn = new Button();
            Headline = new Label();
            LibraryTabControl.SuspendLayout();
            BookPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BooksDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            UserPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            PremiumUserPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PremiumUserDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)premiumUserBindingSource).BeginInit();
            SuspendLayout();
            // 
            // LibraryTabControl
            // 
            LibraryTabControl.Controls.Add(BookPage);
            LibraryTabControl.Controls.Add(UserPage);
            LibraryTabControl.Controls.Add(PremiumUserPage);
            LibraryTabControl.Location = new Point(5, 59);
            LibraryTabControl.Margin = new Padding(0);
            LibraryTabControl.Name = "LibraryTabControl";
            LibraryTabControl.SelectedIndex = 0;
            LibraryTabControl.Size = new Size(904, 416);
            LibraryTabControl.TabIndex = 0;
            // 
            // BookPage
            // 
            BookPage.Controls.Add(SearchForBookTextbox);
            BookPage.Controls.Add(SearchBookLabel);
            BookPage.Controls.Add(DeleteBookBtn);
            BookPage.Controls.Add(BooksDataGridView);
            BookPage.Controls.Add(AddNewBookBtn);
            BookPage.Location = new Point(4, 25);
            BookPage.Margin = new Padding(0);
            BookPage.Name = "BookPage";
            BookPage.Padding = new Padding(5);
            BookPage.Size = new Size(896, 387);
            BookPage.TabIndex = 0;
            BookPage.Text = "Books";
            BookPage.UseVisualStyleBackColor = true;
            // 
            // SearchForBookTextbox
            // 
            SearchForBookTextbox.BackColor = Color.WhiteSmoke;
            SearchForBookTextbox.BorderStyle = BorderStyle.FixedSingle;
            SearchForBookTextbox.Location = new Point(616, 11);
            SearchForBookTextbox.Margin = new Padding(0);
            SearchForBookTextbox.Mask = "000-0-000-00000-0";
            SearchForBookTextbox.Name = "SearchForBookTextbox";
            SearchForBookTextbox.PromptChar = ' ';
            SearchForBookTextbox.Size = new Size(275, 23);
            SearchForBookTextbox.TabIndex = 4;
            SearchForBookTextbox.TextAlign = HorizontalAlignment.Center;
            SearchForBookTextbox.KeyDown += SearchForBookTextbox_KeyDown;
            // 
            // SearchBookLabel
            // 
            SearchBookLabel.Location = new Point(435, 11);
            SearchBookLabel.Margin = new Padding(0, 0, 3, 10);
            SearchBookLabel.Name = "SearchBookLabel";
            SearchBookLabel.Size = new Size(178, 23);
            SearchBookLabel.TabIndex = 3;
            SearchBookLabel.Text = "Search For Book By ISBN:";
            SearchBookLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DeleteBookBtn
            // 
            DeleteBookBtn.BackColor = Color.DarkRed;
            DeleteBookBtn.Cursor = Cursors.Hand;
            DeleteBookBtn.FlatAppearance.BorderColor = Color.Black;
            DeleteBookBtn.FlatStyle = FlatStyle.Flat;
            DeleteBookBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBookBtn.ForeColor = Color.White;
            DeleteBookBtn.Location = new Point(162, 5);
            DeleteBookBtn.Margin = new Padding(0, 0, 0, 10);
            DeleteBookBtn.Name = "DeleteBookBtn";
            DeleteBookBtn.Size = new Size(152, 33);
            DeleteBookBtn.TabIndex = 2;
            DeleteBookBtn.Text = "Delete Book";
            DeleteBookBtn.UseVisualStyleBackColor = false;
            DeleteBookBtn.Visible = false;
            DeleteBookBtn.Click += DeleteBookBtn_Click;
            // 
            // BooksDataGridView
            // 
            BooksDataGridView.AllowUserToAddRows = false;
            BooksDataGridView.AllowUserToDeleteRows = false;
            BooksDataGridView.AllowUserToResizeRows = false;
            BooksDataGridView.AutoGenerateColumns = false;
            BooksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BooksDataGridView.Columns.AddRange(new DataGridViewColumn[] { iSBNDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, authorDataGridViewTextBoxColumn, isAvailableDataGridViewCheckBoxColumn });
            BooksDataGridView.DataSource = bookBindingSource;
            BooksDataGridView.Dock = DockStyle.Bottom;
            BooksDataGridView.Location = new Point(5, 48);
            BooksDataGridView.Margin = new Padding(0);
            BooksDataGridView.MultiSelect = false;
            BooksDataGridView.Name = "BooksDataGridView";
            BooksDataGridView.ReadOnly = true;
            BooksDataGridView.RowHeadersVisible = false;
            BooksDataGridView.RowTemplate.Height = 25;
            BooksDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BooksDataGridView.Size = new Size(886, 334);
            BooksDataGridView.TabIndex = 1;
            BooksDataGridView.TabStop = false;
            BooksDataGridView.SelectionChanged += BooksDataGridView_SelectionChanged;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            iSBNDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            authorDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            authorDataGridViewTextBoxColumn.HeaderText = "Author";
            authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isAvailableDataGridViewCheckBoxColumn
            // 
            isAvailableDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            isAvailableDataGridViewCheckBoxColumn.DataPropertyName = "IsAvailable";
            isAvailableDataGridViewCheckBoxColumn.HeaderText = "Is Available";
            isAvailableDataGridViewCheckBoxColumn.Name = "isAvailableDataGridViewCheckBoxColumn";
            isAvailableDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Classes.Book);
            // 
            // AddNewBookBtn
            // 
            AddNewBookBtn.BackColor = Color.ForestGreen;
            AddNewBookBtn.Cursor = Cursors.Hand;
            AddNewBookBtn.FlatAppearance.BorderColor = Color.Black;
            AddNewBookBtn.FlatStyle = FlatStyle.Flat;
            AddNewBookBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddNewBookBtn.ForeColor = Color.White;
            AddNewBookBtn.Location = new Point(5, 5);
            AddNewBookBtn.Margin = new Padding(0, 0, 5, 10);
            AddNewBookBtn.Name = "AddNewBookBtn";
            AddNewBookBtn.Size = new Size(152, 33);
            AddNewBookBtn.TabIndex = 0;
            AddNewBookBtn.Text = "Add New Book";
            AddNewBookBtn.UseVisualStyleBackColor = false;
            AddNewBookBtn.Click += AddNewBookBtn_Click;
            // 
            // UserPage
            // 
            UserPage.Controls.Add(SearchForUserByIdTextbox);
            UserPage.Controls.Add(SearchForUserByIdLabel);
            UserPage.Controls.Add(DeleteUserBtn);
            UserPage.Controls.Add(UserDataGridView);
            UserPage.Controls.Add(AddUserBtn);
            UserPage.Location = new Point(4, 24);
            UserPage.Margin = new Padding(0);
            UserPage.Name = "UserPage";
            UserPage.Padding = new Padding(5);
            UserPage.Size = new Size(896, 388);
            UserPage.TabIndex = 1;
            UserPage.Text = "Users";
            UserPage.UseVisualStyleBackColor = true;
            // 
            // SearchForUserByIdTextbox
            // 
            SearchForUserByIdTextbox.BackColor = Color.WhiteSmoke;
            SearchForUserByIdTextbox.BorderStyle = BorderStyle.FixedSingle;
            SearchForUserByIdTextbox.Location = new Point(616, 11);
            SearchForUserByIdTextbox.Margin = new Padding(0, 0, 0, 10);
            SearchForUserByIdTextbox.Name = "SearchForUserByIdTextbox";
            SearchForUserByIdTextbox.Size = new Size(275, 23);
            SearchForUserByIdTextbox.TabIndex = 9;
            SearchForUserByIdTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // SearchForUserByIdLabel
            // 
            SearchForUserByIdLabel.Location = new Point(454, 11);
            SearchForUserByIdLabel.Margin = new Padding(0, 0, 3, 10);
            SearchForUserByIdLabel.Name = "SearchForUserByIdLabel";
            SearchForUserByIdLabel.Size = new Size(159, 23);
            SearchForUserByIdLabel.TabIndex = 8;
            SearchForUserByIdLabel.Text = "Search For User By ID:";
            SearchForUserByIdLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DeleteUserBtn
            // 
            DeleteUserBtn.BackColor = Color.DarkRed;
            DeleteUserBtn.Cursor = Cursors.Hand;
            DeleteUserBtn.FlatAppearance.BorderColor = Color.Black;
            DeleteUserBtn.FlatStyle = FlatStyle.Flat;
            DeleteUserBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteUserBtn.ForeColor = Color.White;
            DeleteUserBtn.Location = new Point(162, 5);
            DeleteUserBtn.Margin = new Padding(0, 0, 0, 10);
            DeleteUserBtn.Name = "DeleteUserBtn";
            DeleteUserBtn.Size = new Size(152, 33);
            DeleteUserBtn.TabIndex = 7;
            DeleteUserBtn.Text = "Delete User";
            DeleteUserBtn.UseVisualStyleBackColor = false;
            DeleteUserBtn.Visible = false;
            DeleteUserBtn.Click += DeleteUserBtn_Click;
            // 
            // UserDataGridView
            // 
            UserDataGridView.AllowUserToAddRows = false;
            UserDataGridView.AllowUserToDeleteRows = false;
            UserDataGridView.AllowUserToResizeRows = false;
            UserDataGridView.AutoGenerateColumns = false;
            UserDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDataGridView.Columns.AddRange(new DataGridViewColumn[] { userIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, loanLimitDataGridViewTextBoxColumn });
            UserDataGridView.DataSource = userBindingSource;
            UserDataGridView.Dock = DockStyle.Bottom;
            UserDataGridView.Location = new Point(5, 49);
            UserDataGridView.Margin = new Padding(0);
            UserDataGridView.MultiSelect = false;
            UserDataGridView.Name = "UserDataGridView";
            UserDataGridView.ReadOnly = true;
            UserDataGridView.RowHeadersVisible = false;
            UserDataGridView.RowTemplate.Height = 25;
            UserDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UserDataGridView.Size = new Size(886, 334);
            UserDataGridView.TabIndex = 6;
            UserDataGridView.TabStop = false;
            UserDataGridView.CellDoubleClick += UserDataGridView_CellDoubleClick;
            UserDataGridView.SelectionChanged += UserDataGridView_SelectionChanged;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "Id";
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loanLimitDataGridViewTextBoxColumn
            // 
            loanLimitDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            loanLimitDataGridViewTextBoxColumn.DataPropertyName = "LoanLimit";
            loanLimitDataGridViewTextBoxColumn.HeaderText = "Loan Limit";
            loanLimitDataGridViewTextBoxColumn.Name = "loanLimitDataGridViewTextBoxColumn";
            loanLimitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Classes.User);
            // 
            // AddUserBtn
            // 
            AddUserBtn.BackColor = Color.FromArgb(34, 84, 151);
            AddUserBtn.Cursor = Cursors.Hand;
            AddUserBtn.FlatAppearance.BorderColor = Color.Black;
            AddUserBtn.FlatStyle = FlatStyle.Flat;
            AddUserBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddUserBtn.ForeColor = Color.White;
            AddUserBtn.Location = new Point(5, 5);
            AddUserBtn.Margin = new Padding(0, 0, 5, 10);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(152, 33);
            AddUserBtn.TabIndex = 5;
            AddUserBtn.Text = "Add New User";
            AddUserBtn.UseVisualStyleBackColor = false;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // PremiumUserPage
            // 
            PremiumUserPage.Controls.Add(SearchForPremiumUserTextbox);
            PremiumUserPage.Controls.Add(PremiumUserLabel);
            PremiumUserPage.Controls.Add(DeletePremiumUserBtn);
            PremiumUserPage.Controls.Add(PremiumUserDataGridView);
            PremiumUserPage.Controls.Add(AddPremiumUserBtn);
            PremiumUserPage.Location = new Point(4, 25);
            PremiumUserPage.Margin = new Padding(0);
            PremiumUserPage.Name = "PremiumUserPage";
            PremiumUserPage.Padding = new Padding(5);
            PremiumUserPage.Size = new Size(896, 387);
            PremiumUserPage.TabIndex = 2;
            PremiumUserPage.Text = "Premium Users";
            PremiumUserPage.UseVisualStyleBackColor = true;
            // 
            // SearchForPremiumUserTextbox
            // 
            SearchForPremiumUserTextbox.BackColor = Color.WhiteSmoke;
            SearchForPremiumUserTextbox.BorderStyle = BorderStyle.FixedSingle;
            SearchForPremiumUserTextbox.Location = new Point(616, 11);
            SearchForPremiumUserTextbox.Margin = new Padding(0, 0, 0, 10);
            SearchForPremiumUserTextbox.Name = "SearchForPremiumUserTextbox";
            SearchForPremiumUserTextbox.Size = new Size(275, 23);
            SearchForPremiumUserTextbox.TabIndex = 9;
            SearchForPremiumUserTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // PremiumUserLabel
            // 
            PremiumUserLabel.Location = new Point(395, 11);
            PremiumUserLabel.Margin = new Padding(0, 0, 3, 10);
            PremiumUserLabel.Name = "PremiumUserLabel";
            PremiumUserLabel.Size = new Size(218, 23);
            PremiumUserLabel.TabIndex = 8;
            PremiumUserLabel.Text = "Search For Premium User By ID:";
            PremiumUserLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DeletePremiumUserBtn
            // 
            DeletePremiumUserBtn.BackColor = Color.DarkRed;
            DeletePremiumUserBtn.Cursor = Cursors.Hand;
            DeletePremiumUserBtn.FlatAppearance.BorderColor = Color.Black;
            DeletePremiumUserBtn.FlatStyle = FlatStyle.Flat;
            DeletePremiumUserBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DeletePremiumUserBtn.ForeColor = Color.White;
            DeletePremiumUserBtn.Location = new Point(203, 5);
            DeletePremiumUserBtn.Margin = new Padding(0, 0, 0, 10);
            DeletePremiumUserBtn.Name = "DeletePremiumUserBtn";
            DeletePremiumUserBtn.Size = new Size(178, 33);
            DeletePremiumUserBtn.TabIndex = 7;
            DeletePremiumUserBtn.Text = "Delete Premium User";
            DeletePremiumUserBtn.UseVisualStyleBackColor = false;
            DeletePremiumUserBtn.Visible = false;
            DeletePremiumUserBtn.Click += DeletePremiumUserBtn_Click;
            // 
            // PremiumUserDataGridView
            // 
            PremiumUserDataGridView.AllowUserToAddRows = false;
            PremiumUserDataGridView.AllowUserToDeleteRows = false;
            PremiumUserDataGridView.AllowUserToResizeRows = false;
            PremiumUserDataGridView.AutoGenerateColumns = false;
            PremiumUserDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PremiumUserDataGridView.Columns.AddRange(new DataGridViewColumn[] { userIdDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1, loanLimitDataGridViewTextBoxColumn1 });
            PremiumUserDataGridView.DataSource = premiumUserBindingSource;
            PremiumUserDataGridView.Dock = DockStyle.Bottom;
            PremiumUserDataGridView.Location = new Point(5, 48);
            PremiumUserDataGridView.Margin = new Padding(0);
            PremiumUserDataGridView.MultiSelect = false;
            PremiumUserDataGridView.Name = "PremiumUserDataGridView";
            PremiumUserDataGridView.ReadOnly = true;
            PremiumUserDataGridView.RowHeadersVisible = false;
            PremiumUserDataGridView.RowTemplate.Height = 25;
            PremiumUserDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PremiumUserDataGridView.Size = new Size(886, 334);
            PremiumUserDataGridView.TabIndex = 6;
            PremiumUserDataGridView.TabStop = false;
            PremiumUserDataGridView.CellDoubleClick += PremiumUserDataGridView_CellDoubleClick;
            PremiumUserDataGridView.SelectionChanged += PremiumUserDataGridView_SelectionChanged;
            // 
            // userIdDataGridViewTextBoxColumn1
            // 
            userIdDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            userIdDataGridViewTextBoxColumn1.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn1.HeaderText = "Id";
            userIdDataGridViewTextBoxColumn1.Name = "userIdDataGridViewTextBoxColumn1";
            userIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // loanLimitDataGridViewTextBoxColumn1
            // 
            loanLimitDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            loanLimitDataGridViewTextBoxColumn1.DataPropertyName = "LoanLimit";
            loanLimitDataGridViewTextBoxColumn1.HeaderText = "Loan Limit";
            loanLimitDataGridViewTextBoxColumn1.Name = "loanLimitDataGridViewTextBoxColumn1";
            loanLimitDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // premiumUserBindingSource
            // 
            premiumUserBindingSource.DataSource = typeof(Classes.PremiumUser);
            // 
            // AddPremiumUserBtn
            // 
            AddPremiumUserBtn.BackColor = Color.FromArgb(34, 84, 151);
            AddPremiumUserBtn.Cursor = Cursors.Hand;
            AddPremiumUserBtn.FlatAppearance.BorderColor = Color.Black;
            AddPremiumUserBtn.FlatStyle = FlatStyle.Flat;
            AddPremiumUserBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddPremiumUserBtn.ForeColor = Color.White;
            AddPremiumUserBtn.Location = new Point(5, 5);
            AddPremiumUserBtn.Margin = new Padding(0, 0, 5, 10);
            AddPremiumUserBtn.Name = "AddPremiumUserBtn";
            AddPremiumUserBtn.Size = new Size(193, 33);
            AddPremiumUserBtn.TabIndex = 5;
            AddPremiumUserBtn.Text = "Add New Premium User";
            AddPremiumUserBtn.UseVisualStyleBackColor = false;
            AddPremiumUserBtn.Click += AddPremiumUserBtn_Click;
            // 
            // Headline
            // 
            Headline.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Headline.ForeColor = Color.White;
            Headline.Location = new Point(5, 5);
            Headline.Margin = new Padding(0, 0, 0, 10);
            Headline.Name = "Headline";
            Headline.Size = new Size(904, 44);
            Headline.TabIndex = 1;
            Headline.Text = "Library Management System";
            Headline.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 77, 91);
            ClientSize = new Size(914, 480);
            Controls.Add(Headline);
            Controls.Add(LibraryTabControl);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library APP";
            Load += MainForm_Load;
            LibraryTabControl.ResumeLayout(false);
            BookPage.ResumeLayout(false);
            BookPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BooksDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            UserPage.ResumeLayout(false);
            UserPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            PremiumUserPage.ResumeLayout(false);
            PremiumUserPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PremiumUserDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)premiumUserBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl LibraryTabControl;
        private TabPage BookPage;
        private TabPage UserPage;
        private TabPage PremiumUserPage;
        private Label Headline;
        private Button AddNewBookBtn;
        private DataGridView BooksDataGridView;
        private BindingSource bookBindingSource;
        private Button DeleteBookBtn;
        private Label SearchBookLabel;
        private TextBox SearchForUserByIdTextbox;
        private Label SearchForUserByIdLabel;
        private Button DeleteUserBtn;
        private DataGridView UserDataGridView;
        private Button AddUserBtn;
        private TextBox SearchForPremiumUserTextbox;
        private Label PremiumUserLabel;
        private Button DeletePremiumUserBtn;
        private DataGridView PremiumUserDataGridView;
        private Button AddPremiumUserBtn;
        private BindingSource userBindingSource;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loanLimitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn loanLimitDataGridViewTextBoxColumn1;
        private BindingSource premiumUserBindingSource;
        private DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isAvailableDataGridViewCheckBoxColumn;
        private MaskedTextBox SearchForBookTextbox;
    }
}
