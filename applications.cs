using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace 服务器1
{
    public partial class App : Application
    {
        [STAThread]
        static void Main1()
        {
            App a;
            
             Application app = new Application();
            // 方法一：调用Run方法，参数为启动的窗体对象 ，也是最常用的方法 
              MainWindow win = new MainWindow();
            app.Run(win);
        }
    }


}
