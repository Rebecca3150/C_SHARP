using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20153150_李慧_sy2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            People peo = new People();
            peo.Work();
           Student stu = new Student();
           stu.Work();
           Employer em = new Employer();
           em.Work();
           
        }
    }


    class People
    {
        protected String username=null;
        protected int age=0;

        public void Work() {
            Console.WriteLine("生成父类People对象 . . . ");
        }
    }

    class Student : People
    {
        protected String school=null;
        public void Work()
        {
            Console.WriteLine("生成Student类对象 . . . ");
        }
    }

    class Employer : People
    {
        protected String unit=null;
        public void Work(){
        Console.WriteLine("生成Employer类对象 . . . ");
    }
    }
}
