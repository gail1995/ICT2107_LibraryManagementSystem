namespace LibraryPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        bookID = c.String(nullable: false, maxLength: 128),
                        transactionID = c.String(),
                        bookTitle = c.String(),
                        author = c.String(),
                        loanStatus = c.String(),
                    })
                .PrimaryKey(t => t.bookID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
