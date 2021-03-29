using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Elsa.Samples.UserRegistration.Web.Models
{
    public class UsersModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
