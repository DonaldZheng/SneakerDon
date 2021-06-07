using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace theSneakerDon.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(CustomerOrder order);
        void CreateOrder(Stripe.Order order);
    }
}
