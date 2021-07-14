using System;
using System.Collections.Generic;
using System.Linq;

namespace MyString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allPrepositions = new string[] { "над", "под", "из-за", "на", "в", "во" };
            string sourceString = "Над пропастью во ржи. Из-за леса из-за гор";

            var words = sourceString.ToLower().Split(' ', '.', ',');
            //Dictionary<string, int> dict = new Dictionary<string, int>();
            //foreach (var word in words)
            //{
            //    if (allPrepositions.Contains(word))
            //    {
            //        if (dict.ContainsKey(word))
            //        {
            //            dict[word]++;
            //        }
            //        else
            //        {
            //            dict.Add(word, 1);
            //        }
            //    }
            //}
            //Console.WriteLine(string.Join(",",dict));
            
            words.Where(w=>allPrepositions.Contains(w.ToLower()))
                .GroupBy(w=>w)
                .Select(g=> $"{g.Key} - {g.Count()}")
                .ToList()
                .ForEach(s=>Console.WriteLine(s));
            return;

            My_string myString = new My_string(new List<char>() { 'a', 'b', 'c'});

            char checkItem = 'b';

            Console.WriteLine($"Is '{checkItem}' in the string?\t {myString.CheckIfContains(checkItem)}");
            Console.WriteLine($"Index of element '{checkItem}' = { myString.GetIndexOfElement(checkItem)}");

            string subString = "bc";
            Console.WriteLine($"Is {subString} in the string?\t {myString.CheckIfContains(subString)}");
        }
        
    }
}
