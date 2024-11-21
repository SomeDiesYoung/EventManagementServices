using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManager.Service.Exceptions;

namespace EventManager.Service.Commands;

public class ZoneCommand
{
    public int ZoneId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Capasity { get; set; }
    public string Location { get; set; }

    public void Validate()
    {
        if (ZoneId <= 0) throw new ValidationException("Zone Id must be positive");
        if (string.IsNullOrEmpty(Name)) throw new ValidationException("Name can`t be empty");
        if (Capasity < 0) throw new ValidationException("Capasity must be positive");
        if (string.IsNullOrEmpty(Location)) throw new ValidationException("Location can`t be empty");
    }
}
