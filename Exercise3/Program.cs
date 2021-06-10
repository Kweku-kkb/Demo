using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a word: ");
            string word = Console.ReadLine();
            Program reverse = new Program();
            string text = reverse.Reverse(word);
            Console.Write(text);
        }

        public string Reverse(string text)
        {
            if (text == null)
                return null;
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
