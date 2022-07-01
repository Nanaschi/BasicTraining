using System;
using System.Linq;

namespace ConsoleApp.Linqs.Linq2.Light
{
    
    /*Write a query that returns top 5 numbers from the list of integers in descending order.
        Expected input and output
        [78, -9, 0, 23, 54,  21, 7, 86]  → 86 78 54 23 21*/
    
    
    public class OrderByDescendingTake
    {
        private int[] _numbers ={6, 0, 999, 11, 443, 6, 1, 24, 54};

        public void GetDescendingNumbers(int amountOfNumbers)
        {
            var orderByDescending = _numbers.OrderByDescending(number => number)
                .Take(amountOfNumbers);
            
            
            Console.WriteLine(string.Join(" ", orderByDescending));
        }
    }
}