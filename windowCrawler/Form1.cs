using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowCrawler
{
    public partial class Form1 : Form
    {
        public string Download(string url)  //将url指向的html文件之源码下载下来，返回string
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;   //webclient是c#的NET包中自带的工具
                string html = webClient.DownloadString(url);//将url指向的html文件之源码下载并存入html

                //Console.WriteLine(html);

                //string fileName = count.ToString();
                string fileName = @"‪Test" + count.ToString() + ".txt";
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                listView.Items.Add(new ListViewItem("下载错误：" + ex.Message));

                 
                return "";

            }
        }
        public void Parse(string html, string root)
        {

            //在下载好的网页源码中，找href标签。
            string strRef = @"(href|HREF)[ ]*=[ ]*[""'][^""'#>]+(\.)(html|htm|aspx|jsp|php)[""']";//只爬取html，htm，jsp，aspx、php页面
            MatchCollection matches = new Regex(strRef).Matches(html);
            //href是网页超链接的一个属性，它后面写一个url
            //点击这个超链接，就会跳转到该url指向的资源（可能是一个服务器本地文件，也可能是一个新的网页）
            //如果一个网页源码中有写另一个网址，这个网址一定写在href属性中


            foreach (Match match in matches)
            {
                //fatherurl是指：

                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                //match.value是匹配成功的子串，即  href=“字母数字组合” ；从子串里面找到=后面的部分，which is a url
                //strRef里存的就是我们要下载的地址了。
                //它可能是绝对地址，形如：https://www.cnblogs.com/binghe001/p/13794228.html
                //也可能是相对地址，形如：test/index.html 或 ./test/index.html
                //

                if (strRef.Length == 0) continue;
                if (!strRef.Contains("https://www."))
                {
                    string temp = strRef;
                    if (temp.Substring(0, 1) == "./") { temp = strRef.Substring(2, strRef.Length); }

                    urls[root + temp] = false;

                }
                if (urls[strRef] == null && strRef.Contains("/www.cnblogs.")) urls[strRef] = false;//hashtable里没有，那就加入并置为false准备下载！
            }
        }


        private void Crawl()
        {
            
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;//hashtable根据key值（string）找value（Boolean）
                    current = url;
                }
                if (current == null | count > 100) break;
                //Console.WriteLine("============================================================================");
                //Console.WriteLine("爬行" + current + "页面！");

                //listView.Items.Add(new ListViewItem("爬行" + current + "页面！"));
                listViewItems.Add(new ListViewItem());//匿名变量添加一个ListViewItem
                listViewItems.Last().SubItems[0].Text = "爬行" + current + "页面！";
                listView.Items.Add(listViewItems.Last());

                string html = Download(current);  //将url指向的html文件之源码下载下来，返回string

                urls[current] = true;
                count++;

                Parse(html, current);
            }
            //listView.Items.Add(new ListViewItem("爬行结束！" ));
            listViewItems.Add(new ListViewItem());//匿名变量添加一个ListViewItem
            listViewItems.Last().SubItems[0].Text = "爬行结束！";
            listView.Items.Add(listViewItems.Last());

        }

        private Hashtable urls = new Hashtable();
        private int count = 0;
        public List<ListViewItem> listViewItems = new List<ListViewItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//开始爬取
        {
            

            string starturl = urltextBox.Text;
            

            urls.Add(starturl, false); //初始状态为false，等下开始下载;urls是一个HashTable<key:string , value:boolean>

            new Thread(Crawl).Start();
        }
    }
}
