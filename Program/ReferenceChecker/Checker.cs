using System;
using System.Collections.Generic;
using System.Text;

namespace ReferenceChecker
{
    class Checker
    {
        private string mInputString;
        private int mKeyIndex = 0;

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

        public int KeyIndex
        {
            set
            {
                this.mKeyIndex = value;
            }
            get
            {
                if (this.mKeyIndex == -KeyIndex)
                {
                    throw new ArgumentNullException("Invalid Key");
                }
                else
                {
                    return this.mKeyIndex;
                }
            }
        }

        public void CheckReference()
        {
            Dictionary newDictionary = new Dictionary();
        }
    }
}
