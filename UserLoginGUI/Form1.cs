using UserLoginGUI.UserControls;
using UserLoginGUI.AuthScreens;
using UserLoginGUI.CommonCls;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace UserLoginGUI
{
    public partial class Form1 : Form
    {
        public event EventHandler LogoutEvent;

        //Registration RegObj;
        //Login LoginObj;
        MainHeaderControl MainHeaderControlObj;
        MainAuthScreen _MainAuthScreenObj;

        public Form1()
        {
            InitializeComponent();

            //RegObj = new Registration();
            //LoginObj = new Login();
            MainHeaderControlObj = new MainHeaderControl();

            //LoginObj.LoginEvent += LoginSucceed_Event;
            MainHeaderControlObj.LoginEvent += LoginSucceed_Event;


            MainHeaderControlObj.Location = new System.Drawing.Point(0,0);
            MainHeaderControlObj.Dock = DockStyle.Fill;

            string Token = Properties.Settings.Default.AuthToken;
            int Id = Properties.Settings.Default.UserId;
            if (!String.IsNullOrEmpty(Token) && Id != 0)
            {
                string UserName = Properties.Settings.Default.UserName;
                string UserEmail = Properties.Settings.Default.UserMail;
                string UserImagePath = Properties.Settings.Default.UserProfileImage;

                LoginSucceed_Event(this, new ShareUserProfile(UserName, UserEmail,UserImagePath));
            }

            this.Controls.Add(MainHeaderControlObj);

            MainHeaderControlObj.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Display_LoginEvent(object sender, EventArgs e)
        {
            //RegObj.Visible = true;
            //LoginObj.Visible = true;
            MainHeaderControlObj.Visible = true;
            _MainAuthScreenObj.Visible = false;

            LogoutEvent?.Invoke(this, new EventArgs());
        }

        private void LoginSucceed_Event(object sender, ShareUserProfile e)
        {
            MainHeaderControlObj.Visible = false;
            _MainAuthScreenObj = new MainAuthScreen(e.UserName, e.UserEmail, e.UserImage);

            _MainAuthScreenObj.Visible = true;
            _MainAuthScreenObj.Dock = DockStyle.Fill;
            //_MainAuthScreenObj.LogoutEvent += Logout_Event;  
            _MainAuthScreenObj.LogoutEvent += Display_LoginEvent;  //Subscribe logout event.

            this.Controls.Add(_MainAuthScreenObj);
        }

        //private void Logout_Event(object sender, EventArgs e)
        //{
        //    LoginObj.Visible = true;
        //    LogoutEvent?.Invoke(this, new EventArgs());
        //}

    }
}
