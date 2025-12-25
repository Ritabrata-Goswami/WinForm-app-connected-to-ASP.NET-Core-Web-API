namespace UserLoginGUI.AuthScreens
{
    partial class MainAuthScreen
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
            lblAuthHdr = new Label();
            LogoutBtn = new Button();
            profilePic = new PictureBox();
            lblProfileName = new Label();
            lblUserId = new Label();
            DisplayBtn = new Button();
            InsertBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)profilePic).BeginInit();
            SuspendLayout();
            // 
            // lblAuthHdr
            // 
            lblAuthHdr.Dock = DockStyle.Top;
            lblAuthHdr.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAuthHdr.Location = new Point(0, 0);
            lblAuthHdr.Name = "lblAuthHdr";
            lblAuthHdr.Size = new Size(1173, 39);
            lblAuthHdr.TabIndex = 0;
            lblAuthHdr.Text = "Welcome to Dashboard";
            lblAuthHdr.TextAlign = ContentAlignment.TopCenter;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.FromArgb(255, 1, 1);
            LogoutBtn.Cursor = Cursors.Hand;
            LogoutBtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutBtn.ForeColor = SystemColors.ButtonFace;
            LogoutBtn.Location = new Point(185, 47);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(63, 29);
            LogoutBtn.TabIndex = 1;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += Logout_Click;
            // 
            // profilePic
            // 
            profilePic.Location = new Point(8, 47);
            profilePic.Name = "profilePic";
            profilePic.Size = new Size(139, 145);
            profilePic.TabIndex = 2;
            profilePic.TabStop = false;
            // 
            // lblProfileName
            // 
            lblProfileName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfileName.Location = new Point(8, 198);
            lblProfileName.Name = "lblProfileName";
            lblProfileName.Size = new Size(742, 25);
            lblProfileName.TabIndex = 3;
            lblProfileName.Text = "Name...";
            // 
            // lblUserId
            // 
            lblUserId.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserId.Location = new Point(8, 226);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(208, 25);
            lblUserId.TabIndex = 4;
            lblUserId.Text = "Id...";
            // 
            // DisplayBtn
            // 
            DisplayBtn.Cursor = Cursors.Hand;
            DisplayBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DisplayBtn.Location = new Point(8, 287);
            DisplayBtn.Name = "DisplayBtn";
            DisplayBtn.Size = new Size(159, 40);
            DisplayBtn.TabIndex = 5;
            DisplayBtn.Text = "Display Records";
            DisplayBtn.UseVisualStyleBackColor = true;
            DisplayBtn.Click += Display_Click;
            // 
            // InsertBtn
            // 
            InsertBtn.Cursor = Cursors.Hand;
            InsertBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            InsertBtn.Location = new Point(173, 287);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(149, 40);
            InsertBtn.TabIndex = 6;
            InsertBtn.Text = "Insert Record";
            InsertBtn.UseVisualStyleBackColor = true;
            InsertBtn.Click += Insert_Click;
            // 
            // MainAuthScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(InsertBtn);
            Controls.Add(DisplayBtn);
            Controls.Add(lblUserId);
            Controls.Add(lblProfileName);
            Controls.Add(profilePic);
            Controls.Add(LogoutBtn);
            Controls.Add(lblAuthHdr);
            Name = "MainAuthScreen";
            Size = new Size(1173, 682);
            ((System.ComponentModel.ISupportInitialize)profilePic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAuthHdr;
        private Button LogoutBtn;
        private PictureBox profilePic;
        private Label lblProfileName;
        private Label lblUserId;
        private Button DisplayBtn;
        private Button InsertBtn;
    }
}
