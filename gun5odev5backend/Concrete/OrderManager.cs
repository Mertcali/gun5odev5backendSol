using gun5odev5backend.Abstract;
using gun5odev5backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace gun5odev5backend.Concrete
{
    public class OrderManager : IOrderService
    {
        public void CreateOrder(Order order, Campaign campaign)
        {
            Console.WriteLine(order.OrderName + "  isimli siparişiniz alınmıştır." + campaign.CampaignName + "  adlı kampayadan faydalanarak  % " +campaign.CampaignDiscount + "  kadar indirim kazandınız.");
        }
    }
}
