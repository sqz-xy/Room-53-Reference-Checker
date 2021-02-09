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
            SetDefaultReferences();
        }

        /*
         * Reads in references from a text file and adds them to a list
         */
        private void SetDefaultReferences()
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
        private void AddReferences()
        {

        }
    }
}
