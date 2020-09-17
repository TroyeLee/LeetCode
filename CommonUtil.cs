using LeetCode.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CommonUtil
    {  
        public string ConvertToCamelCase(string s)
        {
            StringBuilder result = new StringBuilder();

            string[] words = s.Split('-',' ');

            foreach (var word in words)
            {
                char head = Char.ToUpper(word[0]);

                if(MatchRome(word))
                {
                    result.Append(word.ToUpper());
                    continue;
                }

                string tail = word.Substring(1);
                result.Append(head+tail);

            }

            return result.ToString();
        }

        public ListNode BuildListNode(int[] data)
        {
            ListNode curNode = new ListNode(-1);
            ListNode result = curNode;

            foreach (var item in data)
            {
                curNode.next = new ListNode(item);
                curNode = curNode.next;
            }

            return result.next;
        }

        public bool MatchRome(string word)
        {
            Regex regex = new Regex(@"\b[ivx][ivx]*\b");
            if (regex.IsMatch(word))
            {
                return true;
            }
            return false;
        }
    }
}
