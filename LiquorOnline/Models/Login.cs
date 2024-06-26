﻿using System.ComponentModel.DataAnnotations;

namespace LiquorOnline.Models
{
    public class Login
    {
        [Required]
        [Display(Name = "Username")]
        public string? UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        public bool RememberLogin { get; set; }
        public string? ReturnUrl { get; set; }
    }
}
