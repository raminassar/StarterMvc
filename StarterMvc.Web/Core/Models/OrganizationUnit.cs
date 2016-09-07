using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarterMvc.Web.Core.Models
{
    [Table("hrm.OrganizationUnits")]
    public class OrganizationUnit
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(4, ErrorMessage = "String length must be 4.")]
        public string Code { get; set; }
        public string Description { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}