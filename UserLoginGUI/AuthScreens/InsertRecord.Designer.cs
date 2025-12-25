namespace UserLoginGUI.AuthScreens
{
    partial class InsertRecord
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblInsertRecordHdrTxt = new Label();
            lblItemNameTxt = new Label();
            txtItemName = new TextBox();
            lblItemTypeTxt = new Label();
            comboItemType = new ComboBox();
            InsertBtn = new Button();
            lblItemPrice = new Label();
            txtItemPrice = new TextBox();
            lblTaxTxt = new Label();
            TaxCheckbox1 = new CheckBox();
            TaxCheckbox2 = new CheckBox();
            TaxCheckbox3 = new CheckBox();
            SuspendLayout();
            // 
            // lblInsertRecordHdrTxt
            // 
            lblInsertRecordHdrTxt.Dock = DockStyle.Top;
            lblInsertRecordHdrTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblInsertRecordHdrTxt.ImageAlign = ContentAlignment.TopCenter;
            lblInsertRecordHdrTxt.Location = new Point(0, 0);
            lblInsertRecordHdrTxt.Name = "lblInsertRecordHdrTxt";
            lblInsertRecordHdrTxt.Padding = new Padding(0, 8, 0, 0);
            lblInsertRecordHdrTxt.Size = new Size(990, 50);
            lblInsertRecordHdrTxt.TabIndex = 0;
            lblInsertRecordHdrTxt.Text = "Insert Records of Items";
            lblInsertRecordHdrTxt.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblItemNameTxt
            // 
            lblItemNameTxt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemNameTxt.Location = new Point(20, 68);
            lblItemNameTxt.Name = "lblItemNameTxt";
            lblItemNameTxt.Size = new Size(134, 30);
            lblItemNameTxt.TabIndex = 1;
            lblItemNameTxt.Text = "Item Name:";
            // 
            // txtItemName
            // 
            txtItemName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemName.Location = new Point(165, 68);
            txtItemName.MaxLength = 500;
            txtItemName.Name = "txtItemName";
            txtItemName.PlaceholderText = "Enter item name...";
            txtItemName.Size = new Size(383, 34);
            txtItemName.TabIndex = 2;
            // 
            // lblItemTypeTxt
            // 
            lblItemTypeTxt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemTypeTxt.Location = new Point(20, 113);
            lblItemTypeTxt.Name = "lblItemTypeTxt";
            lblItemTypeTxt.Size = new Size(134, 30);
            lblItemTypeTxt.TabIndex = 3;
            lblItemTypeTxt.Text = "Item Type:";
            // 
            // comboItemType
            // 
            comboItemType.DropDownHeight = 145;
            comboItemType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboItemType.DropDownWidth = 170;
            comboItemType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboItemType.FormattingEnabled = true;
            comboItemType.IntegralHeight = false;
            comboItemType.Location = new Point(165, 113);
            comboItemType.Name = "comboItemType";
            comboItemType.Size = new Size(230, 36);
            comboItemType.TabIndex = 4;
            // 
            // InsertBtn
            // 
            InsertBtn.BackColor = SystemColors.HotTrack;
            InsertBtn.Cursor = Cursors.Hand;
            InsertBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            InsertBtn.ForeColor = SystemColors.ButtonFace;
            InsertBtn.Location = new Point(420, 277);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(128, 49);
            InsertBtn.TabIndex = 3;
            InsertBtn.Text = "Submit";
            InsertBtn.UseVisualStyleBackColor = false;
            InsertBtn.Click += Submit_Event;
            // 
            // lblItemPrice
            // 
            lblItemPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItemPrice.Location = new Point(20, 160);
            lblItemPrice.Name = "lblItemPrice";
            lblItemPrice.Size = new Size(134, 30);
            lblItemPrice.TabIndex = 5;
            lblItemPrice.Text = "Item Price:";
            // 
            // txtItemPrice
            // 
            txtItemPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtItemPrice.Location = new Point(165, 160);
            txtItemPrice.MaxLength = 30;
            txtItemPrice.Name = "txtItemPrice";
            txtItemPrice.PlaceholderText = "Enter item price...";
            txtItemPrice.Size = new Size(383, 34);
            txtItemPrice.TabIndex = 6;
            // 
            // lblTaxTxt
            // 
            lblTaxTxt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTaxTxt.Location = new Point(20, 210);
            lblTaxTxt.Name = "lblTaxTxt";
            lblTaxTxt.Size = new Size(134, 30);
            lblTaxTxt.TabIndex = 7;
            lblTaxTxt.Text = "Tax Types:";
            // 
            // TaxCheckbox1
            // 
            TaxCheckbox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TaxCheckbox1.Location = new Point(165, 210);
            TaxCheckbox1.Name = "TaxCheckbox1";
            TaxCheckbox1.Size = new Size(90, 30);
            TaxCheckbox1.TabIndex = 8;
            TaxCheckbox1.Text = "CGST";
            TaxCheckbox1.UseVisualStyleBackColor = true;
            // 
            // TaxCheckbox2
            // 
            TaxCheckbox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TaxCheckbox2.Location = new Point(263, 210);
            TaxCheckbox2.Name = "TaxCheckbox2";
            TaxCheckbox2.Size = new Size(87, 30);
            TaxCheckbox2.TabIndex = 9;
            TaxCheckbox2.Text = "SGST";
            TaxCheckbox2.UseVisualStyleBackColor = true;
            // 
            // TaxCheckbox3
            // 
            TaxCheckbox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TaxCheckbox3.Location = new Point(355, 210);
            TaxCheckbox3.Name = "TaxCheckbox3";
            TaxCheckbox3.Size = new Size(80, 30);
            TaxCheckbox3.TabIndex = 10;
            TaxCheckbox3.Text = "IGST";
            TaxCheckbox3.UseVisualStyleBackColor = true;
            // 
            // InsertRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TaxCheckbox3);
            Controls.Add(TaxCheckbox2);
            Controls.Add(TaxCheckbox1);
            Controls.Add(lblTaxTxt);
            Controls.Add(txtItemPrice);
            Controls.Add(lblItemPrice);
            Controls.Add(InsertBtn);
            Controls.Add(comboItemType);
            Controls.Add(lblItemTypeTxt);
            Controls.Add(txtItemName);
            Controls.Add(lblItemNameTxt);
            Controls.Add(lblInsertRecordHdrTxt);
            Name = "InsertRecord";
            Size = new Size(990, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInsertRecordHdrTxt;
        private Label lblItemNameTxt;
        private TextBox txtItemName;
        private Label lblItemTypeTxt;
        private ComboBox comboItemType;
        private Button InsertBtn;
        private Label lblItemPrice;
        private TextBox txtItemPrice;
        private Label lblTaxTxt;
        private CheckBox TaxCheckbox1;
        private CheckBox TaxCheckbox2;
        private CheckBox TaxCheckbox3;
    }
}
