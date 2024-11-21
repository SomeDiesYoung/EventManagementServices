using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Service.Models;

public class Event
{
    public int Id { get; set; }
    public int AddressId { get; set; }
    public List<int> TicketIds { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
