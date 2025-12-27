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
        public event EventHandler DeleteRow;
        public DisplayRecords()
        {
            InitializeComponent();
            DataGridViewCreate();
            dataGridView1.CellContentClick += DeleteRowGridView_Event;  //Assigning delete row event method.
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
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.AuthToken);
                HttpResponseMessage httpResponse = await httpClient.GetAsync(EndpointClass.GetRecordsUrl);

                int httpStatusCode = (int)httpResponse.StatusCode;

                switch (httpStatusCode)
                {
                    case 200:
                        httpResponseObj = await httpResponse.Content.ReadFromJsonAsync<Cls_GetItemLists>();
                        dataGridView1.Columns.Clear();
                        dataGridView1.Visible = false;
                        dataGridView1.EnableHeadersVisualStyles = false;
                        dataGridView1.AutoGenerateColumns = false;

                        DataGridViewTextBoxColumn Col1 = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn Col2 = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn Col3 = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn Col4 = new DataGridViewTextBoxColumn();
                        DataGridViewTextBoxColumn Col5 = new DataGridViewTextBoxColumn();
                        //DataGridViewTextBoxColumn Col6 = new DataGridViewTextBoxColumn();

                        DataGridViewButtonColumn deleteBtnCol = new DataGridViewButtonColumn();

                        Col1.HeaderText = "Id";
                        Col1.DataPropertyName = "Id";
                        Col2.HeaderText = "Item Name";
                        Col2.DataPropertyName = "ItemName";
                        Col3.HeaderText = "Item Type";
                        Col3.DataPropertyName = "ItemType";
                        Col4.HeaderText = "Item Price";
                        Col4.DataPropertyName = "ItemPrice";
                        Col5.HeaderText = "Tax List";
                        Col5.DataPropertyName = "Tax";
                        //Col6.HeaderText = "Delete Row";

                        deleteBtnCol.HeaderText = "Delete Row";
                        deleteBtnCol.Text = "Delete";
                        deleteBtnCol.Visible = true;
                        deleteBtnCol.Width = 100;
                        deleteBtnCol.UseColumnTextForButtonValue = true;
                        deleteBtnCol.DefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

                        dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font,FontStyle.Bold);
                        dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.BlueViolet;

                        dataGridView1.Columns.Add(Col1);
                        dataGridView1.Columns.Add(Col2);
                        dataGridView1.Columns.Add(Col3);
                        dataGridView1.Columns.Add(Col4);
                        dataGridView1.Columns.Add(Col5);
                        //dataGridView1.Columns.Add(Col6);
                        dataGridView1.Columns.Add(deleteBtnCol);

                        dataGridView1.DataSource = httpResponseObj?.ItemListing;
                        noRcrdsFoundObj.Visible = false;
                        dataGridView1.Visible = true;
                        break;
                    case 401:
                        dataGridView1.Visible = false;
                        noRcrdsFoundObj.Visible = true;
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
                        dataGridView1.Visible = false;
                        noRcrdsFoundObj.Visible = true;
                        httpResponseObj = await httpResponse.Content.ReadFromJsonAsync<Cls_GetItemLists>();
                        MessageBox.Show(httpResponseObj?.StatusMessage, "Internal Server Error");
                        break;
                    default:
                        dataGridView1.Visible = false;
                        noRcrdsFoundObj.Visible = true;
                        MessageBox.Show("An unknown exception from backend is receiving!", "Unknown Error");
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

        private void RefreshGrid_Event(object sender, EventArgs e)
        {
            DataGridViewCreate();
        }

        private async void DeleteRowGridView_Event(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                if(e.RowIndex < 0)
                {
                    return;
                }

                DataGridViewRow DataRow = dataGridView1.Rows[e.RowIndex];
                int RowId = (int)DataRow.Cells[0].Value;

                Cls_Response? cls_res = null;
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer",Properties.Settings.Default.AuthToken);  //Auth token to header.
                HttpResponseMessage httpResponse = await httpClient.DeleteAsync(EndpointClass.DeleteRowsUrl + RowId);
                int StatusCode = (int)httpResponse.StatusCode;

                switch (StatusCode)
                {
                    case 200:
                        DataGridViewCreate();
                        cls_res = await httpResponse.Content.ReadFromJsonAsync<Cls_Response>();
                        MessageBox.Show(cls_res?.StatusMessage, "Success");
                        break;
                    case 401:
                        MessageBox.Show("Authentication failed. Either token has expired or it is manipulated!","Auth Failed");
                        break;
                    case 404:
                        cls_res = await httpResponse.Content.ReadFromJsonAsync<Cls_Response>();
                        MessageBox.Show(cls_res?.StatusMessage, "Not Found Error");
                        break;
                    case 500:
                        cls_res = await httpResponse.Content.ReadFromJsonAsync<Cls_Response>();
                        MessageBox.Show(cls_res?.StatusMessage, "Internal Server Error");
                        break;
                    default:
                        cls_res = await httpResponse.Content.ReadFromJsonAsync<Cls_Response>();
                        MessageBox.Show(cls_res?.StatusMessage, "Unknown Backend Error");
                        break;
                }
            }
        }

    }
}
