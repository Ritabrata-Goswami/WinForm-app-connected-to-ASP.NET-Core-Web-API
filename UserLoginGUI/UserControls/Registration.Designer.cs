namespace UserLoginGUI.UserControls
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            lblRegistrationHdr = new Label();
            lblName = new Label();
            lblUserId = new Label();
            lblPassword = new Label();
            lblGender = new Label();
            lblFileUpload = new Label();
            txtName = new TextBox();
            txtUserId = new TextBox();
            txtUserPassword = new TextBox();
            MaleRadioButton = new RadioButton();
            FemaleRadioButton = new RadioButton();
            UploadFileBtn = new Button();
            SubmitBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBoxPreview = new PictureBox();
            lblPhotoReview = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            SuspendLayout();
            // 
            // lblRegistrationHdr
            // 
            lblRegistrationHdr.Dock = DockStyle.Top;
            lblRegistrationHdr.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistrationHdr.Location = new Point(0, 0);
            lblRegistrationHdr.Name = "lblRegistrationHdr";
            lblRegistrationHdr.Size = new Size(960, 32);
            lblRegistrationHdr.TabIndex = 0;
            lblRegistrationHdr.Text = "User Registration";
            lblRegistrationHdr.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(43, 58);
            lblName.Name = "lblName";
            lblName.Size = new Size(159, 32);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblUserId
            // 
            lblUserId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserId.Location = new Point(43, 99);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(159, 31);
            lblUserId.TabIndex = 2;
            lblUserId.Text = "User Id:";
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(43, 140);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(159, 33);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // lblGender
            // 
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.Location = new Point(43, 183);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(159, 28);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender:";
            // 
            // lblFileUpload
            // 
            lblFileUpload.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFileUpload.Location = new Point(43, 230);
            lblFileUpload.Name = "lblFileUpload";
            lblFileUpload.Size = new Size(159, 32);
            lblFileUpload.TabIndex = 5;
            lblFileUpload.Text = "Upload Photo:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(211, 58);
            txtName.MaxLength = 50;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Enter your name...";
            txtName.Size = new Size(338, 34);
            txtName.TabIndex = 6;
            // 
            // txtUserId
            // 
            txtUserId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserId.Location = new Point(211, 99);
            txtUserId.MaxLength = 70;
            txtUserId.Name = "txtUserId";
            txtUserId.PlaceholderText = "Enter your user id (Email)...";
            txtUserId.Size = new Size(338, 34);
            txtUserId.TabIndex = 7;
            // 
            // txtUserPassword
            // 
            txtUserPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserPassword.Location = new Point(211, 140);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.PlaceholderText = "Enter your password...";
            txtUserPassword.Size = new Size(338, 34);
            txtUserPassword.TabIndex = 8;
            // 
            // MaleRadioButton
            // 
            MaleRadioButton.AutoSize = true;
            MaleRadioButton.Checked = true;
            MaleRadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MaleRadioButton.Location = new Point(211, 183);
            MaleRadioButton.Name = "MaleRadioButton";
            MaleRadioButton.Size = new Size(76, 32);
            MaleRadioButton.TabIndex = 9;
            MaleRadioButton.TabStop = true;
            MaleRadioButton.Text = "Male";
            MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioButton
            // 
            FemaleRadioButton.AutoSize = true;
            FemaleRadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FemaleRadioButton.Location = new Point(312, 183);
            FemaleRadioButton.Name = "FemaleRadioButton";
            FemaleRadioButton.Size = new Size(95, 32);
            FemaleRadioButton.TabIndex = 10;
            FemaleRadioButton.Text = "Female";
            FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // UploadFileBtn
            // 
            UploadFileBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UploadFileBtn.Location = new Point(211, 230);
            UploadFileBtn.Name = "UploadFileBtn";
            UploadFileBtn.Size = new Size(228, 43);
            UploadFileBtn.TabIndex = 11;
            UploadFileBtn.Text = "Upload Your Photo";
            UploadFileBtn.UseVisualStyleBackColor = true;
            UploadFileBtn.Click += UploadFileBtn_Click;
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = SystemColors.ControlDarkDark;
            SubmitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SubmitBtn.ForeColor = SystemColors.ButtonHighlight;
            SubmitBtn.Location = new Point(397, 307);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(152, 46);
            SubmitBtn.TabIndex = 12;
            SubmitBtn.Text = "Register";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += Registration_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.InitialImage = (Image)resources.GetObject("pictureBoxPreview.InitialImage");
            pictureBoxPreview.Location = new Point(717, 90);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(160, 170);
            pictureBoxPreview.TabIndex = 13;
            pictureBoxPreview.TabStop = false;
            // 
            // lblPhotoReview
            // 
            lblPhotoReview.AutoSize = true;
            lblPhotoReview.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhotoReview.Location = new Point(717, 58);
            lblPhotoReview.Name = "lblPhotoReview";
            lblPhotoReview.Size = new Size(113, 23);
            lblPhotoReview.TabIndex = 14;
            lblPhotoReview.Text = "Photo Review";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPhotoReview);
            Controls.Add(pictureBoxPreview);
            Controls.Add(SubmitBtn);
            Controls.Add(UploadFileBtn);
            Controls.Add(FemaleRadioButton);
            Controls.Add(MaleRadioButton);
            Controls.Add(txtUserPassword);
            Controls.Add(txtUserId);
            Controls.Add(txtName);
            Controls.Add(lblFileUpload);
            Controls.Add(lblGender);
            Controls.Add(lblPassword);
            Controls.Add(lblUserId);
            Controls.Add(lblName);
            Controls.Add(lblRegistrationHdr);
            Name = "Registration";
            Size = new Size(960, 402);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistrationHdr;
        private Label lblName;
        private Label lblUserId;
        private Label lblPassword;
        private Label lblGender;
        private Label lblFileUpload;
        private TextBox txtName;
        private TextBox txtUserId;
        private TextBox txtUserPassword;
        private RadioButton MaleRadioButton;
        private RadioButton FemaleRadioButton;
        private Button UploadFileBtn;
        private Button SubmitBtn;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBoxPreview;
        private Label lblPhotoReview;
    }
}
