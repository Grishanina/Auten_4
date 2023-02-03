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
using System.Windows.Threading;

namespace Auten_2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        DispatcherTimer disTimer_1 = new DispatcherTimer();
        public Window1()
        {
            InitializeComponent();
            disTimer_1.Interval = new TimeSpan(0, 0, 1);
            disTimer_1.Tick += new EventHandler(DisTimer_Tick_1);
            disTimer_1.Start();
        }

        private void bb_Click(object sender, RoutedEventArgs e)
        {
            
            if(Kod.Text==MainWindow.kod) // Значение переменной kod из окна MainWindow
            {
                MessageBox.Show("Авторизация прошла \nуспешно");
            }
            else
            {
                MessageBox.Show("ОШИБКА!!!");
            }
        }

        int tm = 10;
        private void DisTimer_Tick_1(object sender, EventArgs e)
        {
            if (tm != 0)
            {
                tm--;
                Time_Kode.Text = string.Format("{0}", tm);
            }
            else
            {
                disTimer_1.Stop();
                //MessageBox.Show("стоп");  
                this.Close();
            }

        }
    }
}
