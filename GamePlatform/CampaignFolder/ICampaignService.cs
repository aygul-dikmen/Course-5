using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform.CampaignFolder
{
    public interface ICampaignService
    {
        void SaveCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
    }
}
