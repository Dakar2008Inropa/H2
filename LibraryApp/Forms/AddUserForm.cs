using LibraryApp.Classes;

namespace LibraryApp.Forms
{
    public partial class AddUserForm : Form
    {
        public User user { get; set; }
        public PremiumUser premiumUser { get; set; }
        private bool IsPremiumUser { get; set; }

        public AddUserForm(bool isPremiumUser = false)
        {
            InitializeComponent();

            if (isPremiumUser)
            {
                IsPremiumUser = isPremiumUser;

                premiumUser = new PremiumUser();
                this.Text = "Add Premium User";
                AddUserBtn.Text = "Add Premium User";
            }
            else
            {
                user = new User();
            }
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextbox.TextLength > 0)
                AddUserBtn.Enabled = true;
            else
                AddUserBtn.Enabled = false;
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            if (IsPremiumUser)
            {
                premiumUser.Name = NameTextbox.Text;
            }
            else
            {
                user.Name = NameTextbox.Text;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void NameTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddUserBtn_Click(sender, e);
            }
        }
    }
}