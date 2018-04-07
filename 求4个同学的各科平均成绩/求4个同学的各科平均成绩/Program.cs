using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 求4个同学的各科平均成绩
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] score = new int[4, 3];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("输入第{0}个同学的成绩：(大学英语，C#程序设计，网页设计)",i+1);
                for (int j = 0; j < 3; j++)
                {
                    score[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int j = 0; j < 3; j++)
            {
                double sum=0.00;
               double ave;
                    for(int i=0;i<4;i++){
                      sum+=score[i,j];  
                    }
                    ave = sum / 4;
                if (j == 0)
                {
                    Console.WriteLine("大学英语的平均分：{0}",ave);
                }
                if (j == 1)
                {
                    Console.WriteLine("C#程序设计的平均分：{0}", ave);
                }
                if (j == 2)
                {
                    Console.WriteLine("网页设计的平均分：{0}", ave);
                }
            }
        }
    }
}
