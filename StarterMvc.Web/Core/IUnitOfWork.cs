using StarterMvc.Web.Core.Repositories;

namespace StarterMvc.Web.Core
{
    public interface IUnitOfWork
    {
        IOrganizationUnitRepository OrganizationUnits { get; }
        IDocumentTypeRepository DocumentTypes { get; }
        IDocumentRepository Documents { get; }
        void Commit();
    }
}
