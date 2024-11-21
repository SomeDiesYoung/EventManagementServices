﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Service.Models;
public class Performer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ContactEmail { get; set; }
    public string PhoneNumber { get; set; }
    public List<Event> Events { get; set; }
    public PerformerCategory Type { get; set; }
}