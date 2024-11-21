using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Service.Models;

public class Order
{
    public int  Id { get; set; }
    public int UserId { get; set; }
    //public User User { get; set; } // ar vici model classhi mchirdeba Tu ara?

    public int EventId {  get; set; }
    //public Event Event { get; set; } // ar vici model classhi mchirdeba Tu ara?

    public List<int> TicketIds { get; set; }
    public DateTime OrderDate { get; set; }

}
