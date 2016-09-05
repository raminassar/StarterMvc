namespace StarterMvc.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingUserProfileTheme : DbMigration
    {
        public override void Up()
        {
            AddColumn("mem.UserProfiles", "Theme", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("mem.UserProfiles", "Theme");
        }
    }
}
