using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class Customer : IAuditable
{
    public Customer()
    {
        CustomerAddresses = new List<CustomerAddress>();
    }
    [Key]
    public int CustomerID { get; set; }
    [Required, MaxLength(100)]
    public string FirstName { get; set; }
    [Required, MaxLength(100)]
    public string LastName { get; set; }
    [Required, MaxLength(100)]
    public string PhoneNumber { get; set; }
    [Required]
    public string Email {  get; set; }
    [Required]
    public string Password { get; set; }
    public bool IsActive { get; set; }
    public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }
    public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
}

