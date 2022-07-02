using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Conditional_statements
{
    public class ConditionalTrainings
    {
        internal ConditionalTrainings(int obj1, object obj2 = null)
        {
            Console.WriteLine(IfNumberContains3(obj1)); ;
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

        
        /*Given a number, write a method that checks if it is positive, negative or zero.
            Expected input and output
        PositiveNegativeOrZero(5.24) → positive
            PositiveNegativeOrZero(0.0) → zero
            PositiveNegativeOrZero(-994.53) → negative*/
        private string PositiveNegativeOrZero(float number)
        {
            return number < 0 ? 
                "negative": 
                number == 0 ? 
                    "equals zero" : 
                    "positive";
        }
        
        /*Given a year as integer, write a method that checks if year is leap.
            Expected input and output
        IfYearIsLeap(2016) → true
        IfYearIsLeap(2018) → false*/

        private bool IfYearIsLeap(int year)
        {
            return year % 4 == 0;
        }

        /*Write a method that checks if given number (positive integer)
        contains digit 3. Do not convert number to other type.
            Do not use built-in functions like Contains(), StartsWith(), etc.
            Expected input and output
        IfNumberContains3(7201432) → true
        IfNumberContains3(87501) → false*/
        
        private bool IfNumberContains3(int number)
        {
            var array = number.ToString().Select(o=> Convert.ToInt32(o) - 48 ).ToArray();
            return array.Contains(3);
        }
        
    }
}