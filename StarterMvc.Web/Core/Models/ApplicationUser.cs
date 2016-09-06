using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace StarterMvc.Web.Core.Models
{
    public class ApplicationUser : IdentityUser<int, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>, IUser<int>
    {
        public async Task<ClaimsIdentity>
            GenerateUserIdentityAsync(UserManager<ApplicationUser, int> manager)
        {
            var userIdentity = await manager
                .CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            userIdentity.AddClaim(new Claim("FirstName", this.Profile.FirstName.ToString()));
            userIdentity.AddClaim(new Claim("LastName", this.Profile.LastName.ToString()));
            userIdentity.AddClaim(new Claim("Email", this.Email.ToString()));
            userIdentity.AddClaim(new Claim("Theme", this.Profile.Theme.ToString()));

            return userIdentity;
        }

        public int ProfileId { get; set; }
        [ForeignKey("ProfileId")]
        public virtual UserProfile Profile { get; set; }
    }
}