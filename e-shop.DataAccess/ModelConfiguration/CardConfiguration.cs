using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace e_shop.DataAccess.ModelConfiguration;
public class CardConfiguration : IEntityTypeConfiguration<Card>
{
    public void Configure(EntityTypeBuilder<Card> builder)
    {
        builder.HasMany(r => r.CardItems)
            .WithOne(r => r.Cards);

        builder.HasKey(r => r.CardID);
    }
}

public class CardItemConfiguration : IEntityTypeConfiguration<CardItem>
{
    public void Configure(EntityTypeBuilder<CardItem> builder)
    {
        builder.HasKey(r => r.CardItemID);

        builder.HasOne(r => r.Cards)
            .WithMany(r => r.CardItems)
            .HasForeignKey(r => r.CardID)
            .OnDelete(DeleteBehavior.Cascade);
    }
}