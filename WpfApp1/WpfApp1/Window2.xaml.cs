using System;
using System.Data;
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
using FireSharp.Interfaces;
using FireSharp.Response;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        /*
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "imBfzMspPvi2UB9Hx9QdnwADAwWNHKxRbwITXwBn",
            BasePath = "https://hackathon-4b97a.firebaseio.com/"
        };
        IFirebaseClient firebaseClient;
        */
        public Window2()
        {
            InitializeComponent();
        }

        private void Backbutton(object sender, RoutedEventArgs e)
        {
            MainWindow obj = new MainWindow();
            this.Hide();
            obj.Show();
        }
       /* private void wpf_load(object sender,RoutedEventArgs e)
        {
            firebaseClient = new FireSharp.FirebaseClient(config);
            if(firebaseClient!=null)
            {
                MessageBox.Show("Connection Established");
            }
        }*/
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 obj = new Window2();
            this.Hide();
            obj.Show();
        }
    }
}
