using gun5odev5backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace gun5odev5backend.Abstract
{
    interface IOrderService
    {
        void CreateOrder(Order order, Campaign campaign);
    }
}
