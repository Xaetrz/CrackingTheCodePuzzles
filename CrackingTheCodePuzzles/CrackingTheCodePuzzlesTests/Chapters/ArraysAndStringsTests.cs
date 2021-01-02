using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackingTheCodePuzzles.Chapters;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodePuzzles.Chapters.Tests
{
    [TestClass()]
    public class ArraysAndStringsTests
    { 
        /// <summary>
        /// Tests the unique case for the IsUnique method 
        /// </summary>
        [TestMethod]
        public void IsUnique_UniqueCase()
        {
            string uniqueWord = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            bool result = ArraysAndStrings.IsUnique(uniqueWord);
            Assert.IsTrue(result, "Unique test case evaulated as not unique.");
        }

        /// <summary>
        /// Tests the non-unique case for the IsUnique method 
        /// </summary>
        [TestMethod]
        public void IsUnique_NotUniqueCase()
        {
            string notUniqueWord = "ZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            bool result = ArraysAndStrings.IsUnique(notUniqueWord);
            Assert.IsFalse(result, "Non-unique test case evaulated as unique.");
        }

        /// <summary>
        /// Tests the permutation case for the CheckPermutation method 
        /// </summary>
        [TestMethod]
        public void CheckPermutation_IsPermutationCase()
        {
            string word1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string word2 = "ZYXWVUTSRQPONMLKJIHGFEDCBA";
            bool result = ArraysAndStrings.CheckPermutation(word1, word2);
            Assert.IsTrue(result, "Failed true permutation case.");
        }

        /// <summary>
        /// Tests the non-permutation case for the CheckPermutation method 
        /// </summary>
        [TestMethod]
        public void CheckPermutation_IsNotPermutationCase()
        {
            string word1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string word2 = "zYXWVUTSRQPONMLKJIHGFEDCBA";
            bool result = ArraysAndStrings.CheckPermutation(word1, word2);
            Assert.IsFalse(result, "Failed false permutation case.");
        }
    }
}