using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elsa.Samples.UserRegistration.Web.Models
{
    public class ElsaContext : DbContext
    {
        public DbSet<UsersModel> Users { get; set; }
        public ElsaContext()
        {

        }
        
    }
}
