namespace LibraryApp.Forms
{
    partial class ViewUserForm
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
            components = new System.ComponentModel.Container();
            UserNameLabel = new Label();
            ViewUserTabControl = new TabControl();
            LoanBookPage = new TabPage();
            LoanBookDataGridView = new DataGridView();
            iSBNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loanBookBindingSource = new BindingSource(components);
            ReturnBookPage = new TabPage();
            ReturnBookDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            returnBookBindingResource = new BindingSource(components);
            ViewUserTabControl.SuspendLayout();
            LoanBookPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoanBookDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loanBookBindingSource).BeginInit();
            ReturnBookPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReturnBookDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)returnBookBindingResource).BeginInit();
            SuspendLayout();
            // 
            // UserNameLabel
            // 
            UserNameLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameLabel.ForeColor = Color.White;
            UserNameLabel.Location = new Point(5, 5);
            UserNameLabel.Margin = new Padding(0, 0, 0, 5);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(704, 44);
            UserNameLabel.TabIndex = 0;
            UserNameLabel.Text = "UserName";
            UserNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ViewUserTabControl
            // 
            ViewUserTabControl.Controls.Add(LoanBookPage);
            ViewUserTabControl.Controls.Add(ReturnBookPage);
            ViewUserTabControl.Location = new Point(5, 54);
            ViewUserTabControl.Margin = new Padding(0);
            ViewUserTabControl.Name = "ViewUserTabControl";
            ViewUserTabControl.SelectedIndex = 0;
            ViewUserTabControl.Size = new Size(704, 319);
            ViewUserTabControl.TabIndex = 1;
            // 
            // LoanBookPage
            // 
            LoanBookPage.Controls.Add(LoanBookDataGridView);
            LoanBookPage.Location = new Point(4, 25);
            LoanBookPage.Margin = new Padding(0);
            LoanBookPage.Name = "LoanBookPage";
            LoanBookPage.Padding = new Padding(5);
            LoanBookPage.Size = new Size(696, 290);
            LoanBookPage.TabIndex = 0;
            LoanBookPage.Text = "Loan";
            LoanBookPage.UseVisualStyleBackColor = true;
            // 
            // LoanBookDataGridView
            // 
            LoanBookDataGridView.AllowUserToAddRows = false;
            LoanBookDataGridView.AllowUserToDeleteRows = false;
            LoanBookDataGridView.AllowUserToResizeRows = false;
            LoanBookDataGridView.AutoGenerateColumns = false;
            LoanBookDataGridView.BorderStyle = BorderStyle.None;
            LoanBookDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LoanBookDataGridView.Columns.AddRange(new DataGridViewColumn[] { iSBNDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, authorDataGridViewTextBoxColumn });
            LoanBookDataGridView.DataSource = loanBookBindingSource;
            LoanBookDataGridView.Dock = DockStyle.Fill;
            LoanBookDataGridView.Location = new Point(5, 5);
            LoanBookDataGridView.Name = "LoanBookDataGridView";
            LoanBookDataGridView.ReadOnly = true;
            LoanBookDataGridView.RowHeadersVisible = false;
            LoanBookDataGridView.RowTemplate.Height = 25;
            LoanBookDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoanBookDataGridView.Size = new Size(686, 280);
            LoanBookDataGridView.TabIndex = 0;
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
            // loanBookBindingSource
            // 
            loanBookBindingSource.DataSource = typeof(Classes.Book);
            // 
            // ReturnBookPage
            // 
            ReturnBookPage.Controls.Add(ReturnBookDataGridView);
            ReturnBookPage.Location = new Point(4, 24);
            ReturnBookPage.Margin = new Padding(0);
            ReturnBookPage.Name = "ReturnBookPage";
            ReturnBookPage.Padding = new Padding(5);
            ReturnBookPage.Size = new Size(696, 291);
            ReturnBookPage.TabIndex = 1;
            ReturnBookPage.Text = "Return";
            ReturnBookPage.UseVisualStyleBackColor = true;
            // 
            // ReturnBookDataGridView
            // 
            ReturnBookDataGridView.AllowUserToAddRows = false;
            ReturnBookDataGridView.AllowUserToDeleteRows = false;
            ReturnBookDataGridView.AllowUserToResizeRows = false;
            ReturnBookDataGridView.AutoGenerateColumns = false;
            ReturnBookDataGridView.BorderStyle = BorderStyle.None;
            ReturnBookDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReturnBookDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            ReturnBookDataGridView.DataSource = returnBookBindingResource;
            ReturnBookDataGridView.Dock = DockStyle.Fill;
            ReturnBookDataGridView.Location = new Point(5, 5);
            ReturnBookDataGridView.Name = "ReturnBookDataGridView";
            ReturnBookDataGridView.ReadOnly = true;
            ReturnBookDataGridView.RowHeadersVisible = false;
            ReturnBookDataGridView.RowTemplate.Height = 25;
            ReturnBookDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReturnBookDataGridView.Size = new Size(686, 281);
            ReturnBookDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "ISBN";
            dataGridViewTextBoxColumn1.HeaderText = "ISBN";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            dataGridViewTextBoxColumn2.HeaderText = "Title";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            dataGridViewTextBoxColumn3.HeaderText = "Author";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // returnBookBindingResource
            // 
            returnBookBindingResource.DataSource = typeof(Classes.Book);
            // 
            // ViewUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 77, 91);
            ClientSize = new Size(714, 378);
            Controls.Add(ViewUserTabControl);
            Controls.Add(UserNameLabel);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ViewUserForm";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterParent;
            Text = "View User";
            Load += ViewUserForm_Load;
            ViewUserTabControl.ResumeLayout(false);
            LoanBookPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LoanBookDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)loanBookBindingSource).EndInit();
            ReturnBookPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ReturnBookDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)returnBookBindingResource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label UserNameLabel;
        private TabControl ViewUserTabControl;
        private TabPage LoanBookPage;
        private TabPage ReturnBookPage;
        private DataGridView LoanBookDataGridView;
        private DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private BindingSource loanBookBindingSource;
        private DataGridView ReturnBookDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private BindingSource returnBookBindingResource;
    }
}