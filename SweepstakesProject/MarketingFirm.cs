using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class MarketingFirm : ManagerFactory
    {
        ISweepstakesManager _manager;

        public MarketingFirm(ISweepstakesManager _manager)
        {
            this._manager = _manager;
        }
        private void CreateSweepstakes()
        {
            Sweepstakes newSweepstakes = new Sweepstakes(UserInterface.SweepstakesNameChoice());
            SweepstakesSignup(newSweepstakes);
            _manager.InsertSweepstakes(newSweepstakes);
        }

        private void SweepstakesSignup(Sweepstakes newSweepstakes)
        {
            bool running = true;
            do
            {
                newSweepstakes.RegisterContestant(TakeNewContestantInformation());

                running = UserInterface.AddAnotherContestant() == "y" ? true : false;

            } while (running);
        }

        private Contestant TakeNewContestantInformation()
        {
            string contestantName = UserInterface.GetContestantName();
            string contestantEmail = UserInterface.GetContestantEmail();
            return new Contestant(contestantName, contestantEmail);
        }

        public void RunMarketingFirm()
        {
            Setup();

            while(_manager.PeekSweepstakes() != null)
            {
                Sweepstakes currentSweepstakes = _manager.GetSweepstakes();
                Contestant winner = currentSweepstakes.PickWinner();
                NotifyContestants(currentSweepstakes, winner);
            }
        }

        private void Setup()
        {
            bool running = true;
            do
            {
                CreateSweepstakes();

                running = UserInterface.MakeAnotherSweepstakes() == "y" ? true : false;

            } while (running);
        }

        private void NotifyContestants(Sweepstakes sweepstakes, Contestant winner)
        {
            foreach(KeyValuePair<int, Contestant> contestant in sweepstakes.contestants)
            {
                contestant.Value.Notify(winner, sweepstakes);
            }
        }
    }
}
