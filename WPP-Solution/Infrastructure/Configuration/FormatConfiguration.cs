using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class FormatConfiguration : IEntityTypeConfiguration<Format>
    {
        public void Configure(EntityTypeBuilder<Format> FormatBuilder)
        {
            FormatBuilder.HasKey(f => f.FormatId);
            FormatBuilder.Property(f => f.Name).IsRequired();
            FormatBuilder.HasMany(i => i.Items).WithOne(c => c.Format);
        }
    }
}
