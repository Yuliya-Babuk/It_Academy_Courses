using System;
using System.Collections.Generic;


namespace MyString
{
    class Program
    {
        static void Main(string[] args)
        {
            My_string myString = new My_string(new List<char>() { 'a', 'b', 'c'});

            char checkItem = 'b';

            Console.WriteLine($"Is '{checkItem}' in the string?\t {myString.CheckIfContains(checkItem)}");
            Console.WriteLine($"Index of element '{checkItem}' = { myString.GetIndexOfElement(checkItem)}");

            string subString = "bc";
            Console.WriteLine($"Is {subString} in the string?\t {myString.CheckIfContains(subString)}");
        }
        
    }
}
