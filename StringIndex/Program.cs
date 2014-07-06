using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StringIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = "...You...!!!@!3124131212 Hello have this is a --- string Solved !!...? to test @\n\n\n#!#@#@%$**#$@ Congratz this!!!!!!!!!!!!!!!!one ---Problem\n\n";
            int[] numbers = { 12, -1, 1, -100, 4, 1000, 9, 16, 13, 17, 15 };
            String pattern = "[a-zA-Z0-9]+";

            foreach (int number in numbers)
            {
                int wordCount = Regex.Matches(input, @"[a-zA-Z0-9]+").Count;
                if (number > wordCount || number < 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    int iterations = number;
                    Match match = Regex.Match(input, pattern);
                    while (match.Success && iterations > 1)
                    {
                        match = match.NextMatch();
                        iterations--;
                    }
                    Console.Write(match.Value);
                }

            }
            Console.ReadLine();
        }


        //var matches = Regex.Matches(input, pattern);
        //Console.WriteLine(wordCount);
        //Console.ReadLine();
        //foreach(char c in input)
        //{
        //    bool inWord=false;
        //    if(c)
        //}
    }
}

