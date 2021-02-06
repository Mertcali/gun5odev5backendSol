using gun5odev5backend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace gun5odev5backend.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
