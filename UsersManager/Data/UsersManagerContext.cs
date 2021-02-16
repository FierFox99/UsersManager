using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UsersManager.Models;

namespace UsersManager.Data
{
    public class UsersManagerContext : DbContext
    {
        public UsersManagerContext (DbContextOptions<UsersManagerContext> options)
            : base(options)
        {
        }

        public DbSet<UsersManager.Models.User> User { get; set; }
    }
}
