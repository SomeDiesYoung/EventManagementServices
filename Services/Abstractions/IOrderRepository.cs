using EventManager.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Service.Services.Abstractions;

public interface IOrderRepository
{
    Order GetById(int id);
    void SaveOrderInfo(Order order);
}
