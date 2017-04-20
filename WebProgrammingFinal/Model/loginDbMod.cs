using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgrammingFinal.Model
{
    public class loginDbMod : DbContext
    {
        public loginDbMod(DbContextOptions<loginDbMod> options) : base(options)
        {

        }   
        public DbSet<UserAccount> UserAccount { get; set; }
    }
}
