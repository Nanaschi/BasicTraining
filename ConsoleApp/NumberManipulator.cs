using System;

namespace ConsoleApp
{
    public class NumberManipulator
    {
        private void GetOdd(int[] array)
        {
            foreach (var number in array)
            {
                if (number.IsOdd())
                {
                    Console.WriteLine($"Odd number is {number}");
                }
            }
        }

        private void GetEven(int[] array)
        {
            foreach (var number in array)
            {
                if (number.IsEven())
                {
                    Console.WriteLine($"Even number is {number}");
                }
            }
        }
        
        public void Run()
        {
            int[] array = {1,2,3,4,5,6,7,8,9,10};
            
            GetOdd(array);
            GetEven(array);
            
        }
    }
}