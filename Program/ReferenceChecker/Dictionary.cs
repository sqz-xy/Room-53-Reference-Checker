using System;
using System.Collections.Generic;
using System.Text;

namespace ReferenceChecker
{
    class Dictionary
    {
        private Dictionary<int, string> dReferences = new Dictionary<int, string>();

        /*
         * Getter Method for the dictionary
         * Returns value with specified key
         */
        public string Get(int key)
        {
            string result = null;

            if (dReferences.ContainsKey(key))
            {
                result = dReferences[key];
            }

            return result;
        }
        /*
         * Initializes the dictionary
         */
        public void initialize()
        {
            SetDefaultReferences();
        }

        /*
         * Sets the default references
         * - Add functionality to set references later
         * - Add more references later
         */
        private void SetDefaultReferences()
        {
            dReferences.Add('0', "gunga");
            dReferences.Add('1', "ginga");
        }
    }
}
