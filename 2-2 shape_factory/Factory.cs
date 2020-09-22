using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Shapes;

namespace _2_2_shape_factory
{
    class Factory
    {
        public enum ShapeID
        {
            Triangle = 0,
            Rectangle = 1,           
        }


        public static Shape GenerateShape(ShapeID t)
        {
            Random rand = new Random();
            
            switch (t)
            {
                case ShapeID.Triangle:
                    {
                        string ID = rand.Next().ToString();
                        Triangle triangle = new Triangle(ID, rand.Next(15), rand.Next(15), rand.Next(15) ) ;
                        if (triangle._exist()) { Console.WriteLine("我是一个随机生成的三角形！我的面积是：" +triangle.area + " !我的随机编号是:" + ID + "!"); return triangle; }
                        else
                        {
                            Console.WriteLine("随即生成的三条边居然无法构成一个三角形！可恶，只好生成一个边长为2的默认三角形啦qaq");
                            return new Triangle(ID, 2, 2, 2);
                        }
                    }
                case ShapeID.Rectangle:
                    {
                        string ID = rand.Next().ToString();
                        Rectangle rectangle = new Rectangle(ID, rand.Next(15), rand.Next(15));
                        Console.WriteLine("我是一个随机生成的矩形！我的面积是：" + rectangle.area + " !我的随机编号是:" + ID + "!");
                        return rectangle; 
                    }    
                   

            }
            throw new InvalidEnumArgumentException();
        }
    }
}
