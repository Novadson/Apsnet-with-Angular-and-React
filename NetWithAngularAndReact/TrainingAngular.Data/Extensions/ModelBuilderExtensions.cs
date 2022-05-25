using Microsoft.EntityFrameworkCore;
using TrainingAngular.Domain.Entities;

namespace TrainingAngular.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder SeedData(this ModelBuilder modelBuilder)
        {
            /*INSERT USER BY DEFAULT IF NTO EXISTS*/
            modelBuilder.Entity<Users>().HasData(
                new Users { Id = new System.Guid("fa2a200a-4ad4-4b20-a568-46d50b137fc8"), Name = "Novadson Thelus", Email = "novadsonthelus@gmail.com" }
                );
            return modelBuilder;
        }
    }
}
