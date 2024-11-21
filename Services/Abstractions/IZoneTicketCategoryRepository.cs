using EventManager.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Service.Services.Abstractions;

public interface IZoneTicketCategoryRepository
{
    ZoneTicketCategory GetById(int id);
    void SaveOrderInfo(ZoneTicketCategory zoneTicketCategory);  
}
