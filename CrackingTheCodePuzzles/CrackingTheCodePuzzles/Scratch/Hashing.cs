using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodePuzzles.Scratch
{
    public class HashableObject
    {

    }

    public class Hashing
    {
        private static Dictionary<HashableObject, int> dict; // Warning: Playing around with bad ideas (Singleton)

        public static bool CreateHashObject()
        {
            if (Hashing.dict == null)
            {
                dict = new Dictionary<HashableObject, int>();
                return true;
            }
            return false;
        }


    }
}
