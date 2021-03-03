using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApi_Dap.Models;

namespace WebApi_Dap.Repository
{
    public class TestRepository
    {
        public SqlConnection con;
        private void Connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["Test"].ToString();
            con = new SqlConnection(constr);
        }
        public void Add(TestClass test)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@fname", test.fname);
                param.Add("@lname", test.lname);
                param.Add("@email", test.email);
                Connection();
                con.Open();
                con.Execute("sp_add", param, commandType: CommandType.StoredProcedure);
                con.Close();
            }
            catch (Exception ex)
            {throw ex;}
        }

        public void Update(TestClass test)
        {
            try
            {
                Connection();
                con.Open();
                con.Execute("sp_update", test, commandType: CommandType.StoredProcedure);
                con.Close();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public List<TestClass> GetAll()
        {
            try
            {
                var sql = "exec sp_view";
                Connection();
                con.Open();
                var result = con.Query<TestClass>(sql).AsList();

                var res = new List<TestClass>();
                //var res = con.QueryMultiple("sp_view;sp_view;sp_view").Read<TestClass>().First();

                con.Close();
                return result;
            }
            catch (Exception ex)
            { throw ex; }

            //try
            //{
            //    Connection();
            //    con.Open();
            //    IList<TestClass> testlist = con.Query<TestClass>("sp_view", commandType:CommandType.StoredProcedure).ToList();
            //    con.Close();
            //    return testlist.ToList();
            //}
            //catch (Exception ex)
            //{ throw ex; }

        }
        public bool Delete(int id)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id", id);
                Connection();
                con.Open();
                con.Execute("sp_delete", param, commandType: CommandType.StoredProcedure);
                con.Close();
                return true;
            }
            catch (Exception)
            { return false; }
        }


    }
}