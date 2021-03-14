using System.Collections.Generic;
using System.Linq;

namespace MyString
{
    class My_string
    {
        private List<char> CharArray { get; set; }

        public My_string(List<char> charArray)
        {
            CharArray = charArray;
        }

        public My_string(string str)
        {
            CharArray = str.ToCharArray().ToList();
        }

        public int Length
        {
            get
            {
                return CharArray.Count;
            }
        }

        public bool CheckIfContains(string subString)
        {
            return this.ToString().Contains(subString);

        }

        public bool CheckIfContains(char c)
        {
            return CharArray.Contains(c);
        }

        public int GetIndexOfElement(char c)
        {
            return CharArray.IndexOf(c);
        }

        public static My_string operator +(My_string string1, My_string string2)

        {       
        var newList = new List<char>(string1.CharArray);
        newList.AddRange(string2.CharArray);
        return new My_string(newList);
        }
        public override string ToString()
        {
            string newString = new string(CharArray.ToArray());
            return newString;
        }
}
}

    


