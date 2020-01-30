using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Contestant
    {
        private string firstName;
        private string lastName;
        private string email;
        public int regNumber;

        public Contestant(string name, string email, int regNumber)
        {
            firstName = name.Split(' ')[0];
            lastName = name.Split(' ')[1];
            this.email = email;
            this.regNumber = regNumber;
        }

        public string GetName()
        {
            return firstName + " " + lastName;
        }

        public string GetEmail()
        {
            return email;
        }
    }
}
