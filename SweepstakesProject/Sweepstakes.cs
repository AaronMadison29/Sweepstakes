using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Sweepstakes
    {
        public Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        Random ran = new Random();
        private string name;
        private int registrationID;

        public string Name
        { 
            get
            {
                return name;
            }
        }


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

        public void PickWinner()
        {
            if(contestants.Count == 0)
            {
                UserInterface.EmptySweepstakes();
            }
            Contestant winner = contestants[ran.Next(1, registrationID)];
            UserInterface.DeclareWinner(winner);
        }

        public void PrintContestentInfo(Contestant contestant)
        {
            UserInterface.PrintContestantInfo(contestant);
        }
    }
}
