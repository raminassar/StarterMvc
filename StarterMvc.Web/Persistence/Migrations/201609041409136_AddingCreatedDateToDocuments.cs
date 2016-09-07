namespace StarterMvc.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingCreatedDateToDocuments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dms.Documents", "CreatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dms.Documents", "CreatedDate");
        }
    }
}
