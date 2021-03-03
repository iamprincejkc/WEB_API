using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FOA_ASP_MVC.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryPoster { get; set; }
        public string ImageUrl { get; set; }
    }
}