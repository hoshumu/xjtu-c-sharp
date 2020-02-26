// 从键盘输入若干数据，整型，在一行内输入，空格分隔。输出最大的一个数以及个数（数据可能重复，所以可能有多个最大的数）

// 样例
// 3 5 -9 0 12 7 9 12 -8 7
// 12 2

using System;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x.Trim())).ToArray();
            Array.Sort(input);
            int i = input.Length - 1;
            for(; ; i--)
            {
                if(input[i] != input[input.Length - 1])
                {
                    break;
                }
            }
            Console.WriteLine("{0} {1}", input[input.Length - 1], input.Length - 1 - i) ;
        }
    }
}
