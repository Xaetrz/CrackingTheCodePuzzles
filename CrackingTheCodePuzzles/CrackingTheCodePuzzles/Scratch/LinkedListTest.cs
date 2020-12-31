using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodePuzzles
{
    /// <summary>
    /// Linked List data structure. Wrapper class for NodeTest to allow multiple references to
    /// the linked list while reducing risk of losing track of head node.
    /// </summary>
    /// <typeparam name="T">Generic value for a node</typeparam>
    public class LinkedListTest<T>
    {
        public NodeTest<T> Head { get; set; }
    }

    /// <summary>
    /// Singly-Linked node for Linked List data structure.
    /// </summary>
    /// <typeparam name="T">Generic value for a node</typeparam>
    public class NodeTest<T>
    {
        public T Value { get; set; }
        public NodeTest<T> Next { get; set; }

        public NodeTest()
        {
            this.Value = default;
        }

        public NodeTest(T val)
        {
            this.Value = val;
        }

        public void AppendToTail(T val)
        {
            NodeTest<T> newNode = new NodeTest<T>(val);
            NodeTest<T> curNode = this;

            while (curNode.Next != null)
            {
                curNode = curNode.Next;
            }
            curNode.Next = newNode;
        }

        public static NodeTest<T> DeleteNode(NodeTest<T> head, T val)
        {
            NodeTest<T> curNode = head;
            if (Comparison<T>.Equals(curNode.Value, val)) return curNode.Next;

            while (curNode.Next != null)
            {   
                if (Comparison<T>.Equals(curNode.Next.Value, val))
                {
                    curNode.Next = curNode.Next.Next;
                    return head;
                }
                curNode = curNode.Next;
            }
            return head;
        }
    }
}
