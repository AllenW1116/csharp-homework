using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[99];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 2;
            }
            for (int j = 2; j <= 10; j++)
            {
                for (int k = 2; k <= 100; k++)
                {
                    if (k % j == 0)
                    {
                        array[k - 2] = -1;//把j的倍数从数组中去掉
                    }
                }
            }
            //将数组中的非负元素输出即可
            Console.Write("100以内的素数有：");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) { Console.Write(array[i] + " "); }
            }

        }
    }
}

