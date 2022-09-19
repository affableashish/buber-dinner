using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BuberDinner.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Infrastructure.Persistence.Configuration
{
    // We can go this route or we can go with Data Annotations route
    public class DinnerConfiguration : IEntityTypeConfiguration<Dinner>
    {
        public void Configure(EntityTypeBuilder<Dinner> builder)
        {
            // For eg:
            // builder.ToTable("Dinner");
            builder.HasKey(x => x.OrderId);

            // builder.Property(x => x.Reason).HasMaxLength(200).IsRequired();
        }
    }
}
