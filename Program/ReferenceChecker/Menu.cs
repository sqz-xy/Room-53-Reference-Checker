﻿using System;
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
                    throw new ArgumentNullException("Empty Input detected");
                }
                else
                {
                    return this.mQuestion;
                }
            }
        }

        /// <summary>
        /// Displays a menu based on a question parameter and answer parameter
        /// </summary>
        /// <param name="pQuestion">Question to be asked</param>
        /// <param name="pAnswers">Responses</param>
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
                        Console.Clear();
                        newDictionary.AddReferences();
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

        /// <summary>
        /// Gets a number within a specified range
        /// </summary>
        /// <param name="pMin">Minimum number</param>
        /// <param name="pMax">Maximum number</param>
        /// <returns></returns>
        private int GetNumberInRange(int pMin, int pMax)
        {
            try
            {
                Console.WriteLine("Please enter a number between " + pMin + " and " + pMax + " inclusive");
                return int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("That was not a valid integer");
                return mOptions.Length;
            }

        }
    }
}
