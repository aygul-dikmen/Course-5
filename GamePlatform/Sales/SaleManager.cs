using GamePlatform.CampaignFolder;
using GamePlatform.CustomerFolder;
using GamePlatform.GameFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform.Sales
{
    class SaleManager: ISaleService
    {
        public void SaleGame(Game game, Customer customer)
        {
            Console.WriteLine(game + " is solded to " + customer);
        }

        public void SaleGameWithCampaign(Game game, Customer customer, Campaign campaign)
        {

            Console.WriteLine(game+" is solded to "+customer+" with %"+campaign.CampaignRate);
        }


    }
}
