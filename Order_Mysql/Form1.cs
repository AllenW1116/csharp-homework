using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


//订单展示用list,可以参考课程代码中那个左右传东西的
//addorder时新弹出一个窗口，新弹出的窗口参考课程代码中的groupbox/register
//如何打开新窗口，可以参考multiform

namespace Order_Window
{


    




    public partial class Form1 : Form
    {


        

        public List<ListViewItem> listViewItems = new List<ListViewItem>();

        public void savetomysql(Order order)
        {
            using (var context = new DContext())
            {
                context.Orders.Add(order);
                context.SaveChanges();
                var accountUsers = context.Orders.ToList();
            }
        }



        public void deletefrommysql(int id)
        {
            using (var context = new DContext())
            {
                var order1 = context.Orders.FirstOrDefault(p => p.ID==id);
                if (order1 != null)
                {
                    context.Orders.Remove(order1);
                    context.SaveChanges();
                }
            }
        }  





        public Form1()   //初始化数据
        {

            Order o1 = new Order(001, "peanut", "max", 25);
            Order o2 = new Order(002, "banana", "allen", 8); 
            Order o3 = new Order(003, "grape", "zoe", 30); 


            InitializeComponent();
            listViewItems.Add(new ListViewItem());//匿名变量添加一个ListViewItem
            listViewItems.Last().SubItems[0].Text = o1.ID.ToString();
            listViewItems.Last().SubItems.Add(o1.GoodsName);
            listViewItems.Last().SubItems.Add(o1.Customer);
            listViewItems.Last().SubItems.Add(o1.Price.ToString());
            listViewItems.Last().SubItems.Add("");
            listView.Items.Add(listViewItems.Last());
            
            savetomysql(o1);
            
            listViewItems.Add(new ListViewItem());//匿名变量添加一个ListViewItem
            listViewItems.Last().SubItems[0].Text = o2.ID.ToString();
            listViewItems.Last().SubItems.Add(o2.GoodsName);
            listViewItems.Last().SubItems.Add(o2.Customer);
            listViewItems.Last().SubItems.Add(o2.Price.ToString());
            listViewItems.Last().SubItems.Add("");
            listView.Items.Add(listViewItems.Last());
            
            savetomysql(o2);

            listViewItems.Add(new ListViewItem());//匿名变量添加一个ListViewItem
            listViewItems.Last().SubItems[0].Text = o3.ID.ToString();
            listViewItems.Last().SubItems.Add(o3.GoodsName);
            listViewItems.Last().SubItems.Add(o3.Customer);
            listViewItems.Last().SubItems.Add(o3.Price.ToString());
            listViewItems.Last().SubItems.Add("");
            listView.Items.Add(listViewItems.Last());
            
            savetomysql(o3);
        }

