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

namespace lab_7_8_rpm
{
    /// <summary>
    /// Логика взаимодействия для part2.xaml
    /// </summary>
    public partial class part2 : Window
    {
        public part2()
        {
            InitializeComponent();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{

        //}

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            part3 part3 = new part3();
            part3.Show();
        }
    }
}
