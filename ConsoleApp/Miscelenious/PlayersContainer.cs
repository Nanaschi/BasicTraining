using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Miscelenious
{
    public class PlayersContainer
    {
        private List<string> names;
        private string[] lastNames;
        public PlayersContainer()
        {
            ListIntialization();
            ArrayIntialization();
            FullName();
        }

        private void ArrayIntialization()
        {
            lastNames = new []
            {
                "Franklin", "O'Brian", "Mc Gregor"
            };
        }

        private void ListIntialization()
        {
            names = new List<string>()
            {
                "Bob", "Sam", "Pol"
            };
        }

        private void FullName()
        {
            string[] joinednames = names.Zip
                (lastNames, (name, lastName) => $"{name} {lastName}").ToArray();
            Console.WriteLine(string.Join(", ", joinednames));
        }
    }
}