        private void Form1_Load(object sender, EventArgs e)//初始化界面
        {

            Timelabel.Text = System.DateTime.Now.ToString();
            timer1.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Timelabel_Click(object sender, EventArgs e)
        {

        }

        private void AddbtnClick(object sender, EventArgs e)//点击添加按钮
        {
            Boolean flag = true;
            //foreach (var item in orderlist)
            //{
            //    if (item.ID == Int32.Parse(IDtextBox.Text)) { flag = false; break; }
            //}
            //using (var context = new DContext())
            //{
            //    int id= Int32.Parse(IDtextBox.Text);
            //    var order1 = context.Orders.FirstOrDefault(p => p.ID == id);
            //    if (order1 != null)
            //    {
            //        flag = false;
            //    }
            //}


            if (IDtextBox.Text == "" || GoodstextBox.Text == "" || CustomertextBox.Text == "" || PricetextBox.Text == "")
            {
                MessageBox.Show("请输入完整的订单信息！");
            }
            else if(flag==false)
            {
                MessageBox.Show("订单ID不可以重复！");
            }
            else  //加入订单
            {

                //存入数据库中
                savetomysql(new Order(Int32.Parse(IDtextBox.Text), GoodstextBox.Text, CustomertextBox.Text, Decimal.Parse(PricetextBox.Text)));
                listViewItems.Add(new ListViewItem());//匿名变量添加一个ListViewItem
                listViewItems.Last().SubItems[0].Text = IDtextBox.Text;
                listViewItems.Last().SubItems.Add(GoodstextBox.Text);
                listViewItems.Last().SubItems.Add(CustomertextBox.Text);
                listViewItems.Last().SubItems.Add(PricetextBox.Text);
                listViewItems.Last().SubItems.Add("");
                listView.Items.Add(listViewItems.Last());

                

            }

            

        }

        private void Deletebutton_Click(object sender, EventArgs e)//点击删除按钮
        {
            try
            {
                int id = Int32.Parse(listView.FocusedItem.Text);

                for (int i = listView.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem item = listView.SelectedItems[i];
                    listView.Items.Remove(item);

                }
                deletefrommysql(id);
                //Order orders  = orderlist.FirstOrDefault<Order>(o => o.ID == id) ;//使用linq语句，由于id是不重复的，所以只会得到一个order对象
                //从数据库中查找
                using (var context = new DContext())
                {
                    var theorder = context.Orders.SingleOrDefault(b => b.ID == id);
                }

                deletefrommysql(id);
                
                
                //deletefrommysql(orders);
                //new Order(listView.SelectedItems[0], GoodstextBox.Text, CustomertextBox.Text, Decimal.Parse(PricetextBox.Text))



            }
            catch (Exception ex)
            {
                if (ex.Message!="集合已修改；可能无法执行枚举操作。") {
                    MessageBox.Show(ex.Message);
                }
            }
            
            
        }

        private void ByPriceUpradioButton_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void as_decslist(object sender, ColumnClickEventArgs e)
        {
            System.Windows.Forms.ListView lv = sender as System.Windows.Forms.ListView;
            if ((lv.ListViewItemSorter as ListViewColumnSorter) == null)
                lv.ListViewItemSorter = new ListViewColumnSorter();
            ListViewColumnSorter temp = (lv.ListViewItemSorter as ListViewColumnSorter);
            temp.StringNumOrder = true;
            if (e.Column == (lv.ListViewItemSorter as ListViewColumnSorter).SortColumn)
            {
                if ((lv.ListViewItemSorter as ListViewColumnSorter).OrderType == SortOrder.Ascending)
                {
                    (lv.ListViewItemSorter as ListViewColumnSorter).OrderType = SortOrder.Descending;
                }
                else
                {
                    (lv.ListViewItemSorter as ListViewColumnSorter).OrderType = SortOrder.Ascending;
                }
            }
            else
            {
                (lv.ListViewItemSorter as ListViewColumnSorter).SortColumn = e.Column;
                (lv.ListViewItemSorter as ListViewColumnSorter).OrderType = SortOrder.Ascending;
            }
            ((ListView)sender).Sort();
        } //点击列表头可排序

        private void Alterbutton_Click(object sender, EventArgs e)  //点击修改按钮
        {
            try
            {

                listView.Items[Int32.Parse(IDtextBox.Text) - 1].SubItems[1].Text = GoodstextBox.Text;
                listView.Items[Int32.Parse(IDtextBox.Text) - 1].SubItems[3].Text = CustomertextBox.Text;
                listView.Items[Int32.Parse(IDtextBox.Text)-1].SubItems[3].Text = PricetextBox.Text;

                //var orders = orderlist.Where(o => o.ID == Int32.Parse(IDtextBox.Text));//使用linq语句,由于id是不重复的，所以只会得到一个order对象
                //foreach (var item in orders)
                //{
                //    item.Customer= CustomertextBox.Text;
                //    item.GoodsName= GoodstextBox.Text;
                //    item.Price = decimal.Parse(PricetextBox.Text);
                //}
                using (var context = new DContext())
                {
                    int id = Int32.Parse(IDtextBox.Text);
                    var theorder = context.Orders.SingleOrDefault(b => b.ID == id);
                    theorder.Customer = CustomertextBox.Text;
                    theorder.GoodsName= GoodstextBox.Text;
                    theorder.Price = decimal.Parse(PricetextBox.Text);
                    context.SaveChanges();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Findbutton_Click(object sender, EventArgs e)
        {
            //new FormFind().ShowDialog();
            FormFind formFind = new FormFind();
            formFind.ShowDialog();
            
        }

        private void Exportbutton_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer xmler = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream(@"D:\o.xml", FileMode.Create))
                {
                    //查找数据库内的全部对象
                    using (var context = new DContext())
                    {
                        var query = context.Orders.Include("Orders"); //从orders数据集里面找



                        xmler.Serialize(fs, query);
                    }
                }
                //Console.WriteLine("序列化成功！");
                //Console.WriteLine(File.ReadAllText("o.xml"));
                MessageBox.Show("导出成功！文件在D盘根目录下");
            }
            catch (Exception ex)
            {

                MessageBox.Show("导出失败：" + ex.Message);
            }
        }

        private void Inputbutton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("请将要导入的xml文件放在D盘根目录下并命名为o.xml");
                XmlSerializer xmler = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream(@"D:\o.xml", FileMode.Open))
                {
                    DbQuery<Order> orders1 = (DbQuery<Order>)xmler.Deserialize(fs);
                    //orderlist = orders1;
                    MessageBox.Show("导入成功！");
                    listView.Items.Clear();
                    //将导入的订单展示在listview上
                    var orders = orders1.OrderBy(o => o.ID);//使用linq语句,得到一个临时列表
                    foreach (var order in orders)
                    {
                        string[] subitems = { order.ID.ToString(), order.Customer, order.GoodsName, order.Price.ToString(), "" };

                        listView.Items.Add(new ListViewItem(subitems));
                    }

                }
               

            }
            catch (Exception ex)
            {

                MessageBox.Show("导入失败：" + ex.Message);
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class ListViewColumnSorter : IComparer
    {
        #region 属性

        private CaseInsensitiveComparer _objectCompare;

        private int _sortColumn;
        /// <summary>
        /// 获取或设置要排序的列
        /// </summary>
        public int SortColumn
        {
            get { return _sortColumn; }
            set { _sortColumn = value; }
        }

        private SortOrder _orderType;
        /// <summary>
        /// 获取或设置排序方式
        /// </summary>
        public SortOrder OrderType
        {
            get { return _orderType; }
            set { _orderType = value; }
        }

        private bool _stringNumOrder;
        /// <summary>
        /// 获取或设置字符串中的数字是否按照正常理解顺序排序
        /// </summary>
        public bool StringNumOrder
        {
            get { return _stringNumOrder; }
            set { _stringNumOrder = value; }
        }

        #endregion

        public ListViewColumnSorter()
        {
            _sortColumn = 0;

            _stringNumOrder = false;

            _orderType = SortOrder.None;

            _objectCompare = new CaseInsensitiveComparer();
        }


        public int Compare(object x, object y)
        {
            int compareResult = 0;

            string stringX = ((ListViewItem)x).SubItems[_sortColumn].Text;
            string stringY = ((ListViewItem)y).SubItems[_sortColumn].Text;
            DateTime dtx = new DateTime();
            DateTime dty = new DateTime();
            int intx = new int();
            int inty = new int();
            double doublex = new double();
            double doubley = new double();

            if (DateTime.TryParse(stringX, out dtx) && DateTime.TryParse(stringY, out dty))
            {
                compareResult = _objectCompare.Compare(dtx, dty);
            }
            else if (int.TryParse(stringX, out intx) && int.TryParse(stringY, out inty))
            {
                compareResult = _objectCompare.Compare(intx, inty);
            }
            else if (double.TryParse(stringX, out doublex) && double.TryParse(stringY, out doubley))
            {
                compareResult = _objectCompare.Compare(doublex, doubley);
            }
            else
            {
                if (_stringNumOrder == true)
                    compareResult = StringNumCompare(stringX, stringY);
                if (compareResult == 0)
                    compareResult = _objectCompare.Compare(stringX, stringY);
            }

            if (_orderType == SortOrder.Ascending)
            {
                return compareResult;
            }
            else if (_orderType == SortOrder.Descending)
            {
                return (-compareResult);
            }
            else
            {
                return 0;
            }

        }

        //对字符串中相同位置的数字进行对比
        private int StringNumCompare(string stringX, string stringY)
        {
            int returnValue = 0;
            int stringCount = stringX.Count() > stringY.Count() ? stringY.Count() : stringX.Count();
            for (int i = 0; i < stringCount; i++)
            {
                int tempX;
                int tempY;
                if ((stringX[i] != stringY[i]) && int.TryParse(stringX[i].ToString(), out tempX) && int.TryParse(stringY[i].ToString(), out tempY))
                {
                    tempX = GetStringNum(tempX, i + 1, stringCount, stringX);
                    tempY = GetStringNum(tempY, i + 1, stringCount, stringY);
                    if (tempX > tempY)
                        returnValue = 1;
                    else if (tempX < tempY)
                        returnValue = -1;

                    if (returnValue == 0)
                        continue;
                    else
                        break;
                }
            }

            return returnValue;
        }

        //获取字符串中的数字
        private int GetStringNum(int returnValue, int i, int stringCount, string stringTemp)
        {
            int temp;
            if (i < stringCount && int.TryParse(stringTemp[i].ToString(), out temp))
            {
                returnValue = returnValue * 10 + temp;
                GetStringNum(returnValue, i + 1, stringCount, stringTemp);
            }
            return returnValue;
        }
    } //listview排序类
}
