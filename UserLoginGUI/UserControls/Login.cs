using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

using UserLoginGUI.AuthScreens;
using UserLoginGUI.CommonCls;
using UserLoginGUI_ApiEndpoints;


namespace UserLoginGUI.UserControls
{
    public partial class Login : UserControl
    {
        public event EventHandler FirstLoginEvent;
        public event EventHandler LogoutEvent;
        public event EventHandler<ShareUserProfile> LoginEvent;

        internal MainAuthScreen? _MainAuthScreenObj { get; set; }

        public Login()
        {
            InitializeComponent();

        }

        private async void Login_Click(object sender, EventArgs e)
        {
            string UId = txtUserId.Text.Trim();
            string UPass = txtPassword.Text.Trim();
            HttpClient httpClient = null;
            string LoginUrl = EndpointClass.LoginEndpoint;

            try
            {
                if (!String.IsNullOrEmpty(UId) && !String.IsNullOrEmpty(UPass))
                {
                    Cls_UserLogin LoginPayload = new Cls_UserLogin()
                    {
                        UserId = UId,
                        UserPass = UPass,
                    };

                    string Str_LoginPayload = JsonSerializer.Serialize(LoginPayload);
                    StringContent EncodingPayload = new StringContent(Str_LoginPayload, Encoding.UTF8, "application/json");
                    httpClient = new HttpClient();
                    HttpResponseMessage httpResponse = await httpClient.PostAsync(LoginUrl, EncodingPayload);

                    int StatusCode = (int)httpResponse.StatusCode;  //Converting HttpStatusCode enum into int code.

                    switch (StatusCode)
                    {
                        case 200:
                            Cls_UserAuth? GetResJson_200 = await httpResponse.Content.ReadFromJsonAsync<Cls_UserAuth>();

                            Properties.Settings.Default.AuthToken = GetResJson_200?.AuthToken;
                            Properties.Settings.Default.UserId = GetResJson_200.Id;
                            Properties.Settings.Default.UserMail = GetResJson_200.UserEmail;
                            Properties.Settings.Default.UserName = GetResJson_200.UserName;
                            Properties.Settings.Default.UserProfileImage = EndpointClass.BaseImageUrl + GetResJson_200.UserImagePath;
                            Properties.Settings.Default.Save();

                            FirstLoginEvent?.Invoke(this, new EventArgs());

                            this.Visible = false;
                            string? UserName = GetResJson_200.UserName;
                            string? UserEmail = GetResJson_200.UserEmail;
                            string? UserImagePath = EndpointClass.BaseImageUrl + GetResJson_200.UserImagePath;

                            LoginEvent?.Invoke(this, new ShareUserProfile(UserName, UserEmail, UserImagePath));

                            break;
                        case 404:
                            Cls_Response? GetResJson_404 = await httpResponse.Content.ReadFromJsonAsync<Cls_Response>();
                            MessageBox.Show(GetResJson_404?.StatusMessage, "Login Failed");
                            break;
                        case 400:
                            Cls_Response? GetResJson_400 = await httpResponse.Content.ReadFromJsonAsync<Cls_Response>();
                            MessageBox.Show(GetResJson_400?.StatusMessage, "Login Failed");
                            break;
                        case 500:
                            Cls_Response? GetResJson_500 = await httpResponse.Content.ReadFromJsonAsync<Cls_Response>();
                            MessageBox.Show(GetResJson_500?.StatusMessage, "Login Failed");
                            break;
                        default:
                            Cls_Response? GetResJson_Err = await httpResponse.Content.ReadFromJsonAsync<Cls_Response>();
                            MessageBox.Show(GetResJson_Err?.StatusMessage, "Unknown Error");
                            break;
                    }

                }
                else
                {
                    MessageBox.Show("Please provide your credentials!", "Login Not Allowed");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Internal Error");
            }
        }


    }
}
