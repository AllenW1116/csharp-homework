using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shapes
{
    public class Shape
    {
        public double area { get; set; }
        public string name { get; set; }
       
    }  //定义父类，所以图形都有名字和面积

    interface _getarea
    {
        double getarea();
    }  //定义接口，使不同的图形实现计算面积的功能

    interface _existable
    {
        bool _exist();
    }//定义接口，使不同的图形实现判断合法的功能

    public class Rectangle : Shape,_getarea,_existable
    {
        public double a { get; set; }
        public double b { get; set; }

        public Rectangle(string s, double a, double b)
        {
            name = s;
            this.a = a;
            this.b = b;
            area = a * b;
        }

        public double getarea()
        {
            return a * b;
        }

        public bool _exist()
        {
            if (a > 0 && b > 0) return true;
            else return false;
        }
    }

    public class Triangle : Shape,_getarea,_existable
    {
        public double a { get; set; }
        public double b { get; set; }

        public double c { get; set; }

        public Triangle(string s, double a, double b,double c)
        {
            name = s;
            this.a = a;
            this.b = b;
            this.c = c;
            double p = (a + b + c) / 2.0;
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double getarea()
        {
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool _exist()
        {
            if (a > 0 && b > 0 && c > 0 && (a + b) > c && (a + c) > b && (b + c) > a) return true;
            else return false;
        }
    }

    


    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
