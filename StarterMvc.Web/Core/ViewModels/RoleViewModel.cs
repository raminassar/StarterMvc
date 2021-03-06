﻿using System.ComponentModel.DataAnnotations;

namespace StarterMvc.Web.Core.ViewModels
{
    public class RoleViewModel
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "RoleName")]
        public string Name { get; set; }
    }

    // Groups    
}