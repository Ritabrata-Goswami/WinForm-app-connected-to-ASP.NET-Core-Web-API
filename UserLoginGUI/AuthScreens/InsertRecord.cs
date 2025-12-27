using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

using UserLoginGUI.CommonCls;
using UserLoginGUI_ApiEndpoints;


namespace UserLoginGUI.AuthScreens
{
    public partial class InsertRecord : UserControl
    {
        public InsertRecord()
        {
            InitializeComponent();

            List<ComboItem> Items = new List<ComboItem>()
            {
                new ComboItem() { Value = "0", Text = "----Select----" },
                new ComboItem() { Value = "Raw Item", Text= "Raw material Item" },
                new ComboItem() { Value = "Finished Item", Text = "Finished Goods Item" },
                new ComboItem() { Value ="WIP Item", Text = "WIP material" }
            };

            comboItemType.DataSource = Items;
            comboItemType.DisplayMember = "Text";
            comboItemType.ValueMember = "Value";

            comboItemType.SelectedValue = "0";
        }

        private async void Submit_Event(object sender, EventArgs e)
        {
            string ItemName = txtItemName.Text;
            string? ItemType = Convert.ToString(comboItemType.SelectedValue);
            decimal ItemPrice = decimal.TryParse(txtItemPrice.Text, out decimal result) ? result : 0;
            List<string> TaxList = new List<string>();

            foreach(var controls in this.Controls)
            {
                if (controls is CheckBox)
                {
                    if (((CheckBox)controls).Checked)
                    {
                        TaxList.Add(((CheckBox)controls).Text);
                    }
                }
            }

            if(!string.IsNullOrEmpty(ItemName) && ItemType !="0" && ItemPrice != 0 && TaxList.Count != 0)
            {
                HttpClient httpClient = null;
                Cls_Response? ResponseObj = null;
                try
                {
                    httpClient = new HttpClient();
                    Cls_ItemPosting ItemPostingPayload = new Cls_ItemPosting()
                    {
                        ItemName = ItemName,
                        ItemType = ItemType,
                        ItemPrice = ItemPrice,
                        Tax = string.Join(",",TaxList)
                    };

                    httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.AuthToken);
                    string SendJson = JsonSerializer.Serialize<Cls_ItemPosting>(ItemPostingPayload);
                    StringContent EncodedJson = new StringContent(SendJson, Encoding.UTF8,"application/json");
                    HttpResponseMessage httpResponse = await httpClient.PostAsync(EndpointClass.ItemPostUrl, EncodedJson);

                    int httpStatusCode = (int)httpResponse.StatusCode;
                    switch (httpStatusCode)
                    {
                        case 201:
                            ResponseObj = await httpResponse.Content.ReadFromJsonAsync<Cls_Response>();
                            MessageBox.Show(ResponseObj?.StatusMessage, "Success");
                            break;
                        case 404:
                            ResponseObj = await httpResponse.Content.ReadFromJsonAsync<Cls_Response>();
                            MessageBox.Show(ResponseObj?.StatusMessage, "Not Found");
                            break;
                        case 505:
                            ResponseObj = await httpResponse.Content.ReadFromJsonAsync<Cls_Response>();
                            MessageBox.Show(ResponseObj?.StatusMessage, "Internal Server Error");
                            break;
                        case 400:
                            ResponseObj = await httpResponse.Content.ReadFromJsonAsync<Cls_Response>();
                            MessageBox.Show(ResponseObj?.StatusMessage, "Not Allowed");
                            break;
                        default:
                            ResponseObj = await httpResponse.Content.ReadFromJsonAsync<Cls_Response>();
                            MessageBox.Show(ResponseObj?.StatusMessage, "Unknown Error");
                            break;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Item Posting Error");
                }
                finally
                {
                    httpClient?.Dispose();
                }
            }
            else
            {
                MessageBox.Show("All fields are mandatory!","Posting Failed");
            }

        }


    }
}
