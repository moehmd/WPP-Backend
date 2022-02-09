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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> categoryBuilder)
        {
            categoryBuilder.HasKey(c => c.CategoryId);
            categoryBuilder.Property(c => c.Name).IsRequired();
            categoryBuilder.HasMany(i => i.Items).WithOne(c => c.Category);
        }
    }
}
