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
using tolstov_pz2.Pages;

namespace tolstov_pz2
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

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void FrmMain_ContentRendered(object sender, System.EventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ex1 ex = new ex1();
            ex.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ex2 ex = new ex2();
            ex.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ex3 ex = new ex3();
            ex.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ex4 ex = new ex4();
            ex.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ex5 ex = new ex5();
            ex.Show();
        }
    }
}
