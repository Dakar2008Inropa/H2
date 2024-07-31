namespace LibraryApp.Forms
{
    partial class AddBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleLabel = new Label();
            TitleTextbox = new TextBox();
            AuthorTextbox = new TextBox();
            AuthorLabel = new Label();
            AddBookBtn = new Button();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.Location = new Point(5, 5);
            TitleLabel.Margin = new Padding(0, 0, 0, 3);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(465, 23);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Title:";
            TitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TitleTextbox
            // 
            TitleTextbox.BorderStyle = BorderStyle.FixedSingle;
            TitleTextbox.Location = new Point(5, 31);
            TitleTextbox.Margin = new Padding(0, 0, 0, 5);
            TitleTextbox.Name = "TitleTextbox";
            TitleTextbox.Size = new Size(465, 23);
            TitleTextbox.TabIndex = 1;
            TitleTextbox.TextAlign = HorizontalAlignment.Center;
            TitleTextbox.TextChanged += Textbox_TextChanged;
            TitleTextbox.KeyDown += Textbox_KeyDown;
            // 
            // AuthorTextbox
            // 
            AuthorTextbox.BorderStyle = BorderStyle.FixedSingle;
            AuthorTextbox.Location = new Point(5, 85);
            AuthorTextbox.Margin = new Padding(0, 0, 0, 5);
            AuthorTextbox.Name = "AuthorTextbox";
            AuthorTextbox.Size = new Size(465, 23);
            AuthorTextbox.TabIndex = 3;
            AuthorTextbox.TextAlign = HorizontalAlignment.Center;
            AuthorTextbox.TextChanged += Textbox_TextChanged;
            AuthorTextbox.KeyDown += Textbox_KeyDown;
            // 
            // AuthorLabel
            // 
            AuthorLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AuthorLabel.Location = new Point(5, 59);
            AuthorLabel.Margin = new Padding(0, 0, 0, 3);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(465, 23);
            AuthorLabel.TabIndex = 2;
            AuthorLabel.Text = "Author:";
            AuthorLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddBookBtn
            // 
            AddBookBtn.BackColor = Color.FromArgb(34, 84, 151);
            AddBookBtn.Enabled = false;
            AddBookBtn.FlatAppearance.BorderColor = Color.White;
            AddBookBtn.FlatStyle = FlatStyle.Flat;
            AddBookBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddBookBtn.Location = new Point(5, 113);
            AddBookBtn.Margin = new Padding(0);
            AddBookBtn.Name = "AddBookBtn";
            AddBookBtn.Size = new Size(465, 37);
            AddBookBtn.TabIndex = 4;
            AddBookBtn.Text = "Add Book";
            AddBookBtn.UseVisualStyleBackColor = false;
            AddBookBtn.Click += AddBookBtn_Click;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 77, 91);
            ClientSize = new Size(475, 155);
            Controls.Add(AddBookBtn);
            Controls.Add(AuthorTextbox);
            Controls.Add(AuthorLabel);
            Controls.Add(TitleTextbox);
            Controls.Add(TitleLabel);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddBookForm";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private TextBox TitleTextbox;
        private TextBox AuthorTextbox;
        private Label AuthorLabel;
        private Button AddBookBtn;
    }
}