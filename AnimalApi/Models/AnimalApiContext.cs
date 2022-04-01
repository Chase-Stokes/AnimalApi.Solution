using Microsoft.EntityFrameworkCore;

namespace AnimalApi.Models
{
    public class AnimalApiContext : DbContext
    {
        public AnimalApiContext(DbContextOptions<AnimalApiContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Animal>()
            .HasData(
              new Animal {AnimalId = 1, Name = "chihiro", Species = "cat", Breed = "shorthair", Sex = "female", Age = 3},
              new Animal {AnimalId = 2, Name = "ira", Species = "dog", Breed = "american bulldog", Sex = "male", Age = 6},
              new Animal {AnimalId = 3, Name = "perchik", Species = "cat", Breed = "longhair", Sex = "male", Age = 3},
              new Animal {AnimalId = 4, Name = "mika", Species = "cat", Breed = "shorthair", Sex = "female", Age = 2},
              new Animal {AnimalId = 5, Name = "hodel", Species = "cat", Breed = "shorthair", Sex = "female", Age = 2}
            );
        }  
    }
}