namespace StarterMvc.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrganizationUnits : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "hrm.OrganizationUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 4),
                        Description = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("hrm.OrganizationUnits");
        }
    }
}
