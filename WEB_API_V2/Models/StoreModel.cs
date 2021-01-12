using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_API_V2.Models
{
    public class StoreModel
    {
        public int storeid { get; set; }
        public string storename { get; set; }
        public string storelocation { get; set; }
        public List<ProductModel> Product { get; set; }
        public List<StaffModel> Staff { get; set; }
    }
}