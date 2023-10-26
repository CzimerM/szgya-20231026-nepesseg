using System;
using System.Collections.Generic;
using System.IO;
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

namespace adatbovites
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

        private void btnMentesFunc(object sender, RoutedEventArgs e)
        {
            if (int.Parse(txbFovarosLakossag.Text) > int.Parse(txbNepesseg.Text))
            {
                lblKiiras.Content = "A főváros lakossága nem lehet több, mint az ország lakossága.";
                return;
            }

            using var sw = new StreamWriter("../../../ujadat.txt", true, Encoding.UTF8);
            sw.WriteLine($"{txbOrszag.Text};{txbTerulet.Text};{txbNepesseg.Text};{txbFovaros.Text};{txbFovarosLakossag.Text}");

        }

        private void btnKilepesFunc(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
