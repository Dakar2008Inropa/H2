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
    }
}