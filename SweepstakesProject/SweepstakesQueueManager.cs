using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        public Queue<Sweepstakes> sweepstakesQueue = new Queue<Sweepstakes>();

        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesQueue.Dequeue();
        }
        public Sweepstakes PeekSweepstakes()
        {
            if (sweepstakesQueue.Peek() != null)
            {
                return sweepstakesQueue.Peek();
            }
            return null;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesQueue.Enqueue(sweepstakes);
        }
    }
}