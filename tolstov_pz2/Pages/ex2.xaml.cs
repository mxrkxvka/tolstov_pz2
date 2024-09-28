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

namespace tolstov_pz2.Pages
{
    public partial class ex2 : Window
    {
        public ex2()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Clear();

            string input = txtInput.Text;
            if (input.Length == 0) MessageBox.Show("Входная строка не заполнена", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Warning);
            char[] inputArray = input.ToCharArray();

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] == ' ')
                {
                    inputArray[i] = char.ToUpper(inputArray[i]);
                }
            }

            txtResult.Text = new string(inputArray);
        }
    }
}
