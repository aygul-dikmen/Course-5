using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform.CampaignFolder
{
    public abstract class CampaignManager : ICampaignService
    {
        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" deleted successfully.");
        }

        public void SaveCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" added successfully.");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " updated successfully.");
        }
    }
}
