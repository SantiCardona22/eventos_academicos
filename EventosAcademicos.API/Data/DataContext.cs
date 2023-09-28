using Microsoft.EntityFrameworkCore;
using EventosAcademicos.Library.Entities;

namespace EventosAcademicos.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<EvenAcademicos> EvenAcademicos { get; set; }
        public DbSet<Participantes> Participantes { get; set; }
        public DbSet<ProgramaEvento> ProgramaEvento { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
