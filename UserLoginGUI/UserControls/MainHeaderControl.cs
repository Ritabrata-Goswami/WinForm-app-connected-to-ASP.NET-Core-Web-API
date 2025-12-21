using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UserLoginGUI.UserControls;
using UserLoginGUI.AuthScreens;
using UserLoginGUI.CommonCls;


namespace UserLoginGUI.UserControls
{
    public partial class MainHeaderControl : UserControl
    {
        public event EventHandler FirstLoginEvent;
        public event EventHandler<ShareUserProfile> LoginEvent;

        internal Registration RegObj { get; set; }
        internal Login LoginObj { get; set; }

        public MainHeaderControl()
        {
            InitializeComponent();

            RegObj = new Registration();
            LoginObj = new Login();

            LoginObj.FirstLoginEvent += HeaderControlPanel_Event;
            LoginObj.LogoutEvent += Display_LoginForm;
            LoginObj.LoginEvent += ForwardLogin_Form1;  //Subscribe event to forward control to Form1;

            LoginObj.Location = new System.Drawing.Point(15, 105);
            RegObj.Location = new System.Drawing.Point(15, 105);

            loginBtn.BackColor = System.Drawing.Color.MediumPurple;
            RegistrationBtn.BackColor = System.Drawing.Color.Black;

            this.Controls.Add(LoginObj);
            this.Controls.Add(RegObj);
            LoginObj.Visible = true;
            RegObj.Visible = false;
        }

        private void RegistrationDisplay(object sender, EventArgs e)
        {
            LoginObj.Visible = false;
            RegObj.Visible = true;

            loginBtn.BackColor = System.Drawing.Color.Black;
            RegistrationBtn.BackColor = System.Drawing.Color.MediumPurple;
        }

        private void LoginDisplay(object sender, EventArgs e)
        {
            LoginObj.Visible = true;
            RegObj.Visible = false;

            loginBtn.BackColor = System.Drawing.Color.MediumPurple;
            RegistrationBtn.BackColor = System.Drawing.Color.Black;
        }

        private void HeaderControlPanel_Event(object sender, EventArgs e)
        {
            txtLabel1.Visible = false;
            loginBtn.Visible = false;
            RegistrationBtn.Visible = false;
        }

        private void Display_LoginForm(object sender, EventArgs e)
        {
            txtLabel1.Visible = true;
            loginBtn.Visible = true;
            RegistrationBtn.Visible = true;

            LoginObj.Visible = true;
            RegObj.Visible = false;
        }

        private void ForwardLogin_Form1(object sender, ShareUserProfile e)
        {
            LoginEvent?.Invoke(this, e);
        }


    }
}
