using LeetCode.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public Node BuildAMultilevelNode(int?[] data)
        {
            Node curNode = new Node();
            Node result = curNode;
            result.next = new Node(data[0], result);
            curNode = curNode.next;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(curNode);

            for (int i = 1; i < data.Length; i++)
            {
                if (data[i - 1] == null)
                {
                    curNode = queue.Dequeue();
                    BuildTheChildNode(curNode, data[i], queue);
                    curNode = curNode.child;
                }
                else
                {
                    BuildTheSingleNode(curNode, data[i], queue);
                    curNode = curNode.next;
                }
            }

            return result.next;
        }
        private void BuildTheSingleNode(Node cur , int? val, Queue<Node> queue)
        {
            cur.next = val == null ? null : new Node(val, cur);
            if (val != null)
                queue.Enqueue(cur.next);
        }
        private void BuildTheChildNode(Node cur, int? val, Queue<Node> queue)
        {
            cur.child = val == null ? null : new Node(val, cur);
            if (val != null)
                queue.Enqueue(cur.next);
        }
    }
}
