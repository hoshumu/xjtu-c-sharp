// 在一行里输入6个整数，输出最大的一个整数

// 如
// 输入：1 2 3 4 5 6
// 输出：6

using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inp = Console.ReadLine().Split(' ');
          	 int[] input;
            input=Array.ConvertAll(inp,int.Parse);
            Array.Sort(input);
            Console.WriteLine("{0}", input[input.Length - 1]);
        }
    }
}
