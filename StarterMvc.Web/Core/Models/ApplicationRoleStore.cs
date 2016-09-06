using System;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace StarterMvc.Web.Core.Models
{
    public class ApplicationRoleStore
        : RoleStore<ApplicationRole, int, ApplicationUserRole>,
            IQueryableRoleStore<ApplicationRole, int>,
            IRoleStore<ApplicationRole, int>, IDisposable
    {
        public ApplicationRoleStore()
            : base(new IdentityDbContext())
        {
            base.DisposeContext = true;
        }

        public ApplicationRoleStore(DbContext context)
            : base(context)
        {
        }
    }
}