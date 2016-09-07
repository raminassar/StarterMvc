namespace StarterMvc.Web.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddUsersProfile : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "mem.UserProfiles",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    FirstName = c.String(),
                    LastName = c.String(),
                    UserPhoto = c.Binary(),
                })
                .PrimaryKey(t => t.Id);

            AddColumn("dbo.AspNetUsers", "ProfileId", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "ProfileId");
            AddForeignKey("dbo.AspNetUsers", "ProfileId", "mem.UserProfiles", "Id", cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "ProfileId", "mem.UserProfiles");
            DropIndex("dbo.AspNetUsers", new[] { "ProfileId" });
            DropColumn("dbo.AspNetUsers", "ProfileId");
            DropTable("mem.UserProfiles");
        }
    }
}
