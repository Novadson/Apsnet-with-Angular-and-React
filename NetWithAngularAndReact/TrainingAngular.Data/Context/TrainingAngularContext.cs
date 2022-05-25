using Microsoft.EntityFrameworkCore;
using TrainingAngular.Data.Extensions;
using TrainingAngular.Data.Mappings;
using TrainingAngular.Domain.Entities;


namespace TrainingAngular.Data.Context
{
    public class TrainingAngularContext : DbContext
    {
        public TrainingAngularContext(DbContextOptions<TrainingAngularContext> options) : base(options) { }

        #region "DBSET"
        public DbSet<Users> User { get; set; }

        #endregion "DBSET"

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region MAPPINGS ENTITIES
            modelBuilder.ApplyConfiguration(new UserMap());
            #endregion MAPPINGS ENTITIES

            modelBuilder.SeedData();
            base.OnModelCreating(modelBuilder);
        }

    }
}
