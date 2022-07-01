using System;
using System.Linq;

namespace ConsoleApp.Linq2
{
    /*Given a non-empty string consisting only of special chars (!, @, # etc.), 
    return a number (as a string) 
    where each digit corresponds to given special char on the keyboard ( 1→ !, 2 → @, 3 → # etc.).*/
    public class SelectAndModifyByIndexOfArray
    {
        private string _text = "#(@*%)$(&$*#&";
        private char[] chars = { ')', '!', '@', '#', '$', '%', '^', '&', '*', '(' };
        public void TransformInput()
        {
            var text = _text.ToCharArray();

            var decryptedOutput = text.Select(character 
                => Array.IndexOf(chars, character));
            
            
            Console.WriteLine(string.Join("", decryptedOutput));
        }
    }
}