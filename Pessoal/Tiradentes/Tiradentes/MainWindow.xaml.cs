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

namespace Tiradentes
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
        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            string x = TxtPalavra.Text;
            int y = x.Replace(" ", "").Length;
            string z = String.Format(" *** ");
            TxtPalavra.Text = z;    

            string asterisco = "";
            for(int i =1; i <= TxtPalavra.Text.Length; i++)
            {
                asterisco += "*";
            }

            string resp = TxtPalavra.Text;
            TxtPalavra.Text = asterisco;

        }
        private void btnA_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
