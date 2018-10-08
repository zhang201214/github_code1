using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace 服务器1
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

       

        private void Window_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //修改窗体退出方式 改为 OnExplicitShutdown
            Application.Current.Shutdown();
        }

        

    
        

        
        

        
        
    }
}
