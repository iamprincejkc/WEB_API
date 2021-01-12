using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_FORM
{
    public partial class Details : Page
    {
        string API_URL = "https://localhost:44332/";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
            string id = Request.QueryString["id"].ToString();
            GetDataById(id);
        }

        public void GetDataById(string id)
        {
            string val = string.Empty;

            Uri uri = new Uri(string.Format(API_URL + "api/TestAPI/" + id));
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "GET";
            request.ProtocolVersion = HttpVersion.Version11;
            //request.Host = API_URL.ToString();
            request.ContentType = "application/json";
            request.ServerCertificateValidationCallback = delegate { return true; };

            StreamReader response = new StreamReader(request.GetResponse().GetResponseStream());
            
            val = response.ReadToEnd();
            TestClass results = JsonConvert.DeserializeObject<TestClass>(val);
                email.InnerText = results.email;
                fname.InnerText = results.fname+ " " + results.lname;


        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

    }
}