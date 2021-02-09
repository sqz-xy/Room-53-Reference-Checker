using System;
using System.Collections.Generic;
using System.Text;

namespace ReferenceChecker
{
    class Checker
    {
        //User Input
        private string mInputString;
        private string[] mInputStringArray;
        //Indexes
        private int mWordIndex = 0;
        //Variables for the maths
        private double mAnswer;
        private double mPercentage;


        /*
         * Constructor
         */
        public Checker()
        { }

        /*
         * Getters and Setters for private variables
         */
        public string inputString
        {
            set
            {
                this.mInputString = value;
            }
            get
            {
                if(this.mInputString == "")
                {
                    throw new ArgumentNullException("Empty input detected");
                }
                else
                {
                    return this.mInputString;
                }

            }
        }
        /// <summary>
        /// Formats the input string to be better to work with
        /// </summary>
        /// <param name="pInputString">User input</param>
        /// <returns></returns>
        public string[] FormatString(string pInputString)
        {
            var CharsToRemove = new string[] { ",", ".", "!", "?","'"};
            foreach (var ch in CharsToRemove)
            {
                pInputString = pInputString.Replace(ch, string.Empty);
            }
            string[] InputStringArray = pInputString.Split(' ');

            for (int i = 0; i < InputStringArray.Length; i++)
            {
                InputStringArray[i] = InputStringArray[i].ToLower();
            }

            return InputStringArray;
        }
        /// <summary>
        /// Checks the input string against the list of references
        /// </summary>
        public void CheckReference()
        {
            Dictionary newDictionary = new Dictionary();
            newDictionary.initialize();
            mInputStringArray = FormatString(mInputString);
               
            foreach(string entry in newDictionary.GetList())
            {
                foreach(string word in mInputStringArray)
                {
                    if(entry == word)
                    {
                        mWordIndex++;
                        //Console.WriteLine("Reference found");
                    }
                }
            }
            mAnswer = getPercentage(mWordIndex, mInputStringArray.Length);
            Console.WriteLine("The Reference percentage is " + mAnswer +"%");
        }
        /// <summary>
        /// Calculates the percentage of reference
        /// </summary>
        /// <param name="pWordIndex">Number of references</param>
        /// <param name="pArraySize">Number of words</param>
        /// <returns></returns>
        private double getPercentage(double pWordIndex, double pArraySize)
        {
            mPercentage = (pWordIndex / pArraySize) * 100;
            return mPercentage;
        }
    }
}
