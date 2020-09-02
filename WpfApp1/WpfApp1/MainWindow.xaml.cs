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
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        
       
        private void OpenWindow1(object sender, RoutedEventArgs e)
        { 
            MainWindow obj1 = new MainWindow();
            Window1 obj = new Window1();
            this.Visibility = Visibility.Hidden;
            obj.Show();            
        }

        private void OpenWindow2(object sender, RoutedEventArgs e)
        {
            Window2 obj = new Window2();
            this.Visibility = Visibility.Hidden;
           
            obj.Show();
        }

        private void exitapplication(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
