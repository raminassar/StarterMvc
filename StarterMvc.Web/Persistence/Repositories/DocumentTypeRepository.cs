using StarterMvc.Web.Core.Models;
using StarterMvc.Web.Core.Repositories;
using System.Data.Entity;

namespace StarterMvc.Web.Persistence.Repositories
{
    public class DocumentTypeRepository : BaseRepository<DocumentType>, IDocumentTypeRepository
    {
        public DocumentTypeRepository(DbContext context) : base(context)
        {

        }
    }
}