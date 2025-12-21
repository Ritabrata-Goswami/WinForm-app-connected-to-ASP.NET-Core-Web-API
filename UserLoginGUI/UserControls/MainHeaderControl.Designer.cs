namespace UserLoginGUI.UserControls
{
    partial class MainHeaderControl
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
            txtLabel1 = new Label();
            loginBtn = new Button();
            RegistrationBtn = new Button();
            SuspendLayout();
            // 
            // txtLabel1
            // 
            txtLabel1.Dock = DockStyle.Top;
            txtLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtLabel1.Location = new Point(0, 0);
            txtLabel1.Name = "txtLabel1";
            txtLabel1.Size = new Size(1005, 41);
            txtLabel1.TabIndex = 0;
            txtLabel1.Text = "Welcome to application";
            txtLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(31, 31, 31);
            loginBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.ForeColor = SystemColors.ButtonHighlight;
            loginBtn.Location = new Point(10, 61);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(94, 38);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += LoginDisplay;
            // 
            // RegistrationBtn
            // 
            RegistrationBtn.BackColor = Color.FromArgb(31, 31, 31);
            RegistrationBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            RegistrationBtn.ForeColor = SystemColors.ButtonHighlight;
            RegistrationBtn.Location = new Point(110, 61);
            RegistrationBtn.Name = "RegistrationBtn";
            RegistrationBtn.Size = new Size(115, 38);
            RegistrationBtn.TabIndex = 4;
            RegistrationBtn.Text = "Registration";
            RegistrationBtn.UseVisualStyleBackColor = false;
            RegistrationBtn.Click += RegistrationDisplay;
            // 
            // MainHeaderControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(loginBtn);
            Controls.Add(RegistrationBtn);
            Controls.Add(txtLabel1);
            Name = "MainHeaderControl";
            Size = new Size(1005, 465);
            ResumeLayout(false);
        }

        #endregion

        private Label txtLabel1;
        private Button loginBtn;
        private Button RegistrationBtn;
    }
}
