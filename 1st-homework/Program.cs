using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入一个整数：");
            string s = Console.ReadLine();
            int n = int.Parse(s);
            findFactors(n);

        }

        public static void findFactors(int n)
        {
            string Expression = n + "=";
            // 实际上就是求他的质因数
            for (int i = 2; i <= n / 2; i++)
            {
                // 循环求i是不是它的质因数，直到i不是它的因数为止(i = 4能被整除的不可能出现，因为当i=2时已经被全求出来了)
                // 也就是说number % i==0的情况，只有当i为质数时才有可能出现。
                while (true)
                {
                    // 如果能整除，就求number/i的质因数
                    if (n % i == 0)
                    {
                        Expression += i;
                        n /= i;
                        if (n != 1)
                        {
                            Expression += "*";
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (n != 1)
            {
                Expression += n;
            }
            Console.WriteLine(Expression);
        }
    }
}
