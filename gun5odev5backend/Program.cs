using gun5odev5backend.Concrete;
using gun5odev5backend.Entities;
using System;

namespace gun5odev5backend
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer {NationalityId="12345678910", BirthYear = 1998, FirstName = "Mert", LastName = "ÇALIŞ" });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Update(new Campaign {CampaignName="İlk ürün indirimi", CampaignDiscount = 20, CampaignId ="1" });

            OrderManager orderManager = new OrderManager();
            orderManager.CreateOrder(new Order { OrderId = "1", OrderName = "MSI LAPTOP" } ,new Campaign {CampaignDiscount=20, CampaignId ="2", CampaignName = "MSI URUN INDIRIMI" } );


        }
    }
}
