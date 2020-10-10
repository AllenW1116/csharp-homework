using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;
//第二题用事件机制做！下载完成事件downloadover，然后把事件传入处理函数。
//但是这是会报错，因为下载是在主线程，更新消息是在新线程，解决方法在ppt最后两页！

//第五次作业：
//1、改进书上例子9-10的爬虫程序。
//（1）只爬取起始网站（www.cnblog.com）上的网页 
//（2）只有当爬取的是html，htm，jsp，aspx、php页面时，才解析并爬取下一级URL。
//（3）相对地址转成绝对地址进行爬取。
//	例如：当前页面是 https://www.cnblogs.com/abc/时, 该页面中的链接 test/index.html 或者 ./test/index.html都相当于 https://www.cnblogs.com/abc/test/index.html ， ../zzz/index.html相当于 https://www.cnblogs.com/zzz/index.html 

//2、尝试使用Winform来设置初始URL，启动爬虫，显示已经爬取的URL和错误的URL信息。

//3、将爬虫程序，使用并行处理进行优化，实现更快速的网页爬取。




//本例实现第一题：只爬取html，htm，jsp，aspx、php页面+相对地址转成绝对地址进行爬取。
namespace SimpleCrawler1
{
    class Crawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        static void Main(string[] args)
        {
            Crawler myCrawler = new Crawler();

            string starturl = "https://www.cnblogs.com/";
            if (args.Length >= 1) starturl = args[0];
            // if (true) starturl = args[0];

            myCrawler.urls.Add(starturl, false); //初始状态为false，等下开始下载;urls是一个HashTable<key:string , value:boolean>

            new Thread(myCrawler.Crawl).Start();

        }

        private void Crawl()
        {
 
            Console.WriteLine("开始爬取……");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;//hashtable根据key值（string）找value（Boolean）
                    current = url;
                }
                if (current == null | count>100) break;
                Console.WriteLine("============================================================================");
                Console.WriteLine("爬行" + current + "页面！");

                string html = Download(current);  //将url指向的html文件之源码下载下来，返回string

                urls[current] = true;
                count++;

                Parse(html,current);
            }
            Console.WriteLine("爬行结束！");

        }

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

                Console.WriteLine("下载错误：" + ex.Message);
                return "";
                
            }
        }

        public void Parse(string html,string root)
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
                if (!strRef.Contains("https://www.") )
                {
                    string temp=strRef;
                    if (temp.Substring(0, 1) == "./") { temp = strRef.Substring(2, strRef.Length); }

                    urls[root+temp] = false;

                }
                if (urls[strRef] == null && strRef.Contains("/www.cnblogs.")) urls[strRef] = false;//hashtable里没有，那就加入并置为false准备下载！
            }
        }
    }
}
