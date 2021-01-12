using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB_API.Models;

namespace WEB_API.Services
{
    public interface ITestDetails
    {
        List<sp_view_Result> GetData();
        sp_viewbyid_Result GetDataByID(int id);
        int DeleteDataById(int id);
        int PostData(TestClass test);
        int PutData(TestClass test);
        List<sp_search_Result> GetSearchData(string key);
    }
}
