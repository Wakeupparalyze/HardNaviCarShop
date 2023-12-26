using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HardNaviCarShop
{
    public class DboContext: DbContext
    {
        private string _filePath;
        public DboContext(string filePath)
        {
            _filePath = filePath;
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Type> Types { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_filePath}");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
