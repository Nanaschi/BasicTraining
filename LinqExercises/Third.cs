using System;
using System.Linq;

namespace LinqExercises
{
    public class Third
    {
        /*Write a program in C# Sharp to find the number of an array and the 
        square of each number which is more than 20.*/
        
        int[] _numbers = new[] { 3, 9, 2, 8, 6, 5 };

        public void GetNumbersWithCertainSqr(int maxAllowedSqr)
        {
            var listOfAllowedNumbers =
                _numbers.Where(number => Math.Pow(number, 2) > maxAllowedSqr);

            foreach (var number in listOfAllowedNumbers)
            {
                    Console.WriteLine($"Number = {number}, SqrNo = {Math.Pow(number, 2)} ");
            }
        }
    }
}