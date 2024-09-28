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
    public partial class ex1 : Window
    {
        public ex1()
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

            if (int.TryParse(txtInput.Text, out int N) && N >= 0 && N <= 1000)
            {
                Dictionary<string, int> digitDictionary = new Dictionary<string, int>
                {
                    { "0", 0 },
                    { "1", 0 },
                    { "2", 0 },
                    { "3", 0 },
                    { "4", 0 },
                    { "5", 0 },
                    { "6", 0 },
                    { "7", 0 },
                    { "8", 0 },
                    { "9", 0 }
                };

                int numInNum = N * N;
                string number = numInNum.ToString();

                foreach (char digit in number)
                {
                    string digitString = digit.ToString();

                    if (digitDictionary.ContainsKey(digitString))
                    {
                        digitDictionary[digitString]++;
                    }
                }

                txtResult.Text = "";
                foreach (var num in digitDictionary)
                {
                    txtResult.Text += $"key: {num.Key}, value: {num.Value}\r\n";
                }

            }
            else
            {
                MessageBox.Show("Входная строка не заполнена/заполнена некорректно", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }   
    }
}
