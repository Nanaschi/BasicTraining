using System;
using System.Linq;

namespace ConsoleApp.Linq2
{
    
   // Write a query that returns list of numbers and their squares only if square is greater than 20
    
    public class WherePower
    {
        private int[] _numbers = {3, 9, 2, 4, 6, 5, 7};

        public void TakePower(int minimumSqrResult, int power)
        {
            var enumerable = _numbers.Where(number => Math.Pow(number, power) > minimumSqrResult);

            foreach (var number in enumerable)
            {
                Console.WriteLine($"{number} - {Math.Pow(number, power)}");
            }
        }
    }
}