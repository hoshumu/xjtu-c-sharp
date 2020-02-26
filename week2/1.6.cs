// 输入表示时间的整数，单位是秒。输出*天*小时*分*秒。如果时间单位前的数值是0，则不输出该时间单位的数值。

// 样例
// 3610
// 1小时10秒

using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            System.DateTime dateTime = new System.DateTime();
            dateTime = dateTime.AddSeconds(input);
            var day = dateTime.Day;
            var hour = dateTime.Hour;
            var min = dateTime.Minute;
            var sec = dateTime.Second;
            if (day > 1)
                Console.Write("{0}天", day - 1);
            if (hour > 0)
                Console.Write("{0}小时", hour);
            if (min > 0)
                Console.Write("{0}分", min);
            if (sec > 0)
                Console.Write("{0}秒", sec);
        }
    }
}
