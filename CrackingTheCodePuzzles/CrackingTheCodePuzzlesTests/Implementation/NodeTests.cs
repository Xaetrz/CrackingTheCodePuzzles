using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackingTheCodePuzzles.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodePuzzles.Implementation.Tests
{
    [TestClass()]
    public class NodeTests
    {
        LinkedList<int> intLinkList;
        LinkedList<string> strLinkList;

        [TestInitialize]
        public void InitializeTests()
        {
            intLinkList = new LinkedList<int>();
            strLinkList = new LinkedList<string>();
        }

        [TestMethod()]
        public void AppendToTailTest_OneAppend()
        {
            Node<int> head = new Node<int>(72);
            intLinkList.Head = head;
            head.AppendToTail(10);

            Assert.AreEqual(72, head.Value, "One append case fails (head value is wrong)");
            Assert.AreEqual(10, head.Next.Value, "One append case fails (second node value is wrong)");
        }

        [TestMethod()]
        public void AppendToTailTest_MultiAppend()
        {
            Node<string> head = new Node<string>("20");
            strLinkList.Head = head;
            head.AppendToTail("40");
            head.AppendToTail("1000");
            head.AppendToTail("72347");

            Assert.AreEqual("20", head.Value, "Multi append case fails (head value is wrong)");
            Assert.AreEqual("40", head.Next.Value, "Multi append case fails (second node value is wrong)");
            Assert.AreEqual("1000", head.Next.Next.Value, "Multi append case fails (third node value is wrong)");
            Assert.AreEqual("72347", head.Next.Next.Next.Value, "Multi append case fails (fourth node value is wrong)");
        }

        [TestMethod()]
        public void DeleteNodeTest_ExistingValue()
        {
            Node<int> head = new Node<int>(20);
            intLinkList.Head = head;
            head.AppendToTail(40);
            head.AppendToTail(1000);
            head.AppendToTail(72347);

            Node<int>.DeleteNode(head, 1000);
            Node<int>.DeleteNode(head, 40);

            Assert.AreEqual(20, head.Value, "Delete existing value case fails (head value is wrong)");
            Assert.AreEqual(72347, head.Next.Value, "Delete existing value case fails (second node value is wrong)");
            Assert.IsNull(head.Next.Next, "Delete existing value case fails (third node isn't null)");
        }

        [TestMethod()]
        public void DeleteNodeTest_NonExistingValue()
        {
            Node<int> head = new Node<int>(20);
            intLinkList.Head = head;

            Node<int>.DeleteNode(head, 30);

            Assert.AreEqual(20, head.Value, "Delete non-existing value case fails (head value is wrong)");
            Assert.IsNull(head.Next, "Delete non-existing value case fails (second node isn't null)");
        }
    }
}