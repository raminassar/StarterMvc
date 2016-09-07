using StarterMvc.Web.Core.Repositories;

namespace StarterMvc.Web.Core
{
    public interface IUnitOfWork
    {
        IOrganizationUnitRepository OrganizationUnits { get; }
        void Commit();
    }
}
