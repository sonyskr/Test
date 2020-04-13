using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Test.Models
{
    public class Account
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public DateTime LastLoginDate {get; set;}
        public int LoginFailedCount {get; set;}
        public bool AccountLocked {get; set;}
    }

}