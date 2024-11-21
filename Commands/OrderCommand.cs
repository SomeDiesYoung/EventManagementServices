using Event.Manager.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Event.Manager.Service.Exceptions;
namespace Event.Manager.Service.Commands;


//ar damaviwydes chamoyalibeba /Models/Order 
public class OrderCommand
{
    public int OrderId { get; set; }
    public int UserId { get; set; }
    public int EventId { get; set; }
    public List<int> TicketIds { get; set; }
    public DateTime OrderDate { get; set; }


    public void Validate()
    {
        if (OrderId <= 0) throw new ValidationException("Invalid Order Id");
        if (TicketIds == null || !TicketIds.Any())
            throw new ValidationException("Ticket list cannot be empty");
        if (OrderDate < DateTime.Now) throw new ValidationException("Order date cannot be in the past");
        if (UserId <= 0) throw new ValidationException("Invalid user id");
        if (EventId <= 0) throw new ValidationException("Invalid event id");
    }
}
