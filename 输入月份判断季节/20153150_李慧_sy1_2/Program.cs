using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20153150_李慧_sy1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入月份（仅限整数数字）：");
            int m = int.Parse(Console.ReadLine());
            if (m <= 0 || m > 12)
            {
                Console.WriteLine("输入错误！");
            }
            else
            {//输入正确
                if (m <= 3)
                {
                    Console.WriteLine("春季！");
                }
                else if (m <= 6)
                {
                    Console.WriteLine("夏季！");
                }
                else if (m <= 9)
                {
                    Console.WriteLine("秋季！");
                }
                else
                {
                    Console.WriteLine("冬季！");
                }

            }
        }
    }
}
