using Event.Manager.Service.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Manager.Service.Commands
{
    public class EventCommand
    {
        public int EventId { get; set; }
        public int AddressId { get; set; }
        public List<int> TicketIds { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public void Validate()
        {
            if (EventId <= 0) throw new ValidationException("Event Id must not be Negative");
            if (AddressId <= 0) throw new ValidationException("Address Id must not be Negative");
            if (TicketIds == null || !TicketIds.Any())
                throw new ValidationException("Ticket list cannot be empty");
            if (string.IsNullOrEmpty(Name)) throw new ValidationException("Name must not be empty");
            if (StartDate < EndDate) throw new ValidationException("Event Start Date Cant be greater than End Date");
            if(EndDate < DateTime.Today.AddDays(-1)) throw new ValidationException("End date must be today or in the future.");
            
        }
    }
}