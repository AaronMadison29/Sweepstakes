using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            ManagerFactory factory = new ManagerFactory();

            MarketingFirm marketingFirm = new MarketingFirm(factory.CreateManager(UserInterface.ManagerChoice()));

            marketingFirm.RunMarketingFirm();
        }
    }
}
