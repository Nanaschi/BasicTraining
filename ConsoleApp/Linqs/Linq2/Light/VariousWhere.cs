using System;
using System.Linq;

namespace ConsoleApp.Linq2
{
    /*Given an array of integers, write a query that returns list of numbers greater than 30 and less than 100.
        Expected input and output
        [67, 92, 153, 15] → 67, 92*/
    public class VariousWhere
    {
        private int[] _numbers = new[] { 67, 92, 153, 15 };

        public void GetNumbersInRange(int lowerBorder, int upperBorder)
        {
            /*var filteredNumbers = _numbers.Where(number => number > 30 && number < 100);*/
            var filteredNumbers = _numbers
                .Where(number => number > 30)
                .Where(number => number < 100);
            Console.WriteLine(string.Join(" ", filteredNumbers));
        }
    }
}