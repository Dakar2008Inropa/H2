using LibraryApp.Classes;
using LibraryApp.Forms;

namespace LibraryApp
{
    public partial class MainForm : Form
    {
        private Library _library;

        public MainForm()
        {
            _library = new Library();
            InitializeComponent();
        }

        private void AddNewBookBtn_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            if (addBookForm.ShowDialog() == DialogResult.OK)
            {
                _library.AddBook(addBookForm.book);
                ReloadGridviews();

                BooksDataGridView.ClearSelection();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bookBindingSource.DataSource = _library.DisplayAllBooks();
            userBindingSource.DataSource = _library.DisplayAllUsers();
            premiumUserBindingSource.DataSource = _library.DisplayAllPremiumUsers();

            BooksDataGridView.DataSource = bookBindingSource;
            UserDataGridView.DataSource = userBindingSource;
            PremiumUserDataGridView.DataSource = premiumUserBindingSource;
        }

        private void ReloadGridviews()
        {
            bookBindingSource.ResetBindings(false);
            userBindingSource.ResetBindings(false);
            premiumUserBindingSource.ResetBindings(false);
        }

        private void SearchForBookTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!SearchForBookTextbox.Text.Any(char.IsDigit))
                    bookBindingSource.DataSource = _library.DisplayAllBooks();
                else
                    bookBindingSource.DataSource = _library.DisplayAllBooks(SearchForBookTextbox.Text);
                ReloadGridviews();
            }
        }

        private void BooksDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (BooksDataGridView.SelectedRows.Count > 0)
                DeleteBookBtn.Visible = true;
            else
                DeleteBookBtn.Visible = false;
        }

        private void DeleteBookBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in BooksDataGridView.SelectedRows)
            {
                Book book = (Book)row.DataBoundItem;
                _library.RemoveBook(book);
            }
            ReloadGridviews();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            if (addUserForm.ShowDialog() == DialogResult.OK)
            {
                _library.RegisterUser(addUserForm.user);
                ReloadGridviews();

                UserDataGridView.ClearSelection();
            }
        }

        private void AddPremiumUserBtn_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm(true);
            if (addUserForm.ShowDialog() == DialogResult.OK)
            {
                _library.RegisterPremiumUser(addUserForm.premiumUser);
                ReloadGridviews();

                PremiumUserDataGridView.ClearSelection();
            }
        }

        private void UserDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (UserDataGridView.SelectedRows.Count > 0)
                DeleteUserBtn.Visible = true;
            else
                DeleteUserBtn.Visible = false;
        }

        private void PremiumUserDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (PremiumUserDataGridView.SelectedRows.Count > 0)
                DeletePremiumUserBtn.Visible = true;
            else
                DeletePremiumUserBtn.Visible = false;
        }

        private void DeletePremiumUserBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in PremiumUserDataGridView.SelectedRows)
            {
                PremiumUser premiumUser = (PremiumUser)row.DataBoundItem;
                _library.UnregisterPremiumUser(premiumUser);
            }
            ReloadGridviews();
        }

        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in UserDataGridView.SelectedRows)
            {
                User user = (User)row.DataBoundItem;
                _library.UnregisterUser(user);
            }
            ReloadGridviews();
        }

        private void UserDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UserDataGridView.SelectedRows.Count > 0)
            {
                User user = (User)UserDataGridView.SelectedRows[0].DataBoundItem;
                ViewUserForm viewUserForm = new ViewUserForm(_library, user.UserId);
                viewUserForm.ShowDialog();
            }
        }

        private void PremiumUserDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PremiumUserDataGridView.SelectedRows.Count > 0)
            {
                PremiumUser premiumUser = (PremiumUser)PremiumUserDataGridView.SelectedRows[0].DataBoundItem;
                ViewUserForm viewUserForm = new ViewUserForm(_library, premiumUser.UserId, true);
                viewUserForm.ShowDialog();
            }
        }
    }
}