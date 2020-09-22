using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_Clock
{
    class Clock
    {
        public int time { get; set; }

        // public event Action<int> _Tick = null;
        public event Action Alarm = null;



        public delegate void _Tick(int time);
        public event _Tick Tick;



       
        public void Work(int time)
        {
            Tick(time);
            Alarm();
        }


    }
}
