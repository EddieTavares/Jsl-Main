using Jsl.Domain.Entities;
using Jsl.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Jsl.Infra.Data.Context
{
    public class Db : DbContext
    {
        public Db(DbContextOptions<Db> options) : base(options)
        {

        }

        public DbSet<Motorista> Motoristas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Motorista>(new MotoristaMap().Configure);
        }
    }
}
