using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//订单展示用list,可以参考课程代码中那个左右传东西的
//addorder时新弹出一个窗口，新弹出的窗口参考课程代码中的groupbox/register
//如何打开新窗口，可以参考multiform

namespace Order_Window
{
    public partial class Form1 : Form
    {
        Order o1 = new Order(001, "apple", "allen", 10);
        Order o2 = new Order(002, "banana", "allen", 8);
        Order o3 = new Order(003, "peanut", "max", 25);
        Order o4 = new Order(004, "grape", "zoe", 30);
        Order o5 = new Order(005, "biscut", "earnest", 6);
        public List<ListViewItem> listViewItems = new List<ListViewItem>();
        
        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timelabel.Text = System.DateTime.Now.ToString();
            
            listViewItems.Add(new ListViewItem());//匿名变量添加一个ListViewItem
            listViewItems.Last().SubItems[0].Text= o1.ID.ToString();
            listViewItems.Last().SubItems.Add(o1.GoodsName);
            listViewItems.Last().SubItems.Add(o1.Customer);
            listViewItems.Last().SubItems.Add(o1.Price.ToString());
            listViewItems.Last().SubItems.Add("");
            listView.Items.Add(listViewItems.Last());

            listViewItems.Add(new ListViewItem());//匿名变量添加一个ListViewItem
            listViewItems.Last().SubItems[0].Text = o2.ID.ToString();
            listViewItems.Last().SubItems.Add(o2.GoodsName);
            listViewItems.Last().SubItems.Add(o2.Customer);
            listViewItems.Last().SubItems.Add(o2.Price.ToString());
            listViewItems.Last().SubItems.Add("");
            listView.Items.Add(listViewItems.Last());

            listViewItems.Add(new ListViewItem());//匿名变量添加一个ListViewItem
            listViewItems.Last().SubItems[0].Text = o3.ID.ToString();
            listViewItems.Last().SubItems.Add(o3.GoodsName);
            listViewItems.Last().SubItems.Add(o3.Customer);
            listViewItems.Last().SubItems.Add(o3.Price.ToString());
            listViewItems.Last().SubItems.Add("");
            listView.Items.Add(listViewItems.Last());

            listViewItems.Add(new ListViewItem());//匿名变量添加一个ListViewItem
            listViewItems.Last().SubItems[0].Text = o4.ID.ToString();
            listViewItems.Last().SubItems.Add(o4.GoodsName);
            listViewItems.Last().SubItems.Add(o4.Customer);
            listViewItems.Last().SubItems.Add(o4.Price.ToString());
            listViewItems.Last().SubItems.Add("");
            listView.Items.Add(listViewItems.Last());

            listViewItems.Add(new ListViewItem());//匿名变量添加一个ListViewItem
            listViewItems.Last().SubItems[0].Text = o5.ID.ToString();
            listViewItems.Last().SubItems.Add(o5.GoodsName);
            listViewItems.Last().SubItems.Add(o5.Customer);
            listViewItems.Last().SubItems.Add(o5.Price.ToString());
            listViewItems.Last().SubItems.Add("");
            listView.Items.Add(listViewItems.Last());





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Timelabel_Click(object sender, EventArgs e)
        {

        }

        private void AddbtnClick(object sender, EventArgs e)
        {
            Boolean flag = true;
            foreach (var item in listViewItems)
            {
                if (item.SubItems[0].Text == IDtextBox.Text) { flag = false; break; }
            }

            if (IDtextBox.Text == "" || GoodstextBox.Text == "" || CustomertextBox.Text == "" || PricetextBox.Text == "")
            {
                MessageBox.Show("请输入完整的订单信息！");
            }
            else if(flag==false)
            {
                MessageBox.Show("订单ID不可以重复！");
            }
            else
            {
                listViewItems.Add(new ListViewItem());//匿名变量添加一个ListViewItem
                listViewItems.Last().SubItems[0].Text = IDtextBox.Text;
                listViewItems.Last().SubItems.Add(GoodstextBox.Text);
                listViewItems.Last().SubItems.Add(CustomertextBox.Text);
                listViewItems.Last().SubItems.Add(PricetextBox.Text);
                listViewItems.Last().SubItems.Add("");
                listView.Items.Add(listViewItems.Last());
            }

            

        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
