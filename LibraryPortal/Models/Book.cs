using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryPortal.Models
{
    public class Book
    {
        
        public String transactionID { get; set; }

        //Book variables
        public String bookID { get; set; }
        public String bookTitle { get; set; }
        public String author { get; set; }
        public String loanStatus { get; set; }


    }
}