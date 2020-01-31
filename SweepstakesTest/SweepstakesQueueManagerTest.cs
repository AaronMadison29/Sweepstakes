using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SweepstakesProject;

namespace SweepstakesTest
{
    [TestClass]
    public class SweepstakesQueueManagerTest
    {
        [TestMethod]
        public void InsertSweepstakes_EnqueueSweepstakesToQueue_SweepstakesInputInQueue()
        {
            //Assemble
            Sweepstakes sweepstakes = new Sweepstakes("Loto");
            SweepstakesQueueManager sweepstakesQueue = new SweepstakesQueueManager();
            //Act
            sweepstakesQueue.InsertSweepstakes(sweepstakes);
            //Assert
            Assert.AreEqual(sweepstakes, sweepstakesQueue.GetSweepstakes());
        }

        [TestMethod]
        public void InsertSweepstakes_EnqueueMultipleSweepstakesToQueue_SweepstakesDequeuesFirstValue()
        {
            //Assemble
            Sweepstakes sweepstakes = new Sweepstakes("Loto");
            Sweepstakes sweepstakes2 = new Sweepstakes("Loto2");
            Sweepstakes sweepstakes3 = new Sweepstakes("Loto3");
            Sweepstakes sweepstakes4 = new Sweepstakes("Loto4");
            SweepstakesQueueManager sweepstakesQueue = new SweepstakesQueueManager();
            //Act
            sweepstakesQueue.InsertSweepstakes(sweepstakes);
            sweepstakesQueue.InsertSweepstakes(sweepstakes2);
            sweepstakesQueue.InsertSweepstakes(sweepstakes3);
            sweepstakesQueue.InsertSweepstakes(sweepstakes4);
            //Assert
            Assert.AreEqual(sweepstakes, sweepstakesQueue.GetSweepstakes());
        }
    }
}
