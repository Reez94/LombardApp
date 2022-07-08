using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LombardApp.Models
{
    public class DataBaseContext : DbContext
    {

        /// Db connection

        public DbSet<Client> Client { get; set; }
        public DbSet<PledgedItems> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=lombard;user=root;password=");
        }
    }
}
