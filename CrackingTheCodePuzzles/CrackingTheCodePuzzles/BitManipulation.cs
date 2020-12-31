using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodePuzzles
{
    public class BitManipulation
    {

        public static int PrintBinary(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                int bit = 0;

                bit = (number % 2) + 10 * PrintBinary(number / 2);
                Console.Write(bit);

                return 0;
            }
        }

        /// <summary>
        /// 5.1 Insertion: Insert binary of m into n between bits i and j
        /// </summary>
        public static int Insertion_Test(int n, int m, int i, int j)
        {
            int leftClearMask = ~0;
            int rightClearMask = ~((1 << (j + 1)) - 1);
            int insertMask = (m << i);
            return (n & (leftClearMask | rightClearMask)) | insertMask;
        }

        /*public static BinaryToString(double num)
        {

        }*/

    }
}
