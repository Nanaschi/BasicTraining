using System;

namespace ConsoleApp.Basics
{
    public class BasicsMethods
    {

        public BasicsMethods(int num1, int num2 = 0, int num3 = 0)
        {
            SwapTwoNumbers(num1, num2);
        }
        
        
        /*Given three numbers, write a method that adds two first ones and 
            ultiplies them by a third one.
            Expected input and output
        AddAndMultiply(2, 4, 5) → 30*/
        private void AddAndMultiply(int sum1, int sum2, int multiply1)
        {
            Console.WriteLine((sum1+sum2)*multiply1);
        }

        /*Given a temperature in Celsius degrees, write a method that converts 
        it to Fahrenheit degrees. Remember that temperature below -271.15°C (absolute zero) 
        does not exist!
        Expected input and output
        CtoF(0) → "T = 32F"
        CtoF(100) → "T = 212F"
        CtoF(-300) → "Temperature below absolute zero!"*/

        private string CelsiusToFarenheit(float celsius)
        {
            var farenheitResult = celsius > -271.15f ? 
                ((celsius * 9 / 5) + 32).ToString() :
                "Temperature below absolute zero!";
            return String.Concat(farenheitResult , "F") ;
            
            
            /*double fahrenheit;

            if (celsius < -273.15)
            {
                return "Temperature below absolute zero!";
            }

            fahrenheit = celsius * 1.8 + 32;
           
            return $"T = {fahrenheit}F";*/
        }

        /*Given two integers, write a method that returns results of their elementary
            arithmetic operations: addition, substraction, multiplication, division.
            Remember that you can't divide any number by 0!
        Expected input and output
        ElementaryOperations(3, 8) → 11, -5, 24, 0.375*/
        
        private void ElementaryOperations(float num1, float num2)
        {
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            var divideResult = num2 == 0 ?
                "Impossible to divide by zero" :
                (num1 / num2).ToString();
            Console.WriteLine(divideResult);
        }

        /*Given two different arithmetic operations 
            (addition, substraction, multiplication, division), 
        write a method that checks if they return the same result.
            Expected input and output
        IsResultTheSame(2+2, 2*2) → true
        IsResultTheSame(9/3, 16-1) → false*/
        private bool IsResultTheSame(float num1,float num2)
        {
            return num1.Equals(num2);
        }

        /*Given three integers, write a method that returns first number 
            divided modulo by second one and these divided modulo by third one.
            Expected input and output
        ModuloOperations(8, 5, 2) → 1*/
        private int ModuloOperations(int num1, int num2, int num3)
        {
            return num1 % num2 % num3;
        }

        /*Given a number, write a method that returns its cube.
            Expected input and output
        TheCubeOf(2) → 8
        TheCubeOf(-5.5) → -166.375*/
        private double TheCubeOf(double baseNumber)
        {
            return Math.Pow(baseNumber, 3);
        }

        private void SwapTwoNumbers(int num1, int num2)
        {
            Console.WriteLine($"Before: a = {num1}, b = {num2};" +
                              $" After: a = {num2}, b = {num1}");
        }
    }
}