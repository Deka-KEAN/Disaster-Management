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
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        
        public Window1()
        {
            InitializeComponent();
        }

        private void backbutton(object sender, RoutedEventArgs e)
        {
            MainWindow obj = new MainWindow();
            obj.Show();
            this.Hide();
        }
       
        private void loginclick(object sender, RoutedEventArgs e)
        {
            Window3 obj = new Window3();
            this.Visibility = Visibility.Hidden;
            obj.Show();
            


        }

        private void forgotpass(object sender, RoutedEventArgs e)
        {
            Window4 obj1 = new Window4();            
            this.Hide();            
            obj1.Show();
        }
    }
}
