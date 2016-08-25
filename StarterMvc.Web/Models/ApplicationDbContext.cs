using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace StarterMvc.Web.Models
{
    public class ApplicationDbContext
        : IdentityDbContext<ApplicationUser, ApplicationRole, int,
            ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }

        static ApplicationDbContext()
        {
            Database.SetInitializer<ApplicationDbContext>(new ApplicationDbInitializer());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public virtual IDbSet<ApplicationGroup> ApplicationGroups { get; set; }

        // Override OnModelsCreating:
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<ApplicationGroup>()
                .HasMany<ApplicationUserGroup>((ApplicationGroup g) => g.ApplicationUsers)
                .WithRequired().HasForeignKey<int>((ApplicationUserGroup ag) => ag.ApplicationGroupId);
            modelBuilder.Entity<ApplicationUserGroup>()
                .HasKey((ApplicationUserGroup r) =>
                    new
                    {
                        ApplicationUserId = r.ApplicationUserId,
                        ApplicationGroupId = r.ApplicationGroupId
                    }).ToTable("dbo.ApplicationUserGroups");

            modelBuilder.Entity<ApplicationGroup>()
                .HasMany<ApplicationGroupRole>((ApplicationGroup g) => g.ApplicationRoles)
                .WithRequired().HasForeignKey<int>((ApplicationGroupRole ap) => ap.ApplicationGroupId);
            modelBuilder.Entity<ApplicationGroupRole>().HasKey((ApplicationGroupRole gr) =>
                new
                {
                    ApplicationRoleId = gr.ApplicationRoleId,
                    ApplicationGroupId = gr.ApplicationGroupId
                }).ToTable("dbo.ApplicationGroupRoles");

        }
    }
}