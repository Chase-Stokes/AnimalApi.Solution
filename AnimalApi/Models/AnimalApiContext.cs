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
    }
}