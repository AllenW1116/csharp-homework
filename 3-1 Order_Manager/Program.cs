using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户、订单金额等进行查询）功能。
///提示：主要的类有Order（订单）、OrderDetails（订单明细），OrderService（订单服务），订单数据可以保存在OrderService中一个List中。在Program里面可以调用OrderService的方法完成各种订单操作。
///要求：
///（1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。
///（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
///（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
///（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
///（5）OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。
///（6）在OrderService中添加Export方法，可以将所有的订单序列化为XML文件；添加Import方法可以从XML文件中载入订单。
/// </summary>
/// 

namespace _3_1_Order_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Order o1 = new Order(001, "apple", "allen", 10);
            Order o2 = new Order(002, "banana", "allen", 8);
            Order o3 = new Order(003, "peanut", "max", 25);
            Order o4 = new Order(004, "grape", "zoe", 30);
            Order o5 = new Order(005, "biscut", "earnest", 6);
            OrderService TestOrderManager = new OrderService();
            Function testfunc = new Function();
            
            TestOrderManager.AddOrder(ref o1);
            TestOrderManager.AddOrder(ref o2);
            TestOrderManager.AddOrder(ref o3);
            TestOrderManager.AddOrder(ref o4);
            TestOrderManager.AddOrder(ref o5);
            TestOrderManager._DeleteOrder += testfunc.Fdeleteorder;
            Console.WriteLine("初始订单列表：");
            TestOrderManager.show();
            TestOrderManager.DeleteOrder(TestOrderManager);
            Console.WriteLine("删除后订单列表：");
            TestOrderManager.show();
            Console.WriteLine("=======================================");
            TestOrderManager._FindOrder += testfunc.Ffindorder;
            TestOrderManager.FindOrder(TestOrderManager);
            Console.WriteLine("=======================================");
            TestOrderManager._Export += testfunc.Fexport;
            TestOrderManager.Export(TestOrderManager);
        }
    }
}
