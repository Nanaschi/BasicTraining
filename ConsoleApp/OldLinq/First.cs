using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercises.OldLinq
{
    /// <summary>
    /// 1. Write a program in C# Sharp to shows how the three parts of a query operation execute.
    ///Expected Output:
    ///The numbers which produce the remainder 0 after divided by 2 are :
    ///0 2 4 6 8
    /// </summary>
    
    
    public class First
    {
        private List<int> _numbers = new List<int>()
        {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9
        };


        public void GetEvenNumbers()
        {
            var evenNumbers = _numbers.Where(number => number % 2 == 0);
            Console.WriteLine(string.Join(" ", evenNumbers));
        }
        
    }
}