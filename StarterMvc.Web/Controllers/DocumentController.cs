using StarterMvc.Web.Core.Models;
using StarterMvc.Web.Core.ViewModels;
using StarterMvc.Web.Persistence;
using System.Linq;
using System.Web.Mvc;

namespace StarterMvc.Web.Controllers
{
    public class DocumentController : Controller
    {
        ApplicationDbContext _context = new ApplicationDbContext();
        // GET: Document
        [Authorize]
        public ActionResult Index(string employeeNumber, int documentTypeId = 0)
        {
            //return View();
            var documentViewModel = new DocumentViewModel();
            documentViewModel.DocumentTypes = _context.DocumentTypes.Where(x => x.IsActive).OrderBy(x => x.Code);
            documentViewModel.Documents = _context.Documents
                .Where(x => x.EmployeeNumber == employeeNumber &&
                      x.DocumentTypeId == documentTypeId);

            return View(documentViewModel);
        }
        [Authorize]
        public ActionResult Download(int id)
        {
            var document = new Document();
            document = _context.Documents.Find(id);

            byte[] contents = document.Content;
            return File(contents, document.ContentType);
        }

    }
}