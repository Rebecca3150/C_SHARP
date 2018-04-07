using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20153150_李慧_sy1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 2;
            int x = 1;
            while (x == 1)
            {
                if ((sum % 2 == 1) && (sum % 3 == 1) && (sum % 4 == 1))
                {
                    break;
                }
                else
                {
                    sum += 1;
                }

            }
            Console.WriteLine("这盒鸡蛋至少有{0}个！", sum);
        }
    }
}
