namespace EventManager.Service.Models;

public class TicketCategory
{ 
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal PriceMultiplier { get; set; }
    public string Description { get; set; }
}