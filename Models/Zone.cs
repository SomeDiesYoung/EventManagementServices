﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Service.Models;

public class Zone
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Capasity { get; set; }
    public string Location { get; set; }
}
