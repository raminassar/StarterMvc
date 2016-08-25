using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarterMvc.Web.Models
{
    [Table("mem.UserProfiles")]
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] UserPhoto { get; set; }
    }
}