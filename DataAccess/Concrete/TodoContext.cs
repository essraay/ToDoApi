using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ToDoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));

            optionsBuilder.UseMySql(@"Server=localhost; database=todo; uid=esra; pwd=Esra.1513", serverVersion);
            //optionsBuilder.UseMySql(@"Server=localhost; database=almanya; uid=root; pwd=1513", serverVersion);
        }

        public DbSet<Todos> Todos { get; set; }
        public DbSet<User> User { get; set; }
    }
}
