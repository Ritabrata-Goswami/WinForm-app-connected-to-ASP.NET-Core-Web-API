using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLoginGUI.CommonCls;


namespace UserLoginGUI.AuthScreens
{
    public partial class MainAuthScreen : UserControl
    {
        public event EventHandler LogoutEvent;

        internal InsertRecord _insertRecordObj;
        internal DisplayRecords _displayRecordsObj;

        public MainAuthScreen(string? UserName, string? UserEmail, string? UserImagePath)
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(UserImagePath))
            {
                LoadProfilePicAsync(UserImagePath);
            }
            else
            {
                //Show default image.
            }

            lblProfileName.Text = UserName ?? "Loading...";
            lblUserId.Text = UserEmail ?? "Loading...";

            _insertRecordObj = new InsertRecord();
            _displayRecordsObj = new DisplayRecords();

            _insertRecordObj.Location = new System.Drawing.Point(10,320);
            this.Controls.Add(_insertRecordObj);
            _insertRecordObj.Visible = true;
            InsertBtn.BackColor = System.Drawing.Color.ForestGreen;
            InsertBtn.ForeColor = System.Drawing.Color.WhiteSmoke;

            _displayRecordsObj.Location = new System.Drawing.Point(10, 320);
            this.Controls.Add(_displayRecordsObj);
            _displayRecordsObj.Visible = false;
            DisplayBtn.BackColor = System.Drawing.Color.WhiteSmoke;
        }


        public async void LoadProfilePicAsync(string ImgPath)
        {
            HttpClient httpClient = new HttpClient();
            byte[] bytesObj = await httpClient.GetByteArrayAsync(ImgPath);
            MemoryStream MsObj = new MemoryStream(bytesObj);
            
            profilePic.Image = Image.FromStream(MsObj);
            profilePic.SizeMode = PictureBoxSizeMode.Zoom; //Fit into container.
        }


        private void Logout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AuthToken= string.Empty;
            Properties.Settings.Default.UserId = 0;
            Properties.Settings.Default.Save();

            this.Visible = false;
            LogoutEvent?.Invoke(this, new EventArgs());
        }

        private void Display_Click(object sender, EventArgs e)
        {
            _displayRecordsObj.Visible= true;
            _insertRecordObj.Visible = false;
            DisplayBtn.BackColor = System.Drawing.Color.ForestGreen;
            DisplayBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            InsertBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            InsertBtn.ForeColor = System.Drawing.Color.Black;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            _displayRecordsObj.Visible = false;
            _insertRecordObj.Visible = true;
            DisplayBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            DisplayBtn.ForeColor = System.Drawing.Color.Black;
            InsertBtn.BackColor = System.Drawing.Color.ForestGreen;
            InsertBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
        }


    }
}
