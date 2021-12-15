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
    /// Page4.xaml の相互作用ロジック
    /// </summary>
    public partial class Page4 : Page
    {
        private const int Rows = 4;
        private const int Columns = 4;
        private SolidColorBrush btColor = new SolidColorBrush(Color.FromArgb(100, 243, 225, 142));

        public Page4() {
            InitializeComponent();
        }

        private void Main_Loaded(object sender, RoutedEventArgs e) {

            List<Button> buttons = new List<Button>();

            //行
            for (int i = 0; i < Rows; i++) {
                grid.RowDefinitions.Add(new RowDefinition());
            }
            //列
            for (int i = 0; i < Columns; i++) {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < Rows; i++) {
                for (int j = 0; j < Columns; j++) {
                    var bt = new Button();
                    bt.Width = grid.Width / Columns;
                    bt.Height = grid.Height / Rows;
                    bt.Content = i * Rows + (j + 1);
                    bt.Background = btColor;
                    bt.FontSize = 20;
                    bt.Click += Button_Click;
                    Grid.SetRow(bt, i);
                    Grid.SetColumn(bt, j);
                    buttons.Add(bt);
                }
            }
            buttons.ForEach(bt => grid.Children.Add(bt));
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            throw new NotImplementedException();
        }
    }
}
