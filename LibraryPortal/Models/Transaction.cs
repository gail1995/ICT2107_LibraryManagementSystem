using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryPortal.Models
{
    public class Transaction
    {


        public int? bookID { get; set; }
        [Key]
        [ForeignKey("bookID")]
        public virtual Book BID { get; set; }

        public int ID { get; set; }
        public String TransactionStatus { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime transactionDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime dueDate { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        //foreign key for Book
        

        //public virtual Book Book { get; set; }
        
    }
}