namespace UserLoginGUI.UserControls
{
    partial class Login
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
            lblLoginHdrTxt = new Label();
            lblUserId = new Label();
            txtUserId = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblLoginHdrTxt
            // 
            lblLoginHdrTxt.Dock = DockStyle.Top;
            lblLoginHdrTxt.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoginHdrTxt.Location = new Point(0, 0);
            lblLoginHdrTxt.Name = "lblLoginHdrTxt";
            lblLoginHdrTxt.Size = new Size(896, 32);
            lblLoginHdrTxt.TabIndex = 0;
            lblLoginHdrTxt.Text = "User Login";
            lblLoginHdrTxt.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblUserId
            // 
            lblUserId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserId.Location = new Point(43, 58);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(171, 34);
            lblUserId.TabIndex = 1;
            lblUserId.Text = "Enter UserId:";
            // 
            // txtUserId
            // 
            txtUserId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserId.Location = new Point(219, 58);
            txtUserId.Name = "txtUserId";
            txtUserId.PlaceholderText = "Enter your user id...";
            txtUserId.Size = new Size(250, 34);
            txtUserId.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(43, 105);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(171, 36);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Enter Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(219, 105);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password...";
            txtPassword.Size = new Size(250, 34);
            txtPassword.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(345, 166);
            button1.Name = "button1";
            button1.Size = new Size(124, 46);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Login_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserId);
            Controls.Add(lblUserId);
            Controls.Add(lblLoginHdrTxt);
            Name = "Login";
            Size = new Size(896, 299);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoginHdrTxt;
        private Label lblUserId;
        private TextBox txtUserId;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button button1;
    }
}
