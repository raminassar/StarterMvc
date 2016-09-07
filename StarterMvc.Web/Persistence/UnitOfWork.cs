using StarterMvc.Web.Core;
using StarterMvc.Web.Core.Repositories;
using StarterMvc.Web.Persistence.Repositories;

namespace StarterMvc.Web.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IOrganizationUnitRepository OrganizationUnits { get; private set; }
        public IDocumentTypeRepository DocumentTypes { get; private set; }
        public IDocumentRepository Documents { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            OrganizationUnits = new OrganizationUnitRepository(context);
            DocumentTypes = new DocumentTypeRepository(context);
            Documents = new DocumentRepository(context);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}