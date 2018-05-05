using System;

namespace RemoveCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            var sentence = Console.ReadLine();
            Console.WriteLine("Enter character to remove from string");
            var character = Convert.ToChar(Console.ReadLine());

            var remove = new Removal();
            Console.WriteLine(remove.RemoveCharacterFromString(character, sentence));
        }
    }
}
