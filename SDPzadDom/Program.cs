using System;

namespace SDPzadDom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst");
            var input = Console.ReadLine();
            var test = new Palindrom(input);
            if(test.IsPalindrom)
            {
                Console.WriteLine("Tekst to palindrom");
            }
            else
            {
                Console.WriteLine("Tekst to nie palindrom");
            }
        }
    }
}
