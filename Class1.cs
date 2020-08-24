using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Class1
    {  
        public string ConvertToCamelCase(string s)
        {
            StringBuilder result = new StringBuilder();

            string[] words = s.Split('-',' ');

            foreach (var word in words)
            {
                char head = Char.ToUpper(word[0]);
                string tail = word.Substring(1);
                result.Append(head+tail);

            }

            return result.ToString();
        }
    }
}
