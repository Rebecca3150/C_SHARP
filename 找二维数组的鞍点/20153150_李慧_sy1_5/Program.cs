using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20153150_李慧_sy1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入二维数组的行数a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("输入二维数组列数b:");
            int b = int.Parse(Console.ReadLine());

            int[,] arr = new int[a, b];

            Console.WriteLine("请输入各行各列元素：");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("第{0}行开始输入......", i + 1);
                for (int j = 0; j < b; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int flag = 0;//1是有鞍点存在，0是无鞍点存在
            //找出鞍点
            String A = "";
            int m = 0;
            for (int i = 0; i < a; i++)
            {
                int max = arr[i, 0];   //初始每一行的第一个为最大
                int j = 0;
                for (j = 0; j < b; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        m = j;  //标记列
                    }
                }

                int f = 0;
                //找出此行的最大值，然后再判断是否为此列的最小值

                for (int p = 0; p < a; p++)
                {
                    if (arr[p, m] < max)
                    {
                        f = 1;
                    }
                }
                if (f != 1)
                {//此列有鞍点
                    A += max + "—（" + i + "," + m + "）   ";
                    flag = 1;
                }
            }



            if (flag == 1)
            {
                Console.WriteLine("此二维数组存在鞍点，且鞍点有：{0}", A);
            }
            else
            {
                Console.WriteLine("此二维数组不存在鞍点");
            }
        }
    }
}
