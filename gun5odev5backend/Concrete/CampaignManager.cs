using gun5odev5backend.Abstract;
using gun5odev5backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace gun5odev5backend.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "  adlı kampanya başarıyla eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "  adlı kampanya başarıyla silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "  adlı kampanya başarıyla güncellendi");
        }
    }
}
