using System;
using System.Linq;

namespace ConsoleApp.Linq2
{
    
    /*Write a query that returns words starting with letter 'a' and ending with letter 'm'.
        Expected input and output
    "mum", "amsterdam", "bloom" → "amsterdam"*/
    
    public class Third
    {
        private string[] _text = {"mum", "amsterdam", "bloom", "armagedom", "deem" , "am"};

        public void GetCorrectWords(string startingLetter, string endingLetter)
        {
            /*var enumerable = _text.Where(word => word.Substring(0, 1) == startingLetter)
                .Where(word => word.Substring(word.Length-1, 1) == endingLetter);*/
            
            var enumerable = _text.Where(word => word.StartsWith(startingLetter))
                .Where(word => word.EndsWith(endingLetter));
            
            
            Console.WriteLine(string.Join(" ", enumerable));
        }
        
    }
}