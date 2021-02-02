using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Telephone.DAL.DBFiles
{
    public sealed class MyContext : DbContext
    {
        public DbSet<TelBookPerson> persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=95.214.10.36;Port=5432;Database=allah;Username=gomonmax;Password=578947001;");
        }
    }
}
