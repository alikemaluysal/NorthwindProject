using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
        List<Order> GetAllByCustomerId(int customerId);
        List<Order> GetAllByEmployeeId(int employeeId);
        Order GetById(int categoryId);


    }
}
