using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodePuzzles.Implementation
{
    /// <summary>
    /// Singly-Linked node for Linked List data structure.
    /// </summary>
    /// <typeparam name="T">Generic value for a node</typeparam>
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node()
        {
            this.Value = default;
        }

        public Node(T val)
        {
            this.Value = val;
        }

        public void AppendToTail(T val)
        {
            Node<T> newNode = new Node<T>(val);
            Node<T> curNode = this;

            while (curNode.Next != null)
            {
                curNode = curNode.Next;
            }
            curNode.Next = newNode;
        }

        public static Node<T> DeleteNode(Node<T> head, T val)
        {
            Node<T> curNode = head;
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
