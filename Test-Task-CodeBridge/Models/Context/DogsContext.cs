using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Task_CodeBridge.Models.Context
{
    public class DogsContext:DbContext
    {
        public DogsContext(DbContextOptions<DogsContext>options):base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Dog neo = new Dog
            {
                Id = Guid.NewGuid(),
                Name = "Neo",
                Color = "Red & amber",
                Tail_Length = 22,
                Weight = 32
            };
            Dog jessy = new Dog
            {
                Id = Guid.NewGuid(),
                Name = "Jessy",
                Color = "black & white",
                Tail_Length = 7,
                Weight = 14
            };

            modelBuilder.Entity<Dog>().HasData(new Dog[] {neo,jessy});
            base.OnModelCreating(modelBuilder);
        }
    }
}
