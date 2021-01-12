using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Init MyService to the Web Service
            ServiceReference1.Service1SoapClient service = new ServiceReference1.Service1SoapClient();

            // Call the GetData method in the Web Service
            DataSet ds = service.GetLatestData();

            // Bind the DataSet to the Grid
            //dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "table1";
        }
    }
}
