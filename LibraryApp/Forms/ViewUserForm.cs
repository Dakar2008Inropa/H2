using LibraryApp.Classes;

namespace LibraryApp.Forms
{
    public partial class ViewUserForm : Form
    {
        public Library Lib { get; set; }
        private string UserId { get; set; }
        private bool IsPremiumUser { get; set; }
        private string DisplayUserName { get; set; }
        private User User { get; set; }

        public ViewUserForm(Library lib, string userId, bool isPremiumUser = false)
        {
            Lib = lib;
            UserId = userId;
            IsPremiumUser = isPremiumUser;
            InitializeComponent();

            if (IsPremiumUser)
            {
                User = Lib.DisplayAllPremiumUsers(UserId)[0];
            }
            else
            {
                User = Lib.DisplayAllUsers(UserId)[0];
            }
            DisplayUserName = User.Name;
            this.Text = $"Viewing {DisplayUserName}'s Profile";
            UserNameLabel.Text = DisplayUserName;
        }

        private void ViewUserForm_Load(object sender, EventArgs e)
        {
            loanBookBindingSource.DataSource = Lib.DisplayAvailableBooks();
            LoanBookDataGridView.DataSource = loanBookBindingSource;

            returnBookBindingResource.DataSource = User.BorrowedBooks;
            ReturnBookDataGridView.DataSource = returnBookBindingResource;
        }

        private void LoanBookDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (LoanBookDataGridView.SelectedRows.Count > 0 && !IsLoanLimitReached())
            {
                var selectedBook = (Book)LoanBookDataGridView.SelectedRows[0].DataBoundItem;
                User.BorrowBook(selectedBook);
                ReloadDataGridViews();
            }
            else
            {
                MessageBox.Show($"{User.Name} has reach the loan limit", "Loan Limit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReturnBookDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ReturnBookDataGridView.SelectedRows.Count > 0)
            {
                var selectedBook = (Book)ReturnBookDataGridView.SelectedRows[0].DataBoundItem;
                User.ReturnBook(selectedBook);
                ReloadDataGridViews();
            }
        }

        private bool IsLoanLimitReached()
        {
            return User.BorrowedBooks.Count >= User.LoanLimit;
        }

        private void ReloadDataGridViews()
        {
            loanBookBindingSource.DataSource = Lib.DisplayAvailableBooks();
            returnBookBindingResource.ResetBindings(false);
            loanBookBindingSource.ResetBindings(false);
        }
    }
}