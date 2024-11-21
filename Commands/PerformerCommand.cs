using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManager.Service.Exceptions;
using EventManager.Service.Models;

namespace EventManager.Service.Commands;

public class PerformerCommand
{

    public int PerformerId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ContactEmail { get; set; }
    public string PhoneNumber { get; set; }
    public List<int> Events { get; set; }
    public PerformerCategory Type { get; set; }

    public void Validate()
    {
        if (PerformerId <= 0) throw new ValidationException("Performer Id must be positive");
        if (PerformerId <= 0) throw new ValidationException("Performer Id must be positive");
        if (string.IsNullOrEmpty(Name)) throw new ValidationException("Name must not be Empty");
        if (string.IsNullOrEmpty(Description)) throw new ValidationException("Description must not be Empty");
        if (string.IsNullOrEmpty(ContactEmail)) throw new ValidationException("ContactEmail must not be Empty");
        if (string.IsNullOrEmpty(PhoneNumber)) throw new ValidationException("PhoneNumber must not be Empty");
        if (Events is null || Events.Any()) throw new ValidationException("Events are not avalible , or empty list of Events");
        if (!Enum.IsDefined(typeof(PerformerCategory), Type)) throw new ValidationException("Performer Category is not defined");//Stack overflow solution
    }
}
