using System;
using System.Linq;

namespace ConsoleApp.Linq2
{
    //Write a query that shuffles sorted array.
    
    public class Eighth
    {
        private int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        
        
        public void ShuffleLogic()
        {
            var rnd = new Random();
            /*var shuffled = numbers.OrderBy(number => Guid.NewGuid()).ToList();*/
            
            var shuffledArray = numbers.OrderBy(i => rnd.Next());
            
            Console.WriteLine(string.Join(" ", shuffledArray));
        }
    }
}