namespace StarterMvc.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDocumentType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dms.DocumentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 3),
                        Description = c.String(nullable: false, maxLength: 255),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dms.Documents", "OriginalDocumentType", c => c.String());
            AddColumn("dms.Documents", "DocumentTypeId", c => c.Int(nullable: false));
            CreateIndex("dms.Documents", "DocumentTypeId");
            AddForeignKey("dms.Documents", "DocumentTypeId", "dms.DocumentTypes", "Id", cascadeDelete: true);
            DropColumn("dms.Documents", "DocumentType");
        }
        
        public override void Down()
        {
            AddColumn("dms.Documents", "DocumentType", c => c.Int(nullable: false));
            DropForeignKey("dms.Documents", "DocumentTypeId", "dms.DocumentTypes");
            DropIndex("dms.Documents", new[] { "DocumentTypeId" });
            DropColumn("dms.Documents", "DocumentTypeId");
            DropColumn("dms.Documents", "OriginalDocumentType");
            DropTable("dms.DocumentTypes");
        }
    }
}
