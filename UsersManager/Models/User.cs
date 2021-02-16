using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UsersManager.Models
{
    public enum Permissions { customer, staff, admin }
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        [NotMapped]
        public string EmailConfirm { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public string PasswordConfirm { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public Permissions Permissions { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
