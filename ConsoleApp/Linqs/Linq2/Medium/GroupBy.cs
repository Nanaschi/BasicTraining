using System;
using System.Linq;

namespace ConsoleApp.Linq2
{
    /*Write a query that returns most
    frequent character in string. Assume that there is only one such character.*/
    public class GroupBy
    {
        private string _text = "n093nfv034nie9";

        public void GetFrequentCharacter()
        {
            var arrayText = _text.ToCharArray();

            var groupBy = arrayText.GroupBy(character => character)
                .OrderByDescending(character => character.Count())
                .First().Key;
            
            
            Console.WriteLine(string.Join(" ", groupBy));
            
        }
    }
}