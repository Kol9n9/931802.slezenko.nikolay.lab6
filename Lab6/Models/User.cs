using System;
using System.ComponentModel.DataAnnotations;

namespace Lab6.Models
{
    public class User
    {
        public Guid Id { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        public bool IsAdmin { get; set; }
    }
}