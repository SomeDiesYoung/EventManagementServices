using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Service.Models;

public class Ticket
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public int ZoneTicketCategoryId { get; set; } 
    public ZoneTicketCategory ZoneTicketCategory { get; set; }
    public DateTime PurchaseDate { get; set; }
    public bool IsAvailable { get; set; }
}
