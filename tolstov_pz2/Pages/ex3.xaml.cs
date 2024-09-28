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
    public partial class ex3 : Window
    {
        public ex3()
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
            string[] numbersInStr = input.Split(' ');
            int parsedNum;
            int err = 0;

            Dictionary<int, int> numberCounts = new Dictionary<int, int>();

            foreach (string num in numbersInStr)
            {
                if (int.TryParse(num, out parsedNum))
                {
                    if (numberCounts.ContainsKey(parsedNum))
                    {
                        numberCounts[parsedNum]++;
                    }
                    else
                    {
                        numberCounts[parsedNum] = 1;
                    }
                }
                else
                {
                    err = 1;
                }

            }

            if (err == 0)
            {
                int maxKey = 0;
                int maxValue = 0;

                foreach (var key in numberCounts)
                {
                    if (key.Value > maxValue)
                    {
                        maxValue = key.Value;
                        maxKey = key.Key;
                    }
                }

                txtResult.Text = $"key - {maxKey}, value - {maxValue}";
            }
            else
            {
                MessageBox.Show("В массиве есть нецелые числа/строка не заполнена", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
