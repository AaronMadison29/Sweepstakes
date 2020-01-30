using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Contestant contestant = new Contestant("Aaron Madison", "afwegnwrge");

            Sweepstakes sweepstakes = new Sweepstakes("Loto");

            sweepstakes.RegisterContestant(contestant);

            Console.WriteLine(contestant.regID);
            Console.ReadLine();
        }
    }
}
