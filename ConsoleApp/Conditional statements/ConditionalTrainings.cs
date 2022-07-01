using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Conditional_statements
{
    public class ConditionalTrainings
    {
        internal ConditionalTrainings(object obj1 = null, object obj2 = null)
        {
            Console.WriteLine(IfSortedAscending( (int[]) obj1)); ;
        }
        
        
        /*Given two integers, write a method that returns their multiplication if
        they are both divisible by 2 or 3, otherwise returns thier sum.
            Expected input and output
            DivisibleBy2Or3(15, 30) → 450
        DivisibleBy2Or3(2, 90) → 180
        DivisibleBy2Or3(7, 12) → 19*/
        
        private int DivisibleBy2Or3(int num1, int num2)
        {
            var num1check1 = num1 % 2 == 0;
            var b1 = num2 % 2 == 0;
            var num1check2 = num1 % 3 == 0;
            var b3 = num2 % 3 == 0;
            var result = (num1check1 || num1check2) && (b1 || b3) ? num1 * num2 : num1 + num2;
            return result;
        }

        
        /*Given a 3 characters long string, write a method that
         checks if it consists only of uppercase letters.
            Expected input and output
            IfConsistsOfUppercaseLetters("xyz") → false
        IfConsistsOfUppercaseLetters("DOG") → true
        IfConsistsOfUppercaseLetters("L9#") → false*/

        private bool IfConsistsOfUppercaseLetters(string text)
        {
            /*return (str[0] >= 65 && str[1] >= 65 && str[2] >= 65) && (str[0] <= 90 && str[1] <= 90 && str[2] <= 90);*/
            return text.ToCharArray().All(char.IsUpper);
        }


        /*Given an array of three integers, write a method that checks
         if they are sorted in ascending order.
            Expected input and output
            IfSortedAscending([3, 7, 10])→ true
        IfSortedAscending([74, 62, 99])→ false*/
        
        private bool IfSortedAscending(int[] numArray)
        {
            var orderedEnumerable = numArray.OrderBy(number => number);
            return orderedEnumerable.ToArray().SequenceEqual(numArray);
        }
        
        
        
    }
}