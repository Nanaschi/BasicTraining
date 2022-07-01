using System;

namespace ConsoleApp.Basics
{
    public class BasicsMethods
    {

        public BasicsMethods(float num1, float num2)
        {
            ElementaryOperations(num1, num2);
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
        
    }
}