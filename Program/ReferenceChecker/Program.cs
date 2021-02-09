using System;

namespace ReferenceChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Options = { "Enter a sentence", "Add a reference", "View References", "Exit" };
            string Question = "Choose an option:";

            Menu newMenu = new Menu();
            newMenu.DisplayMenu(Question, Options);
        }
    }
}
