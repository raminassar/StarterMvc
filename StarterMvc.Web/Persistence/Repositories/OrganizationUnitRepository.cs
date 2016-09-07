using StarterMvc.Web.Core.Models;
using StarterMvc.Web.Core.Repositories;
using System.Data.Entity;

namespace StarterMvc.Web.Persistence.Repositories
{
    public class OrganizationUnitRepository : BaseRepository<OrganizationUnit>, IOrganizationUnitRepository
    {
        public OrganizationUnitRepository(DbContext context) : base(context)
        {
        }
    }
}