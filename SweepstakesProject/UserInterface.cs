using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    static class UserInterface
    {
        public static string GetContestentName()
        {
            Console.Write("Enter yourr first and last name, seperated by a space: ");
            return Console.ReadLine();
        }

        public static string GetContestentEmail()
        {
            Console.Write("Enter your email: ");
            return Console.ReadLine(); ;
        }

        public static void DisplayID(int regID, string name)
        {
            Console.WriteLine($"Thank you, {name}. Your registration ID is: {regID}");
        }
    }
}
