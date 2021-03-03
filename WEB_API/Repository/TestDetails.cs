using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEB_API.Models;
using WEB_API.Services;

namespace WEB_API.Repository
{
    public class TestDetails : ITestDetails
    {
        TestEntities db = new TestEntities(); //ADO ENTITY MODEL
        //DbModel db2 = new DbModel(); //SQL CONNECTION
        public int DeleteDataById(int id)
        {
            var result = db.sp_delete(id);
            if (result > 0)
                return result;
            return 0;
        }

        public List<sp_view_Result> GetData()
        {
            var result = db.sp_view().ToList();
            return result;
        }

        public sp_viewbyid_Result GetDataByID(int id)
        {
            var result = db.sp_viewbyid(id).FirstOrDefault();
            return result;
        }

        public int PostData(TestClass test)
        {
            
            var result = db.sp_add(test.fname, test.lname, test.email);
            if(result>0)
                return result;
            return 0;
        }

        public List<sp_search_Result> GetSearchData(string key)
        {
            var result = db.sp_search(key.Trim()).ToList();
            return result;
        }

        public int PutData(TestClass test)
        {
            var result = db.sp_update(test.id, test.fname, test.lname, test.email);
            if (result > 0)
                return result;
            return 0;
        }
    }
}