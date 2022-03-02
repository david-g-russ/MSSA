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
using System.Threading;
using System.IO;

namespace DispatcherTest
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

        private void btnTime_Click(object sender, RoutedEventArgs e)
        {
            // FileStream fs = new FileStream(@"C:\Files\data.txt", FileMode.Open);
            // StreamWriter sw = new StreamWriter(fs);
            // sw.WriteAsync(ToString());
            Task.Run(() =>
            {
                string currentTime = DateTime.Now.ToString();
                lblTime.Dispatcher.BeginInvoke(new Action(() => SetTime(currentTime)));
            });
        }

        private void SetTime(string time)
        {
            lblTime.Content = time;
        }
        private async void btnCoffees_Click(object sender, RoutedEventArgs e)
        {
            await GetCoffees(RemoveDuplicates);
        }
        public async Task GetCoffees(Action<IEnumerable<string>> callback)
        {
            var coffees = await Task.Run(() =>
            {
                // simulation of long-running task
                var coffeeslist = new List<string>
                {
                    "Americano",
                    "Americano",
                    "Latte",
                    "Espresso"
                };
                Thread.Sleep(6000);
                return coffeeslist;
            });

            await Task.Run(() => callback(coffees));
        }

        private void RemoveDuplicates(IEnumerable<string> coffees)
        {
            IEnumerable<string> uniqueCoffees = coffees.Distinct();
            Dispatcher.BeginInvoke(new Action(() =>
            {
                lstBox.ItemsSource = uniqueCoffees;
            }));
        }
    }
}