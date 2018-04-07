using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20153150_李慧_sy1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入三角形的边长：");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                double C = a + b + c;
                double C2 = C / 2;
                double S = Math.Sqrt(C2 * (C2 - a) * (C2 - b) * (C2 - c));
                Console.WriteLine("三角形的周长是：{0}，面积是：{1}", C, S);
            }
            else
            {
                Console.WriteLine("三边无法组成三角形！");
            }
            Console.WriteLine("请输入长方形的边长：");
            float p = float.Parse(Console.ReadLine());
            float q = float.Parse(Console.ReadLine());
            double CC = (p + q) * 2;
            double SS = p * q;


            Console.WriteLine("长方形的周长是：{0}，面积是：{1}", CC, SS);

        }
    }
}
