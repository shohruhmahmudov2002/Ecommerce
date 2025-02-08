﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace e_shop.DataAccess.Services;
public class CardService
{
    private readonly ShopContext _context;
    public CardService(ShopContext context)
    {
        _context = context;
    }
    public async Task AddCard(Card card)
    {
        await _context.Cards.AddAsync(card);
    }
    public async Task AddCardItem(CardItem cardItem)
    {
        await _context.CardItems.AddAsync(cardItem);
    }
    public IEnumerable<Card> GetCards()
    {
        return _context.Cards
            .Include(r => r.CardItems);
    }
    public int SaveChanges() => _context.SaveChanges();
}

