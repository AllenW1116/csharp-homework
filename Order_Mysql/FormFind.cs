using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_Window
{
    public partial class FormFind : Form
    {
        //public List<Order> orderlist = new List<Order>();


        public FormFind()
        {
            InitializeComponent();
           
        }
        //public FormFind(List<Order> fatherorderlist) //重载带参构造函数
        //{
        //    this.orderlist = fatherorderlist;
        //    InitializeComponent();
        //}

        private void button1_Click(object sender, EventArgs e)//查找按钮
        {
            using (var context = new DContext())
            {
                int i = 11;


                if (ByPriceradioButton.Checked)//按照价格查找
                {
                    decimal lprice = decimal.Parse(LowPricetextBox.Text);
                    decimal hprice = decimal.Parse(HighPricetextBox.Text);


                    var orders = context.Orders.Where(o => o.Price >= lprice && o.Price <= hprice).OrderBy(o => o.Price);//使用linq语句,得到一个临时列表
                    foreach (var order in orders)
                    {
                        string[] subitems = { order.ID.ToString(), order.Customer, order.GoodsName, order.Price.ToString(), "" };

                        FindResultlistView.Items.Add(new ListViewItem(subitems));
                    }

                }
                else if (ByCustomerradioButton.Checked)//按顾客名查找
                {
                    var orders = context.Orders.Where(o => o.Customer == CustomertextBox.Text).OrderBy(o => o.Price);//使用linq语句,得到一个临时列表
                    foreach (var order in orders)
                    {
                        string[] subitems = { order.ID.ToString(), order.Customer, order.GoodsName, order.Price.ToString(), "" };

                        FindResultlistView.Items.Add(new ListViewItem(subitems));
                    }
                }
                else if (ByGoodsradioButton.Checked)//按商品查找
                {
                    var orders = context.Orders.Where(o => o.GoodsName == GoodstextBox.Text).OrderBy(o => o.Price);//使用linq语句,得到一个临时列表
                    foreach (var order in orders)
                    {
                        string[] subitems = { order.ID.ToString(), order.Customer, order.GoodsName, order.Price.ToString(), "" };

                        FindResultlistView.Items.Add(new ListViewItem(subitems));
                    }
                }
                else
                {
                    MessageBox.Show("请选择一种查询方式！");
                }
            }
        }
    }
}
