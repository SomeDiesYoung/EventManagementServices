using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Event.Manager.Service.Exceptions;
namespace EventManager.Service.Commands;

public class ZoneTicketCategoryCommand
{
    public int ZoneTicketCategoryId { get; set; }
    public int ZoneId { get; set; }
    public int TicketCategoryId { get; set; }
    public int Quantity { get; set; }
    public bool IsAvailable { get; set; }

    public void Validate() 
    {
        if (ZoneTicketCategoryId <= 0) throw new ValidationException("Zone Ticket Category Id Must be positive");
        if (ZoneId <= 0) throw new ValidationException("Zone Id Must be positive");
        if (TicketCategoryId <= 0) throw new ValidationException("TicketCategory Id Must be positive");
        if (Quantity < 0) throw new ValidationException("Quantity must be greater than 0");
        if (!IsAvailable) throw new ValidationException("Tickets in this zone are not available anymore");
    }
}
