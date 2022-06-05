using System;
using System.Linq;

namespace ConsoleApp.Linq2
{
    //Given a non-empty list of words, sort it alphabetically and return a word that contains letter 'e'.
    //Pick from the last item
    public class Seventh
    {
        private string[] text = { "cow", "dog", "elephant", "cat", "rat", "squirrel", "snake", "stork"};

        public void GetSpecificWord(string containsLetter)
        {
            var orderedEnumerable = text.OrderBy(word => word)
                .LastOrDefault(word => word.Contains(containsLetter));
            Console.WriteLine(string.Join(" ", orderedEnumerable));
        }
    }
}