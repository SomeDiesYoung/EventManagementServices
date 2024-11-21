using EventManager.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManager.Service.Exceptions;
namespace EventManager.Service.Commands;

public class TicketCommand
{
    public int TicketId { get; set; }
    public decimal Price { get; set; }
    public DateTime PurchaseDate { get; set; }
    public ZoneTicketCategory ZoneTicketCategory { get; set; }

    public bool IsAvailable { get; set; }

    public void Validate()
    {
        if (TicketId <= 0) throw new ValidationException("Ticket Id must be positive");
        if (Price < 0) throw new ValidationException("Price must be Positive");
        if (PurchaseDate < DateTime.UtcNow) throw new ValidationException("Purchase Date must not  be in past time"); // Swori validaciaa???
        if (!IsAvailable) throw new ValidationException("Ticket is not Available");
    }
}
