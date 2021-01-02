using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodePuzzles.Implementation
{
    /// <summary>
    /// Linked List data structure. Wrapper class for NodeTest to allow multiple references to
    /// the linked list while reducing risk of losing track of head node.
    /// </summary>
    /// <typeparam name="T">Generic value for a node</typeparam>
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }
    }
}
