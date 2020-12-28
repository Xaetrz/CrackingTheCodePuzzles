using System;
using System.Text;

namespace CrackingTheCodePuzzles
{
    class MessingWithStringBuilder
    {
        public static void StringBuilderTest(string[] args)
        {
            char[] charArr = { 'H', 'E', 'L', 'L', 'O' };
            StringBuilder helloWorld = new StringBuilder();
            helloWorld.Append(charArr);
            helloWorld.AppendLine();
            helloWorld.Append("stuff");
            Console.WriteLine(helloWorld);
        }
    }
}
