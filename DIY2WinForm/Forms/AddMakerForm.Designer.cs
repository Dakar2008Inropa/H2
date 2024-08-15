namespace DIY2WinForm.Forms
{
    partial class AddMakerForm
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
            CountryCombobox = new ComboBox();
            NameLabel = new Label();
            CountryLabel = new Label();
            AddMakerBtn = new Button();
            SuspendLayout();
            // 
            // NameTextbox
            // 
            NameTextbox.BackColor = Color.White;
            NameTextbox.BorderStyle = BorderStyle.FixedSingle;
            NameTextbox.Location = new Point(5, 30);
            NameTextbox.Margin = new Padding(0, 0, 0, 3);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.Size = new Size(589, 23);
            NameTextbox.TabIndex = 0;
            NameTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // CountryCombobox
            // 
            CountryCombobox.DropDownHeight = 100;
            CountryCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            CountryCombobox.FormattingEnabled = true;
            CountryCombobox.IntegralHeight = false;
            CountryCombobox.Location = new Point(5, 81);
            CountryCombobox.Margin = new Padding(0, 0, 0, 5);
            CountryCombobox.Name = "CountryCombobox";
            CountryCombobox.Size = new Size(589, 24);
            CountryCombobox.TabIndex = 1;
            // 
            // NameLabel
            // 
            NameLabel.ForeColor = Color.White;
            NameLabel.Location = new Point(5, 5);
            NameLabel.Margin = new Padding(0, 0, 0, 3);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(589, 22);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name:";
            NameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CountryLabel
            // 
            CountryLabel.ForeColor = Color.White;
            CountryLabel.Location = new Point(5, 56);
            CountryLabel.Margin = new Padding(0, 0, 0, 3);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(589, 22);
            CountryLabel.TabIndex = 3;
            CountryLabel.Text = "Country:";
            CountryLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddMakerBtn
            // 
            AddMakerBtn.BackColor = Color.MediumBlue;
            AddMakerBtn.FlatAppearance.BorderColor = Color.White;
            AddMakerBtn.FlatStyle = FlatStyle.Flat;
            AddMakerBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddMakerBtn.ForeColor = Color.White;
            AddMakerBtn.Location = new Point(5, 110);
            AddMakerBtn.Margin = new Padding(0);
            AddMakerBtn.Name = "AddMakerBtn";
            AddMakerBtn.Size = new Size(589, 32);
            AddMakerBtn.TabIndex = 4;
            AddMakerBtn.Text = "Add Maker";
            AddMakerBtn.UseVisualStyleBackColor = false;
            AddMakerBtn.Click += AddMakerBtn_Click;
            // 
            // AddMakerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 70, 70);
            ClientSize = new Size(599, 148);
            Controls.Add(AddMakerBtn);
            Controls.Add(CountryLabel);
            Controls.Add(NameLabel);
            Controls.Add(CountryCombobox);
            Controls.Add(NameTextbox);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddMakerForm";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Maker";
            Load += AddMakerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTextbox;
        private ComboBox CountryCombobox;
        private Label NameLabel;
        private Label CountryLabel;
        private Button AddMakerBtn;
    }
}