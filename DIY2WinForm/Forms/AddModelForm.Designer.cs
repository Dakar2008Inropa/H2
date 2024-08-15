namespace DIY2WinForm.Forms
{
    partial class AddModelForm
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
            ModelLabel = new Label();
            ModelTextbox = new TextBox();
            MakerLabel = new Label();
            MakerComboBox = new ComboBox();
            ProductionYearLabel = new Label();
            ProductionYearUpDown = new NumericUpDown();
            ColorLabel = new Label();
            colorDialog1 = new ColorDialog();
            ColorBox = new PictureBox();
            AddModelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductionYearUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColorBox).BeginInit();
            SuspendLayout();
            // 
            // ModelLabel
            // 
            ModelLabel.ForeColor = Color.White;
            ModelLabel.Location = new Point(5, 57);
            ModelLabel.Margin = new Padding(0, 0, 0, 3);
            ModelLabel.Name = "ModelLabel";
            ModelLabel.Size = new Size(544, 22);
            ModelLabel.TabIndex = 4;
            ModelLabel.Text = "Model:";
            ModelLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ModelTextbox
            // 
            ModelTextbox.BackColor = Color.White;
            ModelTextbox.BorderStyle = BorderStyle.FixedSingle;
            ModelTextbox.Location = new Point(5, 82);
            ModelTextbox.Margin = new Padding(0, 0, 0, 3);
            ModelTextbox.Name = "ModelTextbox";
            ModelTextbox.Size = new Size(544, 23);
            ModelTextbox.TabIndex = 3;
            ModelTextbox.TextAlign = HorizontalAlignment.Center;
            // 
            // MakerLabel
            // 
            MakerLabel.ForeColor = Color.White;
            MakerLabel.Location = new Point(5, 5);
            MakerLabel.Margin = new Padding(0, 0, 0, 3);
            MakerLabel.Name = "MakerLabel";
            MakerLabel.Size = new Size(544, 22);
            MakerLabel.TabIndex = 6;
            MakerLabel.Text = "Select Maker:";
            MakerLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MakerComboBox
            // 
            MakerComboBox.DropDownHeight = 100;
            MakerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MakerComboBox.FormattingEnabled = true;
            MakerComboBox.IntegralHeight = false;
            MakerComboBox.Location = new Point(5, 30);
            MakerComboBox.Margin = new Padding(0, 0, 0, 3);
            MakerComboBox.Name = "MakerComboBox";
            MakerComboBox.Size = new Size(544, 24);
            MakerComboBox.TabIndex = 5;
            // 
            // ProductionYearLabel
            // 
            ProductionYearLabel.ForeColor = Color.White;
            ProductionYearLabel.Location = new Point(5, 108);
            ProductionYearLabel.Margin = new Padding(0, 0, 0, 3);
            ProductionYearLabel.Name = "ProductionYearLabel";
            ProductionYearLabel.Size = new Size(544, 22);
            ProductionYearLabel.TabIndex = 8;
            ProductionYearLabel.Text = "Production Year:";
            ProductionYearLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProductionYearUpDown
            // 
            ProductionYearUpDown.BorderStyle = BorderStyle.FixedSingle;
            ProductionYearUpDown.Location = new Point(5, 133);
            ProductionYearUpDown.Margin = new Padding(0, 0, 0, 3);
            ProductionYearUpDown.Maximum = new decimal(new int[] { 2035, 0, 0, 0 });
            ProductionYearUpDown.Minimum = new decimal(new int[] { 1860, 0, 0, 0 });
            ProductionYearUpDown.Name = "ProductionYearUpDown";
            ProductionYearUpDown.Size = new Size(544, 23);
            ProductionYearUpDown.TabIndex = 9;
            ProductionYearUpDown.TextAlign = HorizontalAlignment.Center;
            ProductionYearUpDown.Value = new decimal(new int[] { 1990, 0, 0, 0 });
            // 
            // ColorLabel
            // 
            ColorLabel.ForeColor = Color.White;
            ColorLabel.Location = new Point(5, 159);
            ColorLabel.Margin = new Padding(0, 0, 0, 3);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(544, 22);
            ColorLabel.TabIndex = 10;
            ColorLabel.Text = "Double-Click To Select Color:";
            ColorLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // colorDialog1
            // 
            colorDialog1.AnyColor = true;
            colorDialog1.Color = Color.White;
            colorDialog1.FullOpen = true;
            // 
            // ColorBox
            // 
            ColorBox.BorderStyle = BorderStyle.FixedSingle;
            ColorBox.Cursor = Cursors.Hand;
            ColorBox.Location = new Point(5, 184);
            ColorBox.Margin = new Padding(0, 0, 0, 5);
            ColorBox.Name = "ColorBox";
            ColorBox.Size = new Size(544, 30);
            ColorBox.TabIndex = 11;
            ColorBox.TabStop = false;
            ColorBox.DoubleClick += ColorBox_DoubleClick;
            // 
            // AddModelBtn
            // 
            AddModelBtn.BackColor = Color.MediumBlue;
            AddModelBtn.FlatAppearance.BorderColor = Color.White;
            AddModelBtn.FlatStyle = FlatStyle.Flat;
            AddModelBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddModelBtn.ForeColor = Color.White;
            AddModelBtn.Location = new Point(5, 219);
            AddModelBtn.Margin = new Padding(0);
            AddModelBtn.Name = "AddModelBtn";
            AddModelBtn.Size = new Size(544, 32);
            AddModelBtn.TabIndex = 12;
            AddModelBtn.Text = "Add Model";
            AddModelBtn.UseVisualStyleBackColor = false;
            AddModelBtn.Click += AddModelBtn_Click;
            // 
            // AddModelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 70, 70);
            ClientSize = new Size(554, 257);
            Controls.Add(AddModelBtn);
            Controls.Add(ColorBox);
            Controls.Add(ColorLabel);
            Controls.Add(ProductionYearUpDown);
            Controls.Add(ProductionYearLabel);
            Controls.Add(MakerLabel);
            Controls.Add(MakerComboBox);
            Controls.Add(ModelLabel);
            Controls.Add(ModelTextbox);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddModelForm";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Model";
            Load += AddModelForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProductionYearUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColorBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ModelLabel;
        private TextBox ModelTextbox;
        private Label MakerLabel;
        private ComboBox MakerComboBox;
        private Label ProductionYearLabel;
        private NumericUpDown ProductionYearUpDown;
        private Label ColorLabel;
        private ColorDialog colorDialog1;
        private PictureBox ColorBox;
        private Button AddModelBtn;
    }
}