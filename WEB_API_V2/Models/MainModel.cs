using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_API_V2.Models
{
    public class MainModel
    {
        public List<ProductModel> Product { get; set; }
        public List<StaffModel> Staff { get; set; }
        public List<StoreModel> Store { get; set; }
    }
}