using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web.Services;

namespace Web_Service
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    //[System.Web.Script.Services.ScriptService]
    public class Service1 : WebService
    {
        
        string ConnectionString = @"Data Source=RDPIMIS2;Initial Catalog=Test;Integrated Security=True";
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public DataSet GetLatestData()
        {
            SqlConnection sqlConnection1 = new SqlConnection();
            sqlConnection1.ConnectionString = ConnectionString;
            sqlConnection1.Open();
            string select = "select * from table1 ";
            SqlDataAdapter da = new SqlDataAdapter(select, sqlConnection1);
            DataSet ds = new DataSet();
            da.Fill(ds, "table1");
            Debug.WriteLine(ds.Tables.Count);
            sqlConnection1.Close();
            return (ds);
        }
    }
}
