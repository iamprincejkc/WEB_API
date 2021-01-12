using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAdd : MetroFramework.Forms.MetroForm
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(txtfname.Text)||string.IsNullOrEmpty(txtlname.Text)||string.IsNullOrWhiteSpace(txtemail.Text)))
            {
                TestClass testlist = new TestClass()
                {
                    fname = txtfname.Text.Trim(),
                    lname = txtlname.Text.Trim(),
                    email = txtemail.Text.Trim()
                };
                Insert(testlist);
                MessageBox.Show("Inserted Successfully", "Success . . .", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Data Input(s) Error", "Error . . .", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Insert(TestClass test)
        {

            HttpClient webClient = new HttpClient();
            //Post
            HttpResponseMessage response =  webClient.PostAsync("https://localhost:44332/api/TestAPI", new StringContent(
                new JavaScriptSerializer().Serialize(test), Encoding.UTF8, "application/json")).Result;
            response.EnsureSuccessStatusCode();

            //get response success data ex:1
            var testJsonString =  response.Content.ReadAsStringAsync().Result;
            MessageBox.Show("Your response data is: " + testJsonString);


        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
        }
    }
}
