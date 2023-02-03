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
using System.Windows.Threading;

namespace Auten_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer disTimer_1 = new DispatcherTimer();

        public static string kod;
        public MainWindow()
        {
            InitializeComponent();
 
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            String log = "World";
            String pass = "1023";

            if ((Login.Text == log)&&(Pass.Text == pass))
            { 

                Btn.IsEnabled = false;

                Random x = new Random();
                int n = x.Next(10000, 99999);
                kod = n.ToString();
                MessageBox.Show(Convert.ToString(n));

                Window1 winUser = new Window1();
                winUser.ShowDialog();
                //Close(); 
               
                st1.Visibility = Visibility.Visible;
                disTimer_1.Interval = new TimeSpan(0, 0, 1);
                disTimer_1.Tick += new EventHandler(DisTimer_Tick_1);
                disTimer_1.Start();
                //Time_Kode.Text = disTimer.ToString();

            }
            else 
            { 
                
            }
        }

        int tm = 60;
        private void DisTimer_Tick_1(object sender, EventArgs e)
        {
            if(tm!=0)
            {
                tm--;
                tim2.Text = string.Format("{0}", tm);
            }
            else
            {
                disTimer_1.Stop();
                //MessageBox.Show("стоп");  
                Window_CAPTCHA winUser_2 = new Window_CAPTCHA();
                winUser_2.ShowDialog();
            }
            
        }
    }
}
