using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SweepstakesProject;

namespace SweepstakesTest
{
    [TestClass]
    public class SweepstakeTest
    {
        [TestMethod]
        public void RegisterContestant_RegisterANewContestant_ConestantAddedToDictionary()
        {
            //Assemble
            Contestant contestant = new Contestant("Aaron Madison", "test@email.com");
            Sweepstakes sweepstakes = new Sweepstakes("Sweepstakes");
            //Act
            sweepstakes.RegisterContestant(contestant);
            //Assert
            Assert.AreEqual(sweepstakes.contestants[1], contestant);
        }

        [TestMethod]
        public void RegisterContestant_RegisterANewContestant_RegIDIncremented()
        {
            //Assemble
            Contestant contestant = new Contestant("Aaron Madison", "test@email.com");
            Contestant contestant2 = new Contestant("Mr. Man", "test@email.com");
            Sweepstakes sweepstakes = new Sweepstakes("Sweepstakes");
            //Act
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.RegisterContestant(contestant2);
            //Assert
            Assert.AreEqual(sweepstakes.contestants[2], contestant2);
        }

        [TestMethod]
        public void PickWinner_WinnerChosen_ReturnsAContestant()
        {
            //Assemble
            Contestant contestant = new Contestant("Aaron Madison", "test@email.com");
            Contestant contestant2 = new Contestant("Mr. Man", "test@email.com");
            Contestant contestant3 = new Contestant("Mr. Guy", "test@email.com");
            Sweepstakes sweepstakes = new Sweepstakes("Sweepstakes");
            //Act
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.RegisterContestant(contestant2);
            sweepstakes.RegisterContestant(contestant3);
            Contestant winner = sweepstakes.PickWinner();
            //Assert
            Assert.IsTrue(sweepstakes.contestants.ContainsValue(winner));
        }

        [TestMethod]
        public void PickWinner_OnlyOneEntry_ReturnsSingleEntry()
        {
            //Assemble
            Sweepstakes sweepstakes = new Sweepstakes("Sweepstakes");
            Contestant contestant = new Contestant("Aaron Madison", "test@email.com");
            //Act
            sweepstakes.RegisterContestant(contestant);
            Contestant winner = sweepstakes.PickWinner();
            //Assert
            Assert.AreEqual(contestant, winner);
        }

        [TestMethod]
        public void PickWinner_EmptySweepstakes_ReturnsNull()
        {
            //Assemble
            Sweepstakes sweepstakes = new Sweepstakes("Sweepstakes");
            //Act
            Contestant winner = sweepstakes.PickWinner();
            //Assert
            Assert.AreEqual(null, winner);
        }
    }
}
