using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Window
{
    public class DContext : DbContext
    {
        /// <summary>
        /// 添加构造函数,name为config文件中数据库连接字符串的name
        /// </summary>
        public DContext() : base("name=connOrder")
        {
            Database.SetInitializer(
       new DropCreateDatabaseAlways<DContext>());
        }

        #region 数据集
        public DbSet<Order> Orders { get; set; }

        #endregion  
    }
}
