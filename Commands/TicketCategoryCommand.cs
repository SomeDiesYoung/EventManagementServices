using Event.Manager.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Event.Manager.Service.Exceptions;

namespace Event.Manager.Service.Commands;

public class TicketCategoryCommand
{ 
    public int TicketCategoryId { get; set; }
    public string Name { get; set; }
    public decimal PriceMultiplier { get; set; }
    //Description opcionalur propertiT mimachnia da magito ar davamate validatorshi 
    public string Description { get; set; }
    public void Validate()
    {
        if (TicketCategoryId <= 0) throw new ValidationException("Ticket Category Id must be positive");
        if (string.IsNullOrEmpty(Name)) throw new ValidationException("Category Name can`t be empty");
        if (PriceMultiplier < 0) throw new ValidationException("Price Multiplier can`t be negative"); // aq ar vici iqneb <1 jobda mara akciebis logika Tu iqneba??? Gamoucdeli var rom mivxvde axla ra jobia

    }
}
