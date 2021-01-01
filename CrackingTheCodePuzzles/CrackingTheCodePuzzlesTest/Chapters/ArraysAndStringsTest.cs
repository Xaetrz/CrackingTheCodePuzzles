using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackingTheCodePuzzles.Chapters;
using CrackingTheCodePuzzles.Implementation;

namespace CrackingTheCodePuzzlesTest.Chapters
{
    [TestClass]
    public class ArraysAndStringsTest
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
    }
}
