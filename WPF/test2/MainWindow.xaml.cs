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

namespace test2
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        

        public MainWindow() {
            InitializeComponent();
            _NavigationFrame.Navigate(new PageA());
        }

        private void btA_Click(object sender, RoutedEventArgs e) {
            //var pageA = new Page();
            //this.NavigationSerivce.Navigate(new Uri("Pages/PageA.xaml", UriKind.Relative));
        }

        private void btD_Click(object sender, RoutedEventArgs e) {

        }
    }
}
