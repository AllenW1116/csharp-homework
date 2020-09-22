using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace _2_2_shape_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape> ();
            Random rand = new Random(5);
            double count = 0;
            for (int i = 0; i < 10; i++)
            {
                list.Add(Factory.GenerateShape((Factory.ShapeID)rand.Next(2)));
                count += list[i].area;
            }
            Console.Write("这十个图形的面积之和是" + count);
        }
    }
}
