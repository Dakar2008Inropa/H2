using LibraryApp.Classes;

namespace LibraryApp.Forms
{
    public partial class AddBookForm : Form
    {
        private Library _libary;
        public Book book { get; set; }

        public AddBookForm()
        {
            _libary = new Library();
            book = new Book();
            InitializeComponent();
        }

        private void Textbox_TextChanged(object sender, EventArgs e)
        {
            if (TitleTextbox.TextLength > 0 && AuthorTextbox.TextLength > 0)
            {
                AddBookBtn.Enabled = true;
            }
            else
            {
                AddBookBtn.Enabled = false;
            }
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            book.ISBN = _libary.GenerateUniqueISBN();
            book.Title = TitleTextbox.Text;
            book.Author = AuthorTextbox.Text;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && AddBookBtn.Enabled)
            {
                AddBookBtn_Click(this, new EventArgs());
            }
        }
    }
}
