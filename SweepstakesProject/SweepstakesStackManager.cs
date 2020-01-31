using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        public Stack<Sweepstakes> sweepstakesStack = new Stack<Sweepstakes>();

        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesStack.Pop();
        }
        public Sweepstakes PeekSweepstakes()
        {
            if (sweepstakesStack.Any())
            {
                return sweepstakesStack.Peek();
            }
            return null;
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesStack.Push(sweepstakes);
        }

        
    }
}
