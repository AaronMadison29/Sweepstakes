using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    static class UserInterface
    {
        public static string GetContestantName()
        {
            Console.Write("Enter yourr first and last name, seperated by a space: ");
            return Console.ReadLine();
        }

        public static string GetContestantEmail()
        {
            Console.Write("Enter your email: ");
            return Console.ReadLine(); ;
        }

        public static void DisplayID(int regID, string name)
        {
            Console.WriteLine($"Thank you, {name}. Your registration ID is: {regID}");
        }

        public static void DeclareWinner(Contestant winner)
        {
            Console.WriteLine($"The winner is: {winner.GetName()}");
        }

        public static void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"Contestant name: {contestant.GetName()}");
            Console.WriteLine($"Contestant email: {contestant.Email}");
            Console.WriteLine($"Contestant ID: {contestant.regID}");
        }
    }
}
