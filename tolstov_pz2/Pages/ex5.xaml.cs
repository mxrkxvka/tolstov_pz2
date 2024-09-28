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
    public partial class ex5 : Window
    {
        public ex5()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtSorted.Clear();
                txtRevSorted.Clear();
                txtOriginalArray.Clear();

                int m = int.Parse(txtRows.Text);
                int n = int.Parse(txtColumns.Text);

                int[,] randomArray = new int[m, n];

                Random rnd = new Random();

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        randomArray[i, j] = rnd.Next(-10, 11);
                    }
                }

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        sb.Append(randomArray[i, j]);
                        if (j < n - 1)
                        {
                            sb.Append("\t");
                        }
                    }
                    sb.AppendLine();
                }

                txtOriginalArray.Text = sb.ToString();

                int[] flatArray = new int[m * n];
                int index = 0;
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        flatArray[index++] = randomArray[i, j];
                    }
                }

                Array.Sort(flatArray);
                int min = flatArray[0];
                int max = flatArray[n * m - 1];

                index = 0;
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        randomArray[i, j] = flatArray[index++];
                    }
                }

                StringBuilder res1 = new StringBuilder();
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        res1.Append(randomArray[i, j]);
                        if (j < n - 1)
                        {
                            res1.Append("\t");
                        }
                    }
                    res1.AppendLine();
                }

                Array.Reverse(flatArray);

                index = 0;
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        randomArray[i, j] = flatArray[index++];
                    }
                }

                StringBuilder res2 = new StringBuilder();
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        res2.Append(randomArray[i, j]);
                        if (j < n - 1)
                        {
                            res2.Append("\t");
                        }
                    }
                    res2.AppendLine();
                }

                txtSorted.Text = res1.ToString();
                txtRevSorted.Text = res2.ToString();
                txtMinMax.Text = $"min - {min}, max - {max}";
            }
            catch
            {
                MessageBox.Show("Входная строка не заполнена", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }
    }
}
