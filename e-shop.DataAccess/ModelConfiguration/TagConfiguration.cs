using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using e_shop.Domain.Entities;

namespace e_shop.DataAccess.ModelConfiguration;
public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.HasKey(r => r.TagID);

        builder.Property(p => p.TagName)
        .HasMaxLength(255)
        .HasColumnType("varchar")
        .IsRequired();

        builder.Property(p => p.Icon)
        .HasMaxLength(255)
        .HasColumnType("varchar")
        .IsRequired();
    }
}

