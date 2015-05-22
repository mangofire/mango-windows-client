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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window{

        private Grid default_grid;
        private Grid duanxin_grid;
        private Grid tonghuajilu_grid;
        private Grid lianxiren_grid;

        public MainWindow(){
            InitializeComponent();
            this.default_grid = new Grid { Name = "Default"};
            this.duanxin_grid = new Grid { Name = "duanxin" };
            this.tonghuajilu_grid = new Grid { Name = "tonghuajilu" };
            this.lianxiren_grid = new Grid { Name = "lianxiren" };
        }
        private void hidden_all()
        {
            this.@default.Visibility = Visibility.Hidden;
            this.lianxiren.Visibility = Visibility.Hidden;
            this.duanxin.Visibility = Visibility.Hidden;
            this.tonghuajilu.Visibility = Visibility.Hidden;
        }
        private void getVisibility()
        {
            MessageBox.Show("defalut:"+this.@default.IsVisible.ToString()+
                "联系人"+this.lianxiren.IsVisible.ToString()+
                "短信"+this.duanxin.IsVisible.ToString()+
                "通话记录"+this.tonghuajilu.IsVisible.ToString());
        }
        private void setVisualTrue(string name)
        {
            hidden_all();
            Console.Write("here");
            switch (name)
            {
                case "default":
                    this.@default.Visibility = System.Windows.Visibility.Visible;
                    break;
                case "lianxiren":
                    this.lianxiren.Visibility = System.Windows.Visibility.Visible;
                    break;
                case "duanxin":
                    this.duanxin.Visibility = System.Windows.Visibility.Visible;
                    break;
                case "tonghuajilu":
                    this.tonghuajilu.Visibility = System.Windows.Visibility.Visible;
                    break;
                default:
                    break;
            }

        }
        private void shouye_btn_down(object sender, RoutedEventArgs e) {
            //MessageBox.Show("首页");
            ////hidden_all();
            //getVisibility();
            setVisualTrue("default");
            
        }
        private void duanxin_btn_down(object sender, RoutedEventArgs e) {
            //MessageBox.Show("短信");
            setVisualTrue("duanxin");
            //getVisibility();
        }
        private void tonghuajilu_btn_down(object sender, RoutedEventArgs e) {
            //MessageBox.Show("通话记录");
            setVisualTrue("tonghuajilu");
            //getVisibility();
        }
        private void config_btn_down(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("设置");
            //setVisualTrue("config");
        }
        private void guanyu_btn_down(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("关于我们");
        }

        private void lianxiren_btn_down(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("联系人");
            setVisualTrue("lianxiren");
            //getVisibility();
        }

    }
}
