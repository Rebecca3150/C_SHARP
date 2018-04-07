using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20153150_李慧_sy1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入整数数组的大小：");
            int n = int.Parse(Console.ReadLine());
            int b = 0;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("输入第{0}位：", i + 1);
                b = int.Parse(Console.ReadLine());
                a[i] = b;
            }

            int sj = 0;
            int sl = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {//偶数
                    sl += a[i];
                }
                else
                {
                    sj += a[i];
                }
            }
            Console.WriteLine("数组中奇数之和：{0}  偶数之和：{1}", sj, sl);


        }
    }
}
