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
                if (SearchForBookTextbox.TextLength == 0)
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
    }
}