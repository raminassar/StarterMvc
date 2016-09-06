using System.Security.Claims;
using System.Security.Principal;

namespace StarterMvc.Web.Models.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetUserFirstName(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("FirstName");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }

        public static string GetUserLastName(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("LastName");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }

        public static string GetUserTheme(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("Theme");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }

        public static string GetUserEmail(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("Email");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }
    }
}