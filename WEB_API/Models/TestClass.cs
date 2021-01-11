using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB_API.Models
{
    public class TestClass
    {
        public int id { get; set; }
        [Required(ErrorMessage = "The Firstname is required")]
        public string fname { get; set; }
        [Required(ErrorMessage = "The Lastname is required")]
        public string lname { get; set; }
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email { get; set; }
    }
}