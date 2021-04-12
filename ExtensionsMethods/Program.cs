using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionsMethods
{
    public static class StringExtensions
    {
        public static string Capitalise(this string str)

        {
            return string.Join(" ", str.Split(" ").Where(s => !String.IsNullOrEmpty(s)).Select(s => char.ToUpper(s[0]) + s[1..]));
            //List<string> newWords = new List<string>();
            //var words = str.Split(" ");
            //foreach (string word in words)
            //{
            //    string firstLetter = word[0].ToString().ToUpper();
            //    string newWord = firstLetter + word.Substring(1);
            //    newWords.Add(newWord);
            //}
            //return string.Join(" ", newWords);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hi, hitler";           
            Console.WriteLine(str.Capitalise());
        }
    }
}
