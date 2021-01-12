using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Drawing;

namespace WEB_FORM
{
    public partial class Default : System.Web.UI.Page
    {
        string API_URL = "https://localhost:44332/";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetDataGrid();
            }
        }
        public void GetDataGrid()
        {
            string val = string.Empty;

            Uri uri = new Uri(string.Format(API_URL + "api/TestAPI/"));
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "GET";
            request.ProtocolVersion = HttpVersion.Version11;
            //request.Host = API_URL.ToString();
            request.ContentType = "application/json";
            request.ServerCertificateValidationCallback = delegate { return true; };

            StreamReader rsps = new StreamReader(request.GetResponse().GetResponseStream());

            val = rsps.ReadToEnd();

            GridView1.DataSource = (new JavaScriptSerializer()).Deserialize<List<TestClass>>(val);
            GridView1.DataBind();
            GridView1.SelectedIndex = -1;

            //string apiUrl = "https://localhost:44332/";
            //WebClient client = new WebClient();
            ////client.Headers["Content-type"] = "application/json";
            ////client.Encoding = Encoding.UTF8;
            //string json = client.DownloadString(apiUrl + "api/TestAPI");

            //GridView1.DataSource = (new JavaScriptSerializer()).Deserialize<List<TestClass>>(json);
            //GridView1.DataBind();
        }


        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton LinkButton1 = (LinkButton)sender;
            GridViewRow row = (GridViewRow)LinkButton1.NamingContainer;
            string id = row.Cells[3].Text;
            Delete(id);
            Response.Redirect("~/Default.aspx");

            //if (GridView1.SelectedRow != null)
            //{
            //    GridViewRow row = GridView1.SelectedRow;
            //    string id = row.Cells[3].Text;
            //        Delete(id);
            //        Response.Redirect("~/Default.aspx");
            //}
        }

        protected void Delete(string id)
        {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://localhost:44332/api/TestAPI/" + id);
                request.Method = "Delete";
                request.ProtocolVersion = HttpVersion.Version11;
                //request.Host = API_URL.ToString();
                request.ContentType = "application/json";
                request.KeepAlive = true;
                Stream dataStream = request.GetRequestStream();
                dataStream.Close();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string returnString = response.StatusCode.ToString();

                if (returnString == "1")
                {
                    GridView1.SelectedIndex = -1;
                    GetDataGrid();
                }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GetDataGrid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GetDataGrid();
        }


        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GetDataGrid();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            GridViewRow row = GridView1.Rows[e.RowIndex];
            string sid = ((TextBox)(row.Cells[3].Controls[0])).Text;
            string sfname = ((TextBox)(row.Cells[4].Controls[0])).Text;
            string slname = ((TextBox)(row.Cells[5].Controls[0])).Text;
            string semail = ((TextBox)(row.Cells[6].Controls[0])).Text;


            TestClass test = new TestClass()
            {
                id = int.Parse(sid),
                fname = sfname,
                lname = slname,
                email = semail
            };

            Update(test);
        }


        protected void Update(TestClass testclass)
        {
            string stat = string.Empty;
            Uri uri = new Uri(string.Format(API_URL + "api/TestAPI/"));

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);

            request.Method = "PUT";
            request.ProtocolVersion = HttpVersion.Version11;
            //request.Host = API_URL.ToString();
            request.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";

            request.ServerCertificateValidationCallback = delegate { return true; };

            var encoding = new UTF8Encoding(); // iso-8859-1 
            var bytes = Encoding.GetEncoding("UTF-8").GetBytes("id" + "=" + testclass.id +
                                                               "&" + "fname" + "=" + testclass.fname +
                                                               "&" + "lname" + "=" + testclass.lname +
                                                               "&" + "email" + "=" + testclass.email
                                                               );
            request.ContentLength = bytes.Length;

            using (var writeStream = request.GetRequestStream())
            {   writeStream.Write(bytes, 0, bytes.Length);  }

            StreamReader rsps = new StreamReader(request.GetResponse().GetResponseStream());
            stat = rsps.ReadToEnd().ToString();

            if (stat == "1")
            {
                Response.Redirect("~/Default.aspx");
            }

            //HttpClient cons = new HttpClient();
            //cons.BaseAddress = new Uri("https://localhost:44332/");
            //cons.DefaultRequestHeaders.Accept.Clear();
            //cons.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            //var content = new StringContent(JsonConvert.SerializeObject(testclass), Encoding.UTF8, "application/json");
            //HttpResponseMessage res =  cons.PutAsync("api/TestAPI/", content).Result;

            //Reset the edit index.
            GridView1.EditIndex = -1;

            GetDataGrid();

        }

        protected void add_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/Add.aspx");
        }

        protected void LBDetails_Click(object sender, EventArgs e)
        {
            LinkButton LinkButton1 = (LinkButton)sender;
            GridViewRow row = (GridViewRow)LinkButton1.NamingContainer;
            string id = row.Cells[3].Text;
            if (!string.IsNullOrEmpty(id))
            {
                Response.Redirect("Details.aspx?id=" + id);
            }


            //if (GridView1.SelectedRow != null)
            //{
            //    GridViewRow row = GridView1.SelectedRow;
            //    string id = row.Cells[3].Text;
            //    if (!string.IsNullOrEmpty(id))
            //    {
            //        Response.Redirect("Details.aspx?id=" + id);
            //    }
            //}
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            string id = row.Cells[3].Text;
            if (!string.IsNullOrEmpty(id))
            {
                string sid = row.Cells[3].Text;
                string sfname = row.Cells[4].Text;
                string slname = row.Cells[5].Text;
                Label1.Text = sfname+" "+slname;
                Label3.Text = sid;
            }
            ScriptManager.RegisterStartupScript(this, GetType(), "displayalertmessage", "$('#myModal').modal()", true);//show the modal
            GridView1.SelectedIndex = -1;

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
        }
    }
}