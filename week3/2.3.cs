// 求a+aa+aaa+aaaa+...+aa...a(第n项，n个a)，其中a是1～9的整数。例如，a=1,n=3时，式子为1+11+111；当a=6,n=5时，式子为5+55+555+5555+55555。

// 样例（第一行为输入：两个数，第一个数a，第二个数为n;第二行为输出结果）：
// 1 5
// 12345

using System;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x.Trim())).ToArray();

            int num = 0;
            string s = "";
            for(int i = 0;i < input[1]; i++)
            {
                s += input[0];
                num += int.Parse(s);
            }

            Console.WriteLine(num);
        }
    }
}
