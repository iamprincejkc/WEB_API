using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WEB_API.Models
{
    public class DbModel
    {
        string strConString = @"Data Source=RDPIMIS2;Initial Catalog=Test;Integrated Security=True";
        public List<TestClass> GetData()
        {
            using (SqlConnection con = new SqlConnection(strConString))
            {

                DataTable dt = new DataTable();
                List<TestClass> details = new List<TestClass>();

                SqlCommand cmd = new SqlCommand("sp_view", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    TestClass obj = new TestClass();

                    obj.id = Convert.ToInt32(dr["id"]);
                    obj.fname = dr["fname"].ToString();
                    obj.lname = dr["lname"].ToString();
                    obj.email = dr["email"].ToString();

                    details.Add(obj);
                }
                return details;
            }
        }

        public List<TestClass> GetDataByID(int id)
        {
            using (SqlConnection con = new SqlConnection(strConString))
            {

                DataTable dt = new DataTable();
                List<TestClass> details = new List<TestClass>();

                SqlCommand cmd = new SqlCommand("sp_viewbyid", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id", id));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    TestClass obj = new TestClass();

                    obj.fname = dr["fname"].ToString();
                    obj.lname = dr["lname"].ToString();
                    obj.email = dr["email"].ToString();

                    details.Add(obj);
                }


                return details;
            }
        }

        public int DeleteByID(int id)
        {
            using (SqlConnection con = new SqlConnection(strConString))
            {
                con.Open();
                DataTable dt = new DataTable();
                List<TestClass> details = new List<TestClass>();

                SqlCommand cmd = new SqlCommand("sp_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id", id));

                var cmdresp = cmd.ExecuteNonQuery();

                con.Close();

                return cmdresp;
            }
        }

        public int Add(TestClass testclass)
        {
            using (SqlConnection con = new SqlConnection(strConString))
            {
                con.Open();
                DataTable dt = new DataTable();
                List<TestClass> details = new List<TestClass>();

                SqlCommand cmd = new SqlCommand("sp_add", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add(new SqlParameter("@fname", testclass.fname));
                cmd.Parameters.Add(new SqlParameter("@lname", testclass.lname));
                cmd.Parameters.Add(new SqlParameter("@email", testclass.email));

                var output = cmd.ExecuteNonQuery();

                con.Close();

                return Convert.ToInt32(output);

            }
        }


        public int Update(TestClass testclass)
        {
            using (SqlConnection con = new SqlConnection(strConString))
            {
                con.Open();
                DataTable dt = new DataTable();
                List<TestClass> details = new List<TestClass>();

                SqlCommand cmd = new SqlCommand("sp_update", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id", testclass.id));
                cmd.Parameters.Add(new SqlParameter("@fname", testclass.fname));
                cmd.Parameters.Add(new SqlParameter("@lname", testclass.lname));
                cmd.Parameters.Add(new SqlParameter("@email", testclass.email));

                var cmdresp = cmd.ExecuteNonQuery();

                con.Close();

                return cmdresp;

            }
        }
        public List<TestClass> Search(string key)
        {
            using (SqlConnection con = new SqlConnection(strConString))
            {

                DataTable dt = new DataTable();
                List<TestClass> details = new List<TestClass>();

                SqlCommand cmd = new SqlCommand("sp_search", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@key", key));

                return details;
            }

        }
    }
}