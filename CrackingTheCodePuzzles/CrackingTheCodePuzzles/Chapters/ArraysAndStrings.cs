using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodePuzzles.Chapters
{
    public class ArraysAndStrings
    {
        /// <summary>
        /// 1.1 Is Unique: Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures?
        /// </summary>
        /// <param name="word">String to check</param>
        /// <returns>True if string is unique, false otherwise</returns>
        public static bool IsUnique(string word)
        {
            /*// Brute force algorithm: O(N^2)
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = i + 1; j < word.Length; j++)
                {
                    if (word[i] == word[j]) return false;
                }
            }
            return true;*/

            // Cleaner algorithm, assumes extended ASCII (256 possible characters): O(N)
            if (word.Length > 256) return false;

            bool[] charFlags = new bool[256];
            for (int i = 0; i < word.Length; i++)
            {
                int charVal = word[i];
                if (charFlags[charVal]) return false;
                charFlags[charVal] = true;
            }
            return true;

            /*// Bit manipulation algorithm to conserve space, though must assume only lower-case for 32-bit int: O(N)
            int bitsCheck = 0;

            for (int i = 0; i < word.Length; i++)
            {
                int charBit = 1 << (word[i] - 'a'); // Subtract 'a' to keep bit checker within integer 32-bit limit
                if ((bitsCheck & charBit) > 0) return false;
                bitsCheck |= charBit;
            }
            return true;*/
        }

        /// <summary>
        /// 1.2 Check Permutation: Given two strings, write a method to decide if one is a permutation of the other.
        /// </summary>
        /// <param name="a">String 1</param>
        /// <param name="b">String 2</param>
        /// <returns>True if permutation, false otherwise</returns>
        public static bool CheckPermutation(string a, string b)
        {
            if (a.Length != b.Length) return false;

            // Sort Algorithm: O(Nlog(N) + Mlog(M)), where N is length of a and M is length of b
            char[] arr1 = a.ToCharArray();  // N
            char[] arr2 = b.ToCharArray();  // M
            Array.Sort(arr1);  // log(N) sort
            Array.Sort(arr2);  // log(M) sort
            a = new string(arr1);  // N
            b = new string(arr2);  // M
            return (a == b);  // N + M*/

            // Faster implementation would be to count number of each character
        }
    }


    public class StringBuilderScratch
    {
        private char[] _characters;
        private int _lastIndex = 0;

        public StringBuilderScratch()
        {
            _characters = new char[10];
        }

        public StringBuilderScratch(string word)
        {
            _characters = new char[word.Length * 2];
            this.Append(word);
        }

        public void Append(string word)
        {
            // Double array size if needed
            if (word.Length + _lastIndex > _characters.Length)
            {
                char[] newArr = new char[_characters.Length * 2];
                for (int i = 0; i < _characters.Length; i++)
                {
                    newArr[i] = _characters[i];
                }
                _characters = newArr;
            }
            // Append word
            foreach (char c in word)
            {
                _characters[_lastIndex++] = c;
            }
        }

        public override string ToString()
        {
            if (_characters == null) return "";
            return _characters.ToString();
        }

    }
}
