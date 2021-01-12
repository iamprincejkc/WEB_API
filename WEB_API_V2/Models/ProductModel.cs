using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_API_V2.Models
{
    public class ProductModel
    {
        public int productid { get; set; }
        public int storeid { get; set; }
        public int staffid { get; set; }
        public string productname { get; set; }
        public int productquantity { get; set; }
        public decimal productprice { get; set; }
    }
}