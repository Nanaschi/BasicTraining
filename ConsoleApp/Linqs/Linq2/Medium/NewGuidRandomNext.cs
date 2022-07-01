using System;
using System.Linq;

namespace ConsoleApp.Linq2
{
    //Write a query that shuffles sorted array.
    
    public class NewGuidRandomNext
    {
        private int[] numbers = {38, 24, 8, 0, -1, -17, -33, -100};

        
        
        public void ShuffleLogic()
        {
            var rnd = new Random();
            /*var shuffled = numbers.OrderBy(number => Guid.NewGuid()).ToList();*/
            
            var shuffledArray = numbers.OrderBy(i => rnd.Next());
            
            Console.WriteLine(string.Join(" ", shuffledArray));
        }
    }
}