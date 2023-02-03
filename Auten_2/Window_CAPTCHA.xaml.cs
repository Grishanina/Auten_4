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

namespace Auten_2
{
    /// <summary>
    /// Логика взаимодействия для Window_CAPTCHA.xaml
    /// </summary>
    public partial class Window_CAPTCHA : Window
    {
        public Window_CAPTCHA()
        {
            InitializeComponent();

            Random rnd = new Random();
            // создание линии, координаты задаются рандомно:
            Line l = new Line()
            {
                X1 = rnd.Next(121),
                Y1 = rnd.Next(46),
                X2 = rnd.Next(121),
                Y2 = rnd.Next(46),
                Stroke = Brushes.Black,
            };
            // добавление линии внутрь контейнера Canvas (can - имя контейнера):
            can.Children.Add(l);



        }
    }
}
