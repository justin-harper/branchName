using System;
using System.Text.RegularExpressions;

namespace branchName
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                throw new ArgumentException("Input string is required. Have you run git symbolic-ref -q HEAD ?");
            }

            Regex rx = new Regex(@"[A-Z]{7}-[0-9]{4}");
            string matching = rx.Match(args[0]).Value;

            if (string.IsNullOrEmpty(matching))
            {
                throw new ArgumentException("Invalid input string; is the branch name in the correct format?");
            }

            System.Console.Write(matching);
        }
    }
}
