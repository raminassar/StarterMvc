using System.ComponentModel.DataAnnotations;

namespace StarterMvc.Web.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}