using StarterMvc.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StarterMvc.Web.ViewModels
{
    public class DocumentViewModel
    {
        [Required]
        [Display(Name = "Employee Number")]
        public string EmployeeNumber { get; set; }
        [Required]
        [Display(Name = "Document Type")]
        public int DocumentTypeId { get; set; }
        public string DocumentName { get; set; }

        public string Content { get; set; }
        public string ContentType { get; set; }
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        public string DocumentType { get; set; }
        public IEnumerable<Document> Documents { get; set; }
        public IEnumerable<DocumentType> DocumentTypes { get; set; }
    }
}