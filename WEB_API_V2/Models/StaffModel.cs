using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_API_V2.Models
{
    public class StaffModel
    {
        public int staffid { get; set; }
        public int storeid { get; set; }
        public string staffname { get; set; }
        public string staffaddress { get; set; }
    }
}