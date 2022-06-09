using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Hero
            modelBuilder.Entity<Hero>().HasData(
                new Hero { Id = 1, Name = "Iron Man", Power = 989 },
                new Hero { Id = 2, Name = "Captain America", Power = 991 },
                new Hero { Id = 3, Name = "Thor", Power = 999 },
                new Hero { Id = 4, Name = "Hulk", Power = 998 }
            );

            //Vilain
            modelBuilder.Entity<Villain>().HasData(
                new Villain { Id = 1, Name = "Thanos", Power = 999 },
                new Villain { Id = 2, Name = "Ebony Maw", Power = 990 },
                new Villain { Id = 3, Name = "Loki", Power = 850 },
                new Villain { Id = 4, Name = "Ultron", Power = 999 }
            );
        }
    }
}
