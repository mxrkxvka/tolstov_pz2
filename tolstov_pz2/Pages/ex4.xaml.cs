using System;
using System.Linq;
using System.Text;
using System.Windows;

namespace tolstov_pz2.Pages
{
    public partial class ex4 : Window
    {
        public ex4()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtResult.Clear();

                string input = txtInput.Text;
                int[] array = input.Split(' ').Select(int.Parse).ToArray();
                int[] result = new int[array.Length];

                Array.Sort(array);
                Array.Reverse(array);

                int index = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        result[index++] = array[i];
                    }
                }

                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        result[index++] = array[i];
                    }
                }

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                    sb.Append(result[i] + "\t");
                }

                txtResult.Text = sb.ToString();
            }
            catch
            {
                MessageBox.Show("Входная строка не заполнена", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }
    }
}