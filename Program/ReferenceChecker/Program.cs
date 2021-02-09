using System;

namespace ReferenceChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Checker newChecker = new Checker();
            Console.WriteLine("Enter a string which you would like to check for references:");

            newChecker.inputString = Console.ReadLine();
            newChecker.CheckReference();
        }
    }
}
