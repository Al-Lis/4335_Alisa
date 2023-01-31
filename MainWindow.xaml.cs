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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab_7_8_rpm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btN_MouseEnter(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            int x = random.Next(0, 0);
            int y = random.Next(0, 0);
            int z = random.Next(0, 160);
            int q = random.Next(0, 200);
            DoubleAnimation buttonAnimation = new DoubleAnimation();
            
            var animation = new ThicknessAnimation
            {

                By = new Thickness(x, y, z, q),
                Duration = TimeSpan.FromSeconds(1)
            };
            btN.BeginAnimation(MarginProperty, animation);

            if (btN.Margin.Top <= 10 || btN.Margin.Left >= 600 || btN.Margin.Right >= 600 || btN.Margin.Left <= 150 || btN.Margin.Right <= 150)
                buttonAnimation.BeginTime = null;
                btN.BeginAnimation(MarginProperty,animation);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            part2 part2 = new part2();
            part2.Show();
        }
    }
}

