namespace StarterMvc.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dms.Documents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DocumentName = c.String(maxLength: 255),
                        ContentType = c.String(maxLength: 100),
                        Content = c.Binary(),
                        DocumentType = c.Int(nullable: false),
                        EmployeeNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dms.Documents");
        }
    }
}
