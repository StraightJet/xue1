using System;
using System.Diagnostics;
using System.Text;

namespace zifuchuan
{
    class Program
    {
        static void Main(string[] args)
        {
            //高效大量拼接字符串
            StringBuilder sb = new StringBuilder();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i);

            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();

            //字符串长度
            string name = Console.ReadLine();
            Console.WriteLine("{0}", name.Length);

            //大小写转换  字符串比较
            string l1 = "c";
            string l2 = "C";
            
            //转换大写
            l1.ToUpper();
            l2.ToUpper();
            
            //转换小写
            l1.ToLower();
            l2.ToLower();
            if (l1 == l2)
            {
                Console.WriteLine("比较字符串相同");

            }

            if (l1.Equals(l2,StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("比较字符串相同");
            }

            string s = "a b d   ff _ + =";
            //分割字符串
            char[] chs = { ' ', '_', '+', '=' };
            string[] str = s.Split(chs, StringSplitOptions.RemoveEmptyEntries);

        }
    }
}
