using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Text.RegularExpressions;

namespace _3_1_Order_Manager
{
    public enum DeleteType
    {
        ById,
        ByCustomer,
    }
    public enum FindType
    {
        ById,
        ByCustomer,
        ByPrice
    }

    class Function
    {

        public void Fdeleteorder(OrderService os) //删除订单
        {
            Console.WriteLine("你想按照哪种方式删除订单？请输入ById或者ByCustomer：");//其实这里应该搞一个按钮，此处简化了
            string str = Console.ReadLine();
            DeleteType d = (DeleteType)Enum.Parse(typeof(DeleteType), str); //其实此处应该有一个try catch 此处简化了

            if (d == DeleteType.ById)
            {
                try
                {
                    Console.WriteLine("你想删除的订单id为？");
                    long id = long.Parse(Console.ReadLine());
                    var orders = os.OrderList.Where(o => o.ID == id);//使用linq语句，由于id是不重复的，所以只会得到一个order对象
                    foreach (var item in orders)
                    {
                        os.OrderList.Remove(item);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("按照ID删除错误：" + ex.Message);

                }

            }
            else if (d == DeleteType.ByCustomer)
            {
                try
                {
                    Console.WriteLine("你想删除的订单的顾客是？");
                    string customer = Console.ReadLine();
                    var orderl = os.OrderList.Where(o => o.Customer == customer);//使用linq语句,得到一个临时列表
                    foreach (var item in orderl)
                    {
                        os.OrderList.Remove(item);
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("按照顾客" +
                        "删除错误：" + ex.Message);
                }

            }
            else Console.WriteLine("删除订单错误！");
        }

        public void Ffindorder(OrderService os)  //查找订单
        {
            Console.WriteLine("你想按照哪种方式查询订单？请输入ById或者ByCustomer或者ByPrice：");//其实这里应该搞一个按钮，此处简化了
            string str = Console.ReadLine();
            FindType f = (FindType)Enum.Parse(typeof(FindType), str);

            if (f == FindType.ById)
            {
                try
                {
                    Console.WriteLine("你想查找的订单id为？");
                    long id = long.Parse(Console.ReadLine());
                    var orders = os.OrderList.Where(o => o.ID == id);//使用linq语句,由于id是不重复的，所以只会得到一个order对象
                    foreach (var item in orders)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    //Console.WriteLine(((Order)order).ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("按照ID查找错误：" + ex.Message);

                }

            }
            else if (f == FindType.ByCustomer)
            {
                try
                {
                    Console.WriteLine("你想查找的订单的顾客是？");
                    string customer = Console.ReadLine();
                    var orders = os.OrderList.Where(o => o.Customer == customer).OrderBy(o => o.Price);//使用linq语句,得到一个临时列表
                    foreach (var item in orders)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("按照顾客" +
                        "查找错误：" + ex.Message);
                }

            }
            else if(f==FindType.ByPrice)
            {
                
                try
                {
                    Console.WriteLine("你想查找的价格范围下限是？");
                    int low = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("你想查找的价格范围上限是？");
                    int high = Int32.Parse(Console.ReadLine());

                    var orders = os.OrderList.Where(o => o.Price >= low && o.Price <= high).OrderBy(o => o.Price);//使用linq语句,得到一个临时列表
                    foreach (var item in orders)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("按照价格" +
                        "查找错误：" + ex.Message);
                }
            }
            else { Console.WriteLine("查找订单错误！"); }
        }



        public void Falterorder(OrderService os)//修改订单
        {
            Console.WriteLine("你想修改ID为多少的订单？（ID是一个订单的唯一凭证，是不可以修改的哦）：");//其实这里应该搞一个按钮，此处简化了
            long id = long.Parse(Console.ReadLine());
            var orders = os.OrderList.Where(o => o.ID == id);
            foreach (var item in orders)
            {
                Console.WriteLine("你要修改的订单为：");
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("请输入新的顾客名字：");
            string newcustomer = Console.ReadLine();
            Console.WriteLine("请输入新的订单价格：");
            decimal newprice = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("请输入新的商品名字：");
            string newgoodsname = Console.ReadLine();
            foreach (var item in orders)
            {
                item.Customer = newcustomer;
                item.Price = newprice;
                item.GoodsName = newgoodsname;
            }


        }

        public void Fexport(OrderService os)
        {
            try
            {
                XmlSerializer xmler = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream("o.xml", FileMode.Create))
                {
                    xmler.Serialize(fs, os.OrderList);
                }
                Console.WriteLine("序列化成功！");
                Console.WriteLine(File.ReadAllText("o.xml"));
            }
            catch (Exception ex)
            {

                Console.WriteLine("序列化失败："+ex.Message);
            }
            
        }

        public void Finport(OrderService os)
        {
            try
            {
                XmlSerializer xmler = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream("o.xml", FileMode.Open))
                {
                    List<Order> orders = (List<Order>)xmler.Deserialize(fs);

                }
                Console.WriteLine("反序列化成功！");
                
            }
            catch (Exception ex)
            {

                Console.WriteLine("反序列化失败：" + ex.Message);
            }

        }



    }
}
