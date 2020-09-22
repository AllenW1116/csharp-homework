using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2_4_Clock
{
    class Program
    {
        public static void _alarm()
        {
            Console.WriteLine("叮叮叮叮叮叮~");
        }

        public static void _tick(int time)
        {
            Thread.Sleep(time);
        }
        //函数写在外面加强封闭性


        static void Main(string[] args)
        {
            var MyClock = new Clock();
            Console.WriteLine("给闹钟上个时间吧！以毫秒为单位哦");
            int time = Int32.Parse(Console.ReadLine());
            MyClock.Alarm += _alarm;
            MyClock.Tick += _tick;
            MyClock.Work(time);

        }
    }
}
