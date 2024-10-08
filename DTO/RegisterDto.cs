﻿using System.ComponentModel.DataAnnotations;

namespace CloudIABackend.DTO
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(32, MinimumLength = 8)]
        public string Password { get; set; }
    }
}
