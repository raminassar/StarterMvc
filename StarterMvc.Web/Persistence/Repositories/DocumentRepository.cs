using StarterMvc.Web.Core.Models;
using StarterMvc.Web.Core.Repositories;
using System.Data.Entity;

namespace StarterMvc.Web.Persistence.Repositories
{
    public class DocumentRepository : BaseRepository<Document>, IDocumentRepository
    {
        public DocumentRepository(DbContext context) : base(context)
        {

        }
    }
}