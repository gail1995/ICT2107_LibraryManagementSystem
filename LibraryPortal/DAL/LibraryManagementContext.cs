using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LibraryPortal.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LibraryPortal.DAL
{
    public class LibraryManagementContext : IdentityDbContext<ApplicationUser>
    {
        public LibraryManagementContext() : base("LibraryManagementDB")
        {

        }
        public DbSet<Book> Books { get; set; }

        public System.Data.Entity.DbSet<LibraryPortal.Models.Transaction> Transactions { get; set; }
    }
}