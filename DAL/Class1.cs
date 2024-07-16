using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE;

namespace DAL
{
    public class db:DbContext
    {
        public db() : base("b") { }
        public DbSet<personel> personels { get; set; }
        public DbSet<userlogin> userlogins { get; set; }
        public DbSet<SessionUsers> sessionUsers { get; set; }
    }
}
