using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SweepstakesProject;

namespace SweepstakesTest
{
    [TestClass]
    public class SweepstakesStackManagerTest
    {
        [TestMethod]
        public void InsertSweepstakes_PushSweepstakesToStack_SweepstakesInputInStack()
        {
            //Assemble
            Sweepstakes sweepstakes = new Sweepstakes("Loto");
            SweepstakesStackManager sweepstakesStack = new SweepstakesStackManager();
            //Act
            sweepstakesStack.InsertSweepstakes(sweepstakes);
            //Assert
            Assert.AreEqual(sweepstakes, sweepstakesStack.GetSweepstakes());
        }

        [TestMethod]
        public void InsertSweepstakes_PullsTopSweepstakesFromStackOfMany_SweepstakesPulledOffTheTop()
        {
            //Assemble
            Sweepstakes sweepstakes = new Sweepstakes("Loto");
            Sweepstakes sweepstakes2 = new Sweepstakes("Loto");
            Sweepstakes sweepstakes3 = new Sweepstakes("Loto");
            SweepstakesStackManager sweepstakesStack = new SweepstakesStackManager();
            //Act
            sweepstakesStack.InsertSweepstakes(sweepstakes);
            sweepstakesStack.InsertSweepstakes(sweepstakes2);
            sweepstakesStack.InsertSweepstakes(sweepstakes3);
            //Assert
            Assert.AreEqual(sweepstakes3, sweepstakesStack.GetSweepstakes());
        }
    }
}
