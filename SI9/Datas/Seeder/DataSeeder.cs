using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeder
{
    public static class DataSeeder
    {
        public static void SeedDb(this ModelBuilder modelBuilder)
        {
            modelBuilder.SeedDataStructures();
        }
    }
}
