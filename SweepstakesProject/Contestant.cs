using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Contestant
    {
        private string firstName;
        private string lastName;
        private string email;
        public string Email { get { return email; } }
        public int regID;

        public Contestant(string name, string email)
        {
            firstName = name.Split(' ')[0];
            lastName = name.Split(' ')[1];
            this.email = email;
        }

        public string GetName()
        {
            return firstName + " " + lastName;
        }
    }
}
