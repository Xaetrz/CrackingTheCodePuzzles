using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodePuzzles.Implementation
{
    public class StringBuilder
    {
        private char[] _characters;
        private int _length = 0;

        public StringBuilder()
        {
            _characters = new char[10];
        }

        public StringBuilder(string word)
        {
            _characters = new char[word.Length * 2];
            this.Append(word);
        }

        public void Append(string word)
        {
            // Double array size if needed
            if (word.Length + _length > _characters.Length)
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
                _characters[_length++] = c;
            }
        }

        public override string ToString()
        {
            if (_characters == null) return "";
            return new string(_characters, 0, _length);
        }

    }
}
