using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarterMvc.Web.Models
{
    [Table("dms.DocumentTypes")]
    public class DocumentType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(3)]
        public string Code { get; set; }
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }
        [Required]
        [DefaultValue(true)]
        public bool IsActive { get; set; }
        [NotMapped]
        public string CodeAndDescription
        {
            get { return string.Format("{0} - {1}", Code, Description); }
        }
    }
}