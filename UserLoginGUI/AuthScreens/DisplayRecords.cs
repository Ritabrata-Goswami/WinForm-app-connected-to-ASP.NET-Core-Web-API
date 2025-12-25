using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLoginGUI.CommonCls;
using UserLoginGUI_ApiEndpoints;

namespace UserLoginGUI.AuthScreens
{
    public partial class DisplayRecords : UserControl
    {
        public DisplayRecords()
        {
            InitializeComponent();
            DataGridViewCreate();
        }

        private async void DataGridViewCreate()
        {
            HttpClient httpClient = null;
            Cls_Response Cls_ResObj = null;
            NoRecordsFound noRcrdsFoundObj = new NoRecordsFound();
            Cls_GetItemLists? httpResponseObj = null;

            try
            {
                httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer",Properties.Settings.Default.AuthToken);
                HttpResponseMessage httpResponse = await httpClient.GetAsync(EndpointClass.GetRecordsUrl);

                int httpStatusCode = (int)httpResponse.StatusCode;

                switch (httpStatusCode)
                {
                    case 200:
                        httpResponseObj = await httpResponse.Content.ReadFromJsonAsync<Cls_GetItemLists>();
                        dataGridView1.DataSource = httpResponseObj?.ItemListing;
                        noRcrdsFoundObj.Visible = false;
                        dataGridView1.Visible = true;
                        break;
                    case 401:
                        MessageBox.Show("Auth token not found or not in correct format!", "Authentication Failed");
                        break;
                    case 404:
                        dataGridView1.Visible = false;
                        //noRcrdsFoundObj = new NoRecordsFound();
                        noRcrdsFoundObj.Visible = true;
                        noRcrdsFoundObj.Location = new System.Drawing.Point(10, 0);
                        this.Controls.Add(noRcrdsFoundObj);

                        httpResponseObj = await httpResponse.Content.ReadFromJsonAsync<Cls_GetItemLists>();
                        MessageBox.Show(httpResponseObj?.StatusMessage, "Not Found");
                        break;
                    case 500:
                        httpResponseObj = await httpResponse.Content.ReadFromJsonAsync<Cls_GetItemLists>();
                        MessageBox.Show(httpResponseObj?.StatusMessage, "Internal Server Error");
                        break;
                    default:
                        MessageBox.Show("An unknown exception from backend is receiving!","Unknown Error");
                        break;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                httpClient?.Dispose();
            }
        }

    }
}
