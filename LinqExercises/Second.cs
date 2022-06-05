using System;
using System.Linq;

namespace LinqExercises
{
    
    /*Write a program in C# Sharp to find the +ve numbers from a list of numbers
    using two where conditions in LINQ Query.Go to the editor
    Expected Output:
    The numbers within the range of 1 to 11 are :
    1 3 6 9 10*/
    public class Second
    {
        int[] numbers = {  
            1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14  
        };


        public void GetPositiveNumbersInRange(int lowerBorder, int upperBorder)
        {
            var numbersInRange = numbers.Where
                (number => number >= lowerBorder && number <= upperBorder);
            Console.WriteLine(string.Join(" ", numbersInRange));
        }
    }
}