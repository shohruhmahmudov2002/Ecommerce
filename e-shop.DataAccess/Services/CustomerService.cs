﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace e_shop.DataAccess.Services;
public class CustomerService
{
    private readonly ShopContext _context;
    public CustomerService(ShopContext context)
    {
        _context = context;
    }
    public async Task AddCustomer(Customer customer)
    {
        await _context.Customers.AddAsync(customer);
    }
    public async Task AddCustomerAddress(CustomerAddress customerAddress)
    {
        await _context.CustomerAddresses.AddAsync(customerAddress);
    }
    public IEnumerable<Customer> GetCustomers()
    {
        return _context.Customers
            .Include(r => r.CustomerAddresses);
    }
    public int SaveChanges() => _context.SaveChanges();
}

