using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20153150_李慧_sy2_2
{

    interface IShape
    {
        decimal initialize();  //初始化
        decimal getPerimeter(decimal a);    //获取边长
        decimal getArea(decimal a);     //获取面积
    }

    interface IDisplayresult
    {
        void display(decimal a);     //显示计算结果
    }


    class Square : IShape, IDisplayresult   //正方形
    {
       public decimal x;
      public decimal initialize()
        {
            x = 0;
            return x;
        }

     public decimal getPerimeter(decimal x)
        {
            return x * 4;
        }

    public decimal getArea(decimal x)
        {
            return x * x;
        }
    public void display(decimal x)
     {
         decimal C = getPerimeter(x);
         decimal S = getArea(x);
         Console.WriteLine("此正方形的周长和面积分别为：{0}、{1}", C, S);
     }

    }

    class Circle : IShape, IDisplayresult   //圆形
    {
        public decimal r;
     public decimal initialize()
        {
            r = 0;
            return r;
        }
     public decimal getPerimeter(decimal r)
        {
            double ab = (double)r * 3.14 * 2;
            decimal a = Convert.ToDecimal(ab);
            return a;
        }

     public decimal getArea(decimal r)
        {
            double b = (double)r;
            double ab =b*b*3.14;
            decimal a = Convert.ToDecimal(ab);
            return a;
        }
     public void display(decimal r)
     {
         decimal C = getPerimeter(r);
         decimal S = getArea(r);
         Console.WriteLine("此正方形的周长和面积分别为：{0}、{1}", C, S);
     }
    }





    class Program
    {   //输入正方形边长或者圆的半径，计算其周长和面积并输出。
        static void Main(string[] args)
        {
            int x=1;
            while (x == 1)
            {
                Square sq = new Square();
                sq.x = sq.initialize();
                Console.WriteLine("请输入正方形的边长：");
                sq.x = Convert.ToDecimal(Console.ReadLine());
                sq.display(sq.x);


                Circle ci = new Circle();
                ci.r = ci.initialize();
                Console.WriteLine("请输入圆的半径：");
                ci.r = Convert.ToDecimal(Console.ReadLine());
                ci.display(ci.r);

                Console.WriteLine("是否退出：（0退出，1继续）");
                x = Convert.ToInt32(Console.ReadLine());
            }//while
        }
    }
}
