using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryPortal.Models
{
    public class Book
    {   
        public String bookID { get; set; } //Primary keys
        public String transactionID { get; set; } //foreign keys 

        //Book variables
        
        public String bookTitle { get; set; }
        public String author { get; set; }
        public String loanStatus { get; set; }


    }
}