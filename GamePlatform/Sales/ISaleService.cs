using GamePlatform.CampaignFolder;
using GamePlatform.CustomerFolder;
using GamePlatform.GameFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform.Sales
{
    interface ISaleService
    {
        public void SaleGameWithCampaign(Game game, Customer customer, Campaign campaign);
        public void SaleGame(Game game, Customer customer);
    }
}
