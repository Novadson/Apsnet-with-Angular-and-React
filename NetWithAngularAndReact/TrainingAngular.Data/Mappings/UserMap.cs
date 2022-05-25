using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;
using TrainingAngular.Domain.Entities;

namespace TrainingAngular.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            #region PROPERTIES

            builder.Property(u => u.Id).IsRequired().HasDefaultValueSql("newsequentialid()");
            builder.Property(u => u.Name).HasMaxLength(250).IsRequired();
            builder.Property(u => u.Email).IsRequired();

            #endregion PROPERTIES
        }
    }
}
