namespace LibraryApp.Forms
{
    partial class AddUserForm
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
            NameTextbox = new TextBox();
            NameLabel = new Label();
            AddUserBtn = new Button();
            SuspendLayout();
            // 
            // NameTextbox
            // 
            NameTextbox.BorderStyle = BorderStyle.FixedSingle;
            NameTextbox.Location = new Point(5, 31);
            NameTextbox.Margin = new Padding(0, 0, 0, 5);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.Size = new Size(477, 23);
            NameTextbox.TabIndex = 3;
            NameTextbox.TextAlign = HorizontalAlignment.Center;
            NameTextbox.TextChanged += NameTextbox_TextChanged;
            NameTextbox.KeyDown += NameTextbox_KeyDown;
            // 
            // NameLabel
            // 
            NameLabel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.ForeColor = SystemColors.Window;
            NameLabel.Location = new Point(5, 5);
            NameLabel.Margin = new Padding(0, 0, 0, 3);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(477, 23);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name:";
            NameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddUserBtn
            // 
            AddUserBtn.BackColor = Color.FromArgb(34, 84, 151);
            AddUserBtn.Enabled = false;
            AddUserBtn.FlatAppearance.BorderColor = Color.White;
            AddUserBtn.FlatStyle = FlatStyle.Flat;
            AddUserBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddUserBtn.Location = new Point(5, 59);
            AddUserBtn.Margin = new Padding(0);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(477, 37);
            AddUserBtn.TabIndex = 5;
            AddUserBtn.Text = "Add User";
            AddUserBtn.UseVisualStyleBackColor = false;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 77, 91);
            ClientSize = new Size(487, 101);
            Controls.Add(AddUserBtn);
            Controls.Add(NameTextbox);
            Controls.Add(NameLabel);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddUserForm";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTextbox;
        private Label NameLabel;
        private Button AddUserBtn;
    }
}