using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_FORM
{
    public partial class Add : System.Web.UI.Page
    {
        string API_URL = "https://localhost:44332/";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            Save();
        }


        protected void Save()
        {
            //TestClass testclass = new TestClass()
            //{
            //    fname = fname.Value,
            //    lname = lname.Value,
            //    email = email.Value,
            //};


            //HttpClient webClient = new HttpClient();
            ////Post
            //HttpResponseMessage response = webClient.PostAsync("https://localhost:44332/api/TestAPI", new StringContent(
            //    new JavaScriptSerializer().Serialize(testclass), Encoding.UTF8, "application/json")).Result;
            //response.EnsureSuccessStatusCode();

            //if (response.IsSuccessStatusCode)
            //{

            //}
            //Response.Redirect("~/Default.aspx");



            string stat = string.Empty;
            Uri uri = new Uri(string.Format(API_URL + "api/TestAPI/"));

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);

            request.Method = "POST";
            request.ProtocolVersion = HttpVersion.Version11;
            //request.Host = API_URL.ToString();
            request.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";

            request.ServerCertificateValidationCallback = delegate { return true; };

            var encoding = new UTF8Encoding(); // iso-8859-1 
            var bytes = Encoding.GetEncoding("UTF-8").GetBytes("fname" + "=" + fname.Value +
                                                               "&" + "lname" + "=" + lname.Value +
                                                               "&" + "email" + "=" + email.Value
                                                               );
            request.ContentLength = bytes.Length;

            using (var writeStream = request.GetRequestStream()) { writeStream.Write(bytes, 0, bytes.Length); }

            StreamReader rsps = new StreamReader(request.GetResponse().GetResponseStream());
            stat = rsps.ReadToEnd().ToString();

            if (stat == "1")
            { Response.Redirect("~/Default.aspx");  }

        }
    }
}    