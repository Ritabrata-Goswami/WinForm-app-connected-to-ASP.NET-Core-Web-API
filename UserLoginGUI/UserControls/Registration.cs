using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;

using UserLoginGUI_ApiEndpoints;
using UserLoginGUI.CommonCls;
using System.Net.Http.Json;


namespace UserLoginGUI.UserControls
{
    public partial class Registration : UserControl
    {
        public event EventHandler LogoutEvent;

        private string? FilePath { get; set; }
        public Registration()
        {
            InitializeComponent();

            pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureBoxPreview.Image = Image.FromFile(@"D:\Working\C#\Projects\UserLoginGUI\Image\user_logo_images.jpg");
            pictureBoxPreview.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Image", "user_logo_images.jpg"));
        }

        private void UploadFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select your photo.";
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "Image Files (*.jpg;*.png;)|*.jpg;*.png;";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialog1.FileName;
                pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;  //To fit inside pictureBox.
                pictureBoxPreview.Image = Image.FromFile(FilePath);

            }
        }

        private async void Registration_Click(object sender, EventArgs e)
        {
            string UName = txtName.Text.Trim();
            string UId = txtUserId.Text.Trim();
            string UPass = txtUserPassword.Text.Trim();
            string UGenM = MaleRadioButton.Text.Trim();
            string UGenF = FemaleRadioButton.Text.Trim();
            string? FileName = Path.GetFileName(FilePath);
             
            if (!string.IsNullOrEmpty(UName) && !string.IsNullOrEmpty(UId) 
                && !string.IsNullOrEmpty(UPass) && !string.IsNullOrEmpty(FilePath))
            {
                string Gender = (MaleRadioButton.Checked) ? UGenM : UGenF;
                DateTime Reg_t = DateTime.Now;
                string RegUrl = EndpointClass.RegEndpoint;

                HttpClient httpClientObj = null;
                MultipartFormDataContent formData = null;

                try
                {
                    httpClientObj = new HttpClient();
                    formData = new MultipartFormDataContent();

                    formData.Add(new StringContent(UName), "UserName");
                    formData.Add(new StringContent(UId), "UserEmail");
                    formData.Add(new StringContent(UPass), "UserPassword");
                    formData.Add(new StringContent(Gender), "UserGender");
                    formData.Add(new StringContent(Reg_t.ToString()),"RegTime");

                    FileStream FileStreamObj =File.OpenRead(FilePath);
                    StreamContent FileStreamContentObj = new StreamContent(FileStreamObj);

                    formData.Add(FileStreamContentObj, "UserProfileImage", FileName);

                    HttpResponseMessage HttpResponse = await httpClientObj.PostAsync(RegUrl, formData);
                    if (HttpResponse.IsSuccessStatusCode)
                    {
                        Cls_Response? GetRegResponse = await HttpResponse.Content.ReadFromJsonAsync<Cls_Response>();
                        switch (GetRegResponse?.StatusCode)
                        {
                            case 200:
                                MessageBox.Show(GetRegResponse.StatusMessage, "Success");
                                break;
                            case 404:
                                MessageBox.Show(GetRegResponse.StatusMessage, "Not Found");
                                break;
                            case 500:
                                MessageBox.Show(GetRegResponse.StatusMessage, "Internal Server Error");
                                break;
                            default:
                                MessageBox.Show(GetRegResponse.StatusMessage, "Unknown Error");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Response Error Code:- " + HttpResponse.StatusCode.ToString(), "Response Error");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                finally
                {
                    httpClientObj?.Dispose();
                    formData?.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Registration Process Is Incomplete!","Imcomplete Data");
            }
        }

    }
}
