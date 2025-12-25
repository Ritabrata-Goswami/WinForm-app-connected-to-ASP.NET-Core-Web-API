namespace UserLoginGUI.AuthScreens
{
    partial class DisplayRecords
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
            txtDisplayHdrTxt = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtDisplayHdrTxt
            // 
            txtDisplayHdrTxt.Dock = DockStyle.Top;
            txtDisplayHdrTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtDisplayHdrTxt.Location = new Point(0, 0);
            txtDisplayHdrTxt.Name = "txtDisplayHdrTxt";
            txtDisplayHdrTxt.Padding = new Padding(0, 8, 0, 0);
            txtDisplayHdrTxt.Size = new Size(1053, 51);
            txtDisplayHdrTxt.TabIndex = 0;
            txtDisplayHdrTxt.Text = "Display Records";
            txtDisplayHdrTxt.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1053, 351);
            dataGridView1.TabIndex = 1;
            // 
            // DisplayRecords
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(txtDisplayHdrTxt);
            Cursor = Cursors.Hand;
            Name = "DisplayRecords";
            Size = new Size(1053, 470);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label txtDisplayHdrTxt;
        private DataGridView dataGridView1;
    }
}
