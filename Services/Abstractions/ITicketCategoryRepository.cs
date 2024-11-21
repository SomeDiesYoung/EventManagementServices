using EventManager.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Service.Services.Abstractions;

public interface ITicketCategoryRepository
{
    TicketCategory GetById(int id);
    void SaveTicketCategoryInfo(TicketCategory ticketCategory);
}
