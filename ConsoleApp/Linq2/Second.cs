using System;
using System.Linq;

namespace ConsoleApp.Linq2
{
    /*Write a query that returns words at least 5 characters long and make them uppercase.
        Expected input and output
    "computer", "usb" → "COMPUTER"*/
    
    
    public class Second
    {

        private string[] _text = {"comp", "usb", "house", "cucumber", "ukulele", "whether"};

        public void GetSufficientWords(int maxAmountOfWords)
        {
            var enumerable = _text
                .Where(word => word.Length >= maxAmountOfWords)
                .Select(word => word.ToUpper());
            Console.WriteLine(string.Join(" " , enumerable));
        }

    }
}