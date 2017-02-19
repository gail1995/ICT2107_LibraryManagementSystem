using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryPortal.Models
{
    public class Book
    {
        
        [Key]
        public int ID { get; set; } //Primary keys
        //Book variables
        
        public String bookTitle { get; set; }
        public String author { get; set; }
        public String genre { get; set; }
        public int pubishedYear { get; set; }
        public String loanStatus { get; set; }


    }
}