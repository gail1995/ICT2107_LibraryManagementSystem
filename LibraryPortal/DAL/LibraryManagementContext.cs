using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LibraryPortal.Models;

namespace LibraryPortal.DAL
{
    public class LibraryManagementContext : DbContext
    {
        public LibraryManagementContext() : base("LibraryManagementDB")
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}