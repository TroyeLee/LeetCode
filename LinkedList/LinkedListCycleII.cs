using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class LinkedListCycleII
    {
        public ListNode DetectCycle(ListNode head)
        {
            if(head == null)
            {
                return null;
            }
            HashSet<ListNode> visited = new HashSet<ListNode>();

            visited.Add(head);
            ListNode node = head.next;

            while (node != null)
            {
                if (visited.Contains(node))
                {
                    return node;
                }
                visited.Add(node);
                node = node.next;
            }

            return null;
        }


        public ListNode DetectCycle02(ListNode head)
        {
            if(head == null)
            {
                return null;
            }

            ListNode meetingPlace = GetMeetingPlace(head);
            ListNode meetAgain = head;
            if (meetingPlace != null)
            {
                while(meetingPlace != meetAgain)
                {
                    meetAgain = meetAgain.next;
                    meetingPlace = meetingPlace.next;
                }
                return meetingPlace;
            }

            return null;
        }

        private ListNode GetMeetingPlace(ListNode head)
        {

            ListNode node_slow = head;
            ListNode node_fast = head;

            while(node_fast!=null && node_fast.next != null)
            {
                node_slow = node_slow.next;
                node_fast = node_fast.next.next;
                if(node_fast == node_slow)
                {
                    return node_fast;
                }
            }

            return null;
        }
    }
}
