using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackingTheCodePuzzles.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodePuzzles.Implementation.Tests
{
    [TestClass()]
    public class StringBuilderTests
    {
        [TestMethod()]
        public void StringBuilderTest()
        {
            StringBuilder strBuild = new StringBuilder("abcd");
            Assert.AreEqual(strBuild.ToString(), "abcd", "Append test fails.");
        }

        [TestMethod()]
        public void AppendTest_Simple()
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.Append("a");
            strBuild.Append("bcd");
            Assert.AreEqual("abcd", strBuild.ToString(), "Append test fails.");
        }

        [TestMethod()]
        public void AppendTest_Large()
        {
            StringBuilder strBuild = new StringBuilder();
            string word = "abcdefghijklmnop";
            strBuild.Append(word);
            strBuild.Append(word);
            strBuild.Append(word);
            strBuild.Append(word);
            Assert.AreEqual(word + word + word + word, strBuild.ToString(), "Append test fails.");
        }


    }
}