namespace UserLoginGUI.AuthScreens
{
    partial class NoRecordsFound
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
            NoRecordsFoundTxt = new Label();
            SuspendLayout();
            // 
            // NoRecordsFoundTxt
            // 
            NoRecordsFoundTxt.Dock = DockStyle.Fill;
            NoRecordsFoundTxt.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            NoRecordsFoundTxt.ForeColor = Color.FromArgb(255, 1, 1);
            NoRecordsFoundTxt.Location = new Point(0, 0);
            NoRecordsFoundTxt.Name = "NoRecordsFoundTxt";
            NoRecordsFoundTxt.Size = new Size(834, 175);
            NoRecordsFoundTxt.TabIndex = 0;
            NoRecordsFoundTxt.Text = "No Records Found!";
            NoRecordsFoundTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NoRecordsFound
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NoRecordsFoundTxt);
            Name = "NoRecordsFound";
            Size = new Size(834, 175);
            ResumeLayout(false);
        }

        #endregion

        private Label NoRecordsFoundTxt;
    }
}
