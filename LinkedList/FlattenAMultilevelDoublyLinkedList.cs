using LeetCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class FlattenAMultilevelDoublyLinkedList
    {
        /// <summary>
        /// 扁平化多级双向链表
        /// 多级双向链表中，除了指向下一个节点和前一个节点指针之外，它还有一个子链表指针，可能指向单独的双向链表。
        /// 这些子列表也可能会有一个或多个自己的子项，依此类推，生成多级数据结构，如下面的示例所示。
        /// 给你位于列表第一级的头节点，请你扁平化列表，使所有结点出现在单级双链表中。
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public MultilevelNode Flatten(MultilevelNode head)
        {
            if (head == null)
            {
                return null;
            }
            MultilevelNode curNode = head;
            MultilevelNode result = curNode;

            while (curNode != null)
            {
                if (curNode.child != null)
                {
                    MultilevelNode childHead = curNode.child;
                    MultilevelNode childTail = GetChildEnd(childHead);
                    curNode.child = null;//断子

                    if (curNode.next != null)//连接尾
                    {
                        childTail.next = curNode.next;
                        childTail.next.prev = childTail;
                    }

                    curNode.next = childHead;//连接头
                    curNode.next.prev = curNode;



                }

                curNode = curNode.next;

            }

            return result;
        }

        private MultilevelNode GetChildEnd(MultilevelNode data)
        {
            while (data.next != null)
            {
                data = data.next;
            }
            return data;
        }

        /// <summary>
        /// 深度遍历解决扁平化
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public MultilevelNode Flatten02(MultilevelNode head)
        {
            if (head == null)
            {
                return null;
            }

            MultilevelNode result = new MultilevelNode();

            result.next = head;
            head.prev = result;

            Flatten_DFS(result, head);
            result.next.prev = null;

            return result.next;
        }
        //深度遍历寻找尾巴，顺便建立关系
        private MultilevelNode Flatten_DFS(MultilevelNode prev, MultilevelNode curr)
        {
            if (curr == null)
            {
                return prev;
            }
            prev.next = curr;
            curr.prev = prev;

            MultilevelNode tempNext = curr.next;


            MultilevelNode tail = Flatten_DFS(curr, curr.child);

            curr.child = null;

            return Flatten_DFS(tail, tempNext);

        }
    }
}
