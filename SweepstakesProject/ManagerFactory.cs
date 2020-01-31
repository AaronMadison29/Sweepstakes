using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class ManagerFactory
    {
        public ISweepstakesManager CreateManager(string input)
        {
            ISweepstakesManager item;
            switch (input)
            {
                case "Stack":
                    item = new SweepstakesStackManager();
                    break;
                case "Queue":
                    item = new SweepstakesStackManager();
                    break;
                default:
                    item = null;
                    break;
            }
            return item;
        }
    }
}
