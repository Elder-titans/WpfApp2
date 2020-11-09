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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(W1.Text) + Convert.ToDouble(E1.Text);
            double c = Convert.ToDouble(W2.Text) - Convert.ToDouble(E2.Text);
            double v = Convert.ToDouble(W3.Text) * Convert.ToDouble(E3.Text);
            double b = Convert.ToDouble(W4.Text) / Convert.ToDouble(E4.Text);
            R1.Content = x;
            R2.Content = c;
            R3.Content = v;
            R4.Content = b;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 on = new Window1();
            on.Show();
        }
    }
}
