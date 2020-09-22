using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2

{ 

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一系列整数，以空格隔开");
            string str = Console.ReadLine();
            string[] StrArray = str.Split(' ');
            List<int> intList = new List<int>();
            for (int i = 0; i < StrArray.Length; i++)
            {
                int num = int.Parse(StrArray[i]);
                intList.Add(num);
            }
            GetAve(intList);
            GetCount(intList);
            GetMax(intList);
            GetMin(intList);

        }

        public static void GetAve(List<int> list)
        {
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                count += list[i];
            }
            Console.WriteLine("该数组的平均值为：" + count / list.Count);
        }

        public static void GetMax(List<int> list)
        {
            int max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > max) { max = list[i]; }
            }
            Console.WriteLine("该数组的最大值为：" + max);
        }

        public static void GetMin(List<int> list)
        {
            int min = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < min) { min = list[i]; }
            }
            Console.WriteLine("该数组的最小值为：" + min);
        }

        public static void GetCount(List<int> list)
        {
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                count += list[i];
            }
            Console.WriteLine("该数组的平均值为：" + count);

        }
    }
}
