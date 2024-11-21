using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EventManager.Service.Exceptions;

namespace EventManager.Service.Commands;

public class AddressCommand
{
    public int AddressId { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Country { get; set; }

    public void Validate()
    {
        if (AddressId <= 0) throw new ValidationException("Address Id must be positive");
        if (string.IsNullOrEmpty(Street)) throw new ValidationException("Street must not be empty");
        if (string.IsNullOrEmpty(City)) throw new ValidationException("City must not be empty");
        if (string.IsNullOrEmpty(Country)) throw new ValidationException("Country must not be empty");
    }
}
