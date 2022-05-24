using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class4
    {
        static void Main(string[] args)
        {
            string s, revs = "";
            Console.WriteLine(" Enter string");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--) 
            {
                revs += s[i].ToString();
            }
            if (revs == s) 
            {
                Console.WriteLine("String is Palindromen");
            }
            else
            {
                Console.WriteLine("String is not Palindrome");
            }
            Console.ReadLine();
        }
    }
}
