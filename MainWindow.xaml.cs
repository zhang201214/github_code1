using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xaml;
using System.Collections.Generic;

namespace 服务器1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((textbox1.Text == "") || (textbox2.Text == ""))
            {
                MessageBox.Show("请输入用户名和密码");
            }
            else
            {
                string name = textbox1.Text;
                string key = textbox2.Text;
                string con = "server=192.168.0.101;database=登录用户;Trusted_Connection=SSPI";
                //string sql = "select 用户名,密码 from 登录用户.dbo.登录用户 where 用户名=bbb";
                string sql = "select 用户名,密码 from 登录用户.dbo.登录用户";
                SqlConnection mycon = new SqlConnection(con);
                mycon.Open();
                SqlDataAdapter myda = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                myda.Fill(ds, "ddd");
                DataTable dt = new DataTable();
                dt = ds.Tables["ddd"];
                datagrid1.ItemsSource = dt.DefaultView;
                mycon.Close();
                // textbox2.Text = Convert.ToString(datagrid1.Items.Count);
                //DataRowView selectItem = datagrid1.Items[1] as DataRowView;
                //textbox2.Text = Convert.ToString( selectItem["用户名"]);
                int[] a = new int[1];
                a[0] = 0;
                for (int i = 0; i < datagrid1.Items.Count - 1; i++)
                {
                    DataRowView selectItem = datagrid1.Items[i] as DataRowView;

                    if (Convert.ToString(selectItem["用户名"]) == textbox1.Text)
                    {
                        a[0] = a[0] + 1;
                        //如果用户名存在接下来判断与之匹配的密码是否正确，如果都正确，显示主窗口
                        if (Convert.ToString(selectItem["密码"]) == textbox2.Text)
                        {
                            //加载主界面
                            //MessageBox.Show("登录！");
                            //this.Visibility=Visibility.Hidden;
                            this.Close();
                            Window1 r = new Window1();
                            r.ShowDialog();
                            //this.Visibility = Visibility.Hidden;
                            //IntPtr Window1 = new WindowInteropHelper(this).Handle;
                            //this.Visibility = Visibility.Visible;
                            //NavigationWindow window = new NavigationWindow();
                            //window.Source = new Uri("Window1.xaml", UriKind.Relative);
                            //window.Show();
                            
                        }
                        else
                        {
                            MessageBox.Show("密码错误");
                        }
                    }
                    else { }
                }
                if (a[0] == 0)
                {
                    MessageBox.Show("用户名不存在");
                }
                else { }
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Environment.Exit(0);
            Application.Current.Shutdown();
        }
    }
}
