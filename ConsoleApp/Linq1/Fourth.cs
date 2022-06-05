using System;
using System.Linq;

namespace LinqExercises.OldLinq
{
    
    /*Write a program in C# Sharp to display the number and frequency of number from giving array.*/
    
    public class Fourth
    {
        int[] _numbers = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

        public void GetArrayElementsAmount()
        {
            var groupBy = _numbers.GroupBy(number => number);
            Console.WriteLine(string.Join(" ", groupBy.GetEnumerator()));
        }
    }
}