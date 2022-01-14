using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task_CodeBridge.Services.Builder;

namespace Test_Task_CodeBridge.Models.Context
{
    public class DogsContext:DbContext
    {
        public DbSet<Dog> Dogs { get; set; }
        public DogsContext(DbContextOptions<DogsContext>options):base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Dog Neo = new DogBuilder().
                          SetName("Neo").
                          SetColor("Red & amber").
                          SetTailHeight(22).
                          SetWeight(32).
                          Build();
            Neo.Id = Guid.NewGuid();

            Dog Jessy = new DogBuilder().
                         SetName("Jessy").
                         SetColor("black & white").
                         SetTailHeight(7).
                         SetWeight(14).
                         Build();
            
            Jessy.Id = Guid.NewGuid();
           

            modelBuilder.Entity<Dog>().HasData(new Dog[] {Neo,Jessy});
            base.OnModelCreating(modelBuilder);
        }
    }
}
