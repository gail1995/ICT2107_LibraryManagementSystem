using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LibraryPortal.Models
{
    public class Users
    {   
        [Required]
        public String loginID { get; set; }
        [Required]
        public String password { get; set; }
        public String name { get; set; }
        public String role { get; set; }

    }
}