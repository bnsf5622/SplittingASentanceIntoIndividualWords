using System;

namespace SplittingASentanceIntoIndividualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "I like cheese";

            string[] words = s.Split(' ');

            // loop through all the elements
            for (int i = 0; i < words.Length; i++)
            {
                // print the word at element index i
                Console.WriteLine(words[i]);
            }
        }
    }
}
