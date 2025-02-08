using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;
public class Notification
{
    public int NotificationsID { get; set; }
    public int AccountID { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public bool Seen { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ReceiveTime { get; set; }
    public DateTime ExpiryDate { get; set; }
}

