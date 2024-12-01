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

namespace WpfApp7
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

        public IEnumerable<int> GenerateNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                yield return i;
            }
        }



        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            NumbersListBox.Items.Clear();

            if (int.TryParse(Start.Text, out int start) &&
                int.TryParse(End.Text, out int end))
            {
                if (start > end)
                {
                    MessageBox.Show("начальное число больше конечного");
                    return;
                }

                foreach (var number in GenerateNumbers(start, end))
                {
                    NumbersListBox.Items.Add(number);
                }

            }
        }
    }
}

