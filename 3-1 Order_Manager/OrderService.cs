using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;



namespace _3_1_Order_Manager
{
    class OrderService
    {
        public List<Order> OrderList = new List<Order>();

        //定义类内函数，对OrderList进行基本地增删改查
        public void AddOrder(ref Order order)
        {
            try
            {
                bool repeat = false;
                foreach (var item in OrderList)
                {
                    if (item == order) repeat = true;
                }
                if (repeat == false)
                {
                    OrderList.Add(order);
                }
                else Console.WriteLine("重复订单！");


            }
            catch (Exception ex)
            {
                Console.WriteLine("添加错误：" + ex.Message);
            }
        }

        public void show()
        {
            var qurry = this.OrderList.OrderBy(o => o.ID);  //linq语句，默认按订单号排列
            foreach (var item in qurry)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void QuitOrder()
        {
            try
            {
                OrderList.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine("清空订单列表错误：" + ex.Message);
            }

        }


        //定义事件，将OrderService封装起来
        public event Action<OrderService> _DeleteOrder;
        public void DeleteOrder(OrderService os)
        {
            _DeleteOrder(os);
        }

        public event Action<OrderService> _FindOrder;
        public void FindOrder(OrderService os)
        {
            _FindOrder(os);
        }

        public event Action<OrderService> _AlterOrder;
        public void AlterOrder(OrderService os)
        {
            _AlterOrder(os);
        }

        public event Action<OrderService> _Export;
        public void Export(OrderService os)
        {
            _Export(os);
        }

        public event Action<OrderService> _Inport;
        public void Inport(OrderService os)
        {
            _Inport(os);
        }


    }
        
        
        
}

