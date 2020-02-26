// 对于一个4位整数（从0000-9999）按如下方式加密：将每位数字加7后对10取余，用余数替换原来的数字；然后将1,3位数字互换；2,4位数字互换。编写程序，首先让用户选择是加密还是解密，如选择加密，则输入一个4位数，显示加密后的结果，反之，输入密文，显示加密前的4位数。统一约定：当用户输入数字0表示加密，1表示解密。

// 加密样例
// 0
// 5493
// 6021

// 解密样例
// 1
// 6021
// 5493

using System;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var lock_input = int.Parse(Console.ReadLine());
            int[] input= Console.ReadLine().ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();
            if(lock_input == 0)
            {
                for(int i = 0; i < input.Length; i++)
                {
                    input[i] = (input[i] + 7) % 10 ;
                }
                Console.WriteLine("{0}{1}{2}{3}", input[2], input[3], input[0], input[1]);
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    input[i] = input[i]>=7 ? input[i]-7: (input[i] + 10) - 7;
                }
                Console.WriteLine("{0}{1}{2}{3}", input[2], input[3], input[0], input[1]);
            }
        }
    }
}
