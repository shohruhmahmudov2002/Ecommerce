using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class CustomerAddress
{
    [Key]
    public int CustomerAddressID { get; set; }
    [Required]
    [ForeignKey(nameof(Customer))]
    public int CustomerID { get; set; }
    
    public virtual Customer Customers {  get; set; }
    [Required]
    public string AddressLine1 { get; set; }
    [Required]
    public string? AddressLine2 { get; set; }
    [Required]
    public string PostalCode { get; set; }
    [Required]
    public string Country { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
}

