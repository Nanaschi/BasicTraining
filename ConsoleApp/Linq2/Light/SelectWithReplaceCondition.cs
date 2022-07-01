using System;
using System.Linq;

namespace ConsoleApp.Linq2
{
    
    //Write a query that replaces 'ea' substring with astersik (*) in given list of words.
    public class SelectWithReplaceCondition
    {
        private string[] text = {"near", "speak", "tonight", "weapon", "customer", "deal", "lawyer"};

        public void GetModifiedWords(string lettersToModify, string lettersToReplace)
        {
            var enumerable = text.Select(word =>
                word.Contains(lettersToModify) 
                    ? word.Replace(lettersToModify, lettersToReplace) 
                    : word);
            
            Console.WriteLine(string.Join(" ", enumerable));
        }
    }
}