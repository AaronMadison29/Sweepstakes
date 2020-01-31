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
            Console.Write("Enter the contestant's first and last name, seperated by a space: ");
            return Console.ReadLine();
        }

        public static string GetContestantEmail()
        {
            Console.Write("Enter the contestant's email: ");
            return Console.ReadLine(); ;
        }

        public static void DisplayID(int regID, string name)
        {
            Console.WriteLine($"{name}'s contestant's registration ID is: {regID}");
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

        public static void EmptySweepstakes()
        {
            Console.WriteLine("The sweepstakes doesn't have any contestants!");
        }

        public static string ManagerChoice()
        {
            Console.Write("What kind of sweepstakes data structure would you like to use, Stack or Queue?: ");
            return Console.ReadLine();
        }

        public static string SweepstakesNameChoice()
        {
            Console.Write("What would you like to name your sweepstakes?: ");
            return Console.ReadLine();
        }

        public static string Continue()
        {
            Console.Write("Would you like to continue?: y/n");
            return Console.ReadLine();
        }
    }
}
