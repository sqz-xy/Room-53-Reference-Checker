using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ReferenceChecker
{
    class Dictionary
    {
        private string mLine;
        private int mNumberOfLines = 0;
        private int mRefIndex = 1;
        private string mEnteredRefs;
        private string[] mEnteredRefsArray;
        private List<string> lReferences = new List<string>();
        /*
         * Returns the list
         */
        public List<string> GetList()
        {
            return lReferences;
        }

        /*
         * Initializes the dictionary
         */
        public void initialize()
        {
            SetReferences();
        }

       /// <summary>
       /// Reads in references from a text file and adds them to the list
       /// </summary>
        private void SetReferences()
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader("References.txt");

                while(!reader.EndOfStream)
                {
                    mLine = reader.ReadLine();
                    lReferences.Add(mLine);
                    mNumberOfLines++;
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("File could not be read");
                Console.WriteLine(e.Message);
            }
            finally
            {
                reader.Close();
            }
        }
        /// <summary>
        /// Adds a reference to the list, sentences are split into invidivual words
        /// </summary>
        public void AddReferences()
        {
            Checker newChecker = new Checker();
            StreamWriter writer = null;

            Console.WriteLine("Enter a reference: ");
            string inputString = Console.ReadLine();
            string[] WordArray = newChecker.FormatString(inputString);
            try
            {
                writer = new StreamWriter("References.txt", true);
                for (int i = 0; i < WordArray.Length; i++)
                {
                    writer.WriteLine(WordArray[i]);
                }            
            }
            catch (IOException e)
            {
                Console.WriteLine("File could not be read");
                Console.WriteLine(e.Message);
            }
            finally
            {
                writer.Close();
            }

        }
        /// <summary>
        /// Loops through the list and displays the entries
        /// </summary>
        public void ViewReferences()
        {
            initialize();
            Console.WriteLine("Here are the references:");
            foreach (string entry in lReferences)
            {
                Console.WriteLine(mRefIndex + ": " + entry);
                mRefIndex++;
            }
        }
    }
}
