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
    public class ItemConfiguration: IEntityTypeConfiguration<Item>
    {
       public void Configure (EntityTypeBuilder<Item> itemBuilder)
        {
            itemBuilder.HasKey(i => i.ItemId);
            itemBuilder.Property(i => i.Title).IsRequired();
            itemBuilder.Property(i => i.Description).IsRequired();
            itemBuilder.Property(i => i.Image).IsRequired();
            itemBuilder.Property(i => i.Link).IsRequired();
            itemBuilder.HasOne(c => c.Category).WithMany(i => i.Items);
            itemBuilder.HasOne(f => f.Format).WithMany(i => i.Items);
        }
    }
}
