using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SweepstakesProject;
using SweepstakesTest;

namespace SweepstakesTest
{
    [TestClass]
    public class ContestantTest
    {
        [TestMethod]
        public void CunstructorTest_CreateContestantObject_ObjectInstantiatedWithCorrectName()
        {
            //Assemble
            string name = "Aaron Madison";
            string email = "test@email.com";
            //Act
            Contestant contestant = new Contestant(name, email);
            //Assert
            Assert.AreEqual("Aaron Madison", contestant.GetName());
        }


        [TestMethod]
        public void CunstructorTest_CreateContestantObject_ObjectInstantiatedWithCorrectEmail()
        {
            //Assemble
            string name = "Aaron Madison";
            string email = "test@email.com";
            //Act
            Contestant contestant = new Contestant(name, email);
            //Assert
            Assert.AreEqual("test@email.com", contestant.Email);
        }
    }
}
