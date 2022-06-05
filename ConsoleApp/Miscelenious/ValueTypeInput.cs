using System;

namespace ConsoleApp.Miscelenious
{
    public class ValueTypeInput
    {
        public ValueTypeInput()
        {
            Init();
        }

        private void Init()
        {
            Console.WriteLine($"Enter a value: ");
            string input = Console.ReadLine();
            Console.WriteLine("Select the Data type to validate the input you have entered.\nPress 1 for String " +
                              "Press 2 for Integer" +
                              "Press 3 for Boolean");
            var typeOfDataInput = Convert.ToInt32(Console.ReadLine());

            switch (typeOfDataInput)
            {
                case 1:
                    StringLogic(input);
                    break;
                case 2:
                    IntLogic(input);
                    break;
                case 3:
                    BoolLogic(input);
                    break;
            }
        }
        
        
        private void BoolLogic(string input)
        {
            var result = bool.TryParse(input, out var output);
            var message = result ? input : "Invalid Bool";
            Console.WriteLine(message);
            Console.ReadKey();
            Init();
        }

        private void IntLogic(string input)
        {
            var result = int.TryParse(input, out var output);
            var message = result ? input : "Invalid Int";
            Console.WriteLine(message);
            Console.ReadKey();
            Init();
        }

        private void StringLogic(string input)
        {

            var message = input.HasOnlyLetters() ? input : "This input has not only letters";
            Console.WriteLine(message);
            Console.ReadKey();
            Init();
        }
    }
}