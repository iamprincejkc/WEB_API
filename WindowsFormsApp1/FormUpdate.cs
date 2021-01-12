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
    public partial class FormUpdate : MetroFramework.Forms.MetroForm
    {
        public FormUpdate()
        {
            InitializeComponent();
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(txtfname.Text) || string.IsNullOrEmpty(txtlname.Text) || string.IsNullOrWhiteSpace(txtemail.Text)))
            {
                TestClass testlist = new TestClass()
                {
                    id =    Form1.id,
                    fname = txtfname.Text.Trim(),
                    lname = txtlname.Text.Trim(),
                    email = txtemail.Text.Trim()
                };



                Update(testlist);
                MessageBox.Show("Inserted Successfully", "Success . . .",  MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Data Input(s) Error", "Error . . .",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Update(TestClass test)
        {
            HttpClient webClient = new HttpClient();
            HttpResponseMessage response = webClient.PutAsync("https://localhost:44332/api/TestAPI", new StringContent(
                new JavaScriptSerializer().Serialize(test), Encoding.UTF8, "application/json")).Result;
            response.EnsureSuccessStatusCode();
        }

        private void txtemail_Click(object sender, EventArgs e)
        {

        }

        private void txtlname_Click(object sender, EventArgs e)
        {

        }
    }
}
