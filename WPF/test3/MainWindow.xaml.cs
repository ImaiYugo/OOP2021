using Microsoft.VisualBasic;
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

namespace test3
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private AcessForm acessForm = new AcessForm();

        public MainWindow() {
            InitializeComponent();
            _navi = this.myFrame.NavigationService;

        }
        private NavigationService _navi;

        private List<Uri> _uriList = new List<Uri>() {
            new Uri("Page1.xaml",UriKind.Relative),
            new Uri("Page2.xaml",UriKind.Relative),
            new Uri("Page3.xaml",UriKind.Relative),
            new Uri("Page4.xaml",UriKind.Relative),
};
        private void myFrame_Loaded(object sender, RoutedEventArgs e) {
            
        }

        private void btA_Click(object sender, RoutedEventArgs e) {
            _navi.Navigate(_uriList[0]);
        }

        private void btB_Click(object sender, RoutedEventArgs e) {
            _navi.Navigate(_uriList[1]);
        }

        private void btC_Click(object sender, RoutedEventArgs e) {
            _navi.Navigate(_uriList[2]);
        }
        private void btD_Click(object sender, RoutedEventArgs e) {
            _navi.Navigate(_uriList[3]);
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
                       
        }

        private void btManager_Click(object sender, RoutedEventArgs e) {
            //inputText = Interaction.InputBox(
            //    "パスワードを入力してください", "管理者モード", "", 350, 400);
            acessForm.ShowDialog();
        }
    }
}
