using Data.Models;
using Data.Seeder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class DataStructuresAndAlghoritmsContext: DbContext
    {
        public DataStructuresAndAlghoritmsContext(DbContextOptions<DataStructuresAndAlghoritmsContext> opt) : base(opt)
        {

        }

        public DbSet<DataStructure> dataStructures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedDb();
        }

    }
}
