namespace ConsoleApp.Miscelenious
{
    public static class Extensions
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
        
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }
        
        public static bool HasOnlyLetters(this string text)
        {
            foreach (var character in text)
            {
                if (!char.IsLetter(character)) return false; 
            }

            return true;
        }
    }
}