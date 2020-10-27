using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse string application");
            Console.Write("Insert word or sentence: ");
            string insertedWord = Console.ReadLine();

            char[] wordArray = insertedWord.ToCharArray();
            Array.Reverse(wordArray);

            Console.WriteLine(wordArray);
            Console.ReadLine();

        }
    }
}
