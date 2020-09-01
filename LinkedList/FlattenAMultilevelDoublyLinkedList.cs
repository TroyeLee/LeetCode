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
        public Node Flatten(Node head)
        {
            if (head == null)
            {
                return null;
            }
            Node curNode = head;
            Node result = curNode;

            while (curNode != null)
            {
                if (curNode.child != null)
                {
                    Node childHead = curNode.child;
                    Node childTail = GetChildEnd(childHead);
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

        private Node GetChildEnd(Node data)
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
        public Node Flatten02(Node head)
        {
            if (head == null)
            {
                return null;
            }

            Node result = new Node();

            result.next = head;
            head.prev = result;

            Flatten_DFS(result, head);
            result.next.prev = null;

            return result.next;
        }
        //深度遍历寻找尾巴，顺便建立关系
        private Node Flatten_DFS(Node prev, Node curr)
        {
            if (curr == null)
            {
                return prev;
            }
            prev.next = curr;
            curr.prev = prev;

            Node tempNext = curr.next;


            Node tail = Flatten_DFS(curr, curr.child);

            curr.child = null;

            return Flatten_DFS(tail, tempNext);

        }
    }
}
