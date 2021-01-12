using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int id = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            GetDataGrid();
            TxtSearchAutoComplete();
        }
        public async void TxtSearchAutoComplete()
        {
            try
            {
                //string apiUrl = "https://localhost:44332/api/TestAPI";

                //Load All Data in Datagridview
                HttpClient webClient = new HttpClient();
                Uri uri = new Uri("https://localhost:44332/api/TestAPI");
                HttpResponseMessage response = await webClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var _Data = JsonConvert.DeserializeObject<List<TestClass>>(jsonString);
                    AutoCompleteStringCollection MySearchCollection = new AutoCompleteStringCollection(); 
                    foreach(var item in _Data)
                    {
                        MySearchCollection.Add(item.fname+" "+item.lname);
                    }
                    txtsearch.AutoCompleteCustomSource = MySearchCollection;
                    clear();
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public async void GetDataGrid()
        {
            try
            {
                //string apiUrl = "https://localhost:44332/api/TestAPI";

                //Load All Data in Datagridview
                HttpClient webClient = new HttpClient();
                Uri uri = new Uri("https://localhost:44332/api/TestAPI");
                HttpResponseMessage response = await webClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var _Data = JsonConvert.DeserializeObject<List<TestClass>>(jsonString);
                    dgvTest.DataSource = _Data;
                    clear();
                }
            }
            catch (WebException ex)
            {

            }
           
          
        }

        public async void GetDataGridByKey(string key)
        {
            //search
            HttpClient webClient = new HttpClient();
            Uri uri = new Uri("https://localhost:44332/api/TestAPI/search/" + key);
            HttpResponseMessage response = await webClient.GetAsync(uri);
            var jsonString = await response.Content.ReadAsStringAsync();
            if (jsonString != null)
            {
                var _Data = JsonConvert.DeserializeObject(jsonString);
                dgvTest.DataSource = _Data;
            }
        }
        public async void DeleteDataByID(int id)
        {
            DialogResult dialogResult = MessageBox.Show("Delete Data ?", "Delete . . .", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (dgvTest.SelectedRows.Count > 0)
                {
                    HttpClient webClient = new HttpClient();
                    Uri uri = new Uri("https://localhost:44332/api/TestAPI/" + id);
                    HttpResponseMessage response = await webClient.DeleteAsync(uri);
                    GetDataGrid();
                }
            }
        }
        private void dgvTest_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void clear()
        {
            //RESET Textboxes & id
            txtfname.Text = txtlname.Text = txtemail.Text = txtsearch.Text = "";
            id = 0;
        }


        private void btnrefresh_Click(object sender, EventArgs e)
        {
            GetDataGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FormAdd().ShowDialog();
            GetDataGrid();
        }


        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtsearch.Text.Trim()))
            { GetDataGridByKey(txtsearch.Text.Trim()); }
            else
            { GetDataGrid(); }
        }

        private void dgvTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDataByID(id);
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new FormUpdate().ShowDialog();
            GetDataGrid();
        }

        private void dgvTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvTest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Select Data ?", "Select . . .", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (dgvTest.SelectedRows.Count > 0)
                {
                    id = int.Parse(dgvTest.CurrentRow.Cells[0].Value.ToString());
                    txtfname.Text = dgvTest.CurrentRow.Cells[1].Value.ToString();
                    txtlname.Text = dgvTest.CurrentRow.Cells[2].Value.ToString();
                    txtemail.Text = dgvTest.CurrentRow.Cells[3].Value.ToString();

                }
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}
