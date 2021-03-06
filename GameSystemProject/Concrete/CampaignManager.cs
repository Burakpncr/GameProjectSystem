using GameSystemProject.Abstract;
using GameSystemProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Kampanyası Eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Kampanyası Silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Kampanyası Güncellendi");
        }
    }
}
