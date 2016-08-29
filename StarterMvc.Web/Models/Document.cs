using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarterMvc.Web.Models
{
    [Table("dms.Documents")]
    public class Document
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string DocumentName { get; set; }
        [StringLength(100)]
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public string OriginalDocumentType { get; set; }
        public int DocumentTypeId { get; set; }
        [ForeignKey("DocumentTypeId")]
        public virtual DocumentType DocumentType { get; set; }
        public string EmployeeNumber { get; set; }
    }
}