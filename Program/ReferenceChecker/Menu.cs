using System;
using System.Collections.Generic;
using System.Text;

namespace ReferenceChecker
{
    class Menu
    {
        private string mQuestion = "";
        private string[] mOptions;
        private int mSelection;

        public Menu()
        { }

        public string getQuestion
        {
            set
            {
                this.mQuestion = value;
            }
            get
            {
                if(this.mQuestion == "")
                {
                    throw new ArgumentNullException("Empty Input detrected");
                }
                else
                {
                    return this.mQuestion;
                }
            }
        }

        //Menu to select output options
        public void DisplayMenu(string pQuestion, string[] pAnswers)
        {
            Checker newChecker = new Checker();
            Dictionary newDictionary = new Dictionary();

            while (mSelection != pAnswers.Length)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n" + pQuestion);

                for (int ansIndex = 0; ansIndex < pAnswers.Length; ansIndex++)
                {
                    Console.WriteLine((ansIndex + 1) + ": " + pAnswers[ansIndex]);
                }
                Console.WriteLine("Select an Option");
                mSelection = GetNumberInRange(1, pAnswers.Length);

                switch (mSelection)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter a string which you would like to check for references:");
                        newChecker.inputString = Console.ReadLine();
                        newChecker.CheckReference();
                        break;
                    case 2:
                        break;
                    case 3:
                        Console.Clear();
                        newDictionary.ViewReferences();
                        break;

                }
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        //Gets a number in a specified range
        private int GetNumberInRange(int pMin, int pMax)
        {
            Console.WriteLine("Please enter a number between " + pMin + " and " + pMax + " inclusive");
            return int.Parse(Console.ReadLine());
        }
    }
}
