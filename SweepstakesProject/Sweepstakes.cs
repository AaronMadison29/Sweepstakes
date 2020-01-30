using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        Random ran = new Random();
        public string name;
        private int registrationID;

        public Sweepstakes(string name)
        {
            this.name = name;
            registrationID = 1;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.regID = registrationID;
            contestants.Add(registrationID, contestant);
            registrationID++;
        }

        public Contestant PickWinner()
        {
            Contestant winner = contestants[ran.Next(1, registrationID + 1)];
            UserInterface.DeclareWinner(winner);
            return winner;
        }

        public void PrintContestentInfo(Contestant contestant)
        {
            UserInterface.PrintContestantInfo(contestant);
        }
    }
}
