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

namespace NumberGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {

        private Random random = new Random();
        private int answerNum;
        private const int Rows = 5;     //列
        private const int Columns = 5;   //行

        private SolidColorBrush selectedButtonColor = new SolidColorBrush(Colors.Yellow);
        private SolidColorBrush hitButtonColor = new SolidColorBrush(Colors.Red);

        public MainWindow() {
            InitializeComponent();
            answerNum = random.Next(1, 26);
        }
        //ロード時に一度だけ実行される
        private void MainDisp_Loaded(object sender, RoutedEventArgs e) {

            List<Button> buttons = new List<Button>();

            //正解を取得
            answerNum = random.Next(Rows * Columns) + 1;

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
                    bt.Width = MainForm.Width / Columns;
                    bt.Height = MainForm.Height / Rows;
                    bt.Content = i * Rows + (j + 1);

                    bt.FontSize = 20;
                    bt.Click += Button_Click;
                    Grid.SetRow(bt, i);
                    Grid.SetColumn(bt, j);
                    buttons.Add(bt);
                }
            }
            buttons.ForEach(bt => grid.Children.Add(bt));
            MainForm.Height += textDisp.Height + 50;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            //Button button = (Button)sender;
            //switch (button.Tag.ToString()) {
            //    case "1"

            //        break;
            //}

            Button selectedButton = (Button)sender;
            int num = (int)selectedButton.Content;
            if (num == answerNum) {
                textDisp.Text = "正解です!";
                selectedButton.Background = hitButtonColor;

            }
            if (num < answerNum) {
                textDisp.Text = "数字が小さいです";
                selectedButton.Background = selectedButtonColor;
            }
            if (num > answerNum) {
                textDisp.Text = "数字が大きいです";
                selectedButton.Background = selectedButtonColor;
            }
        }
    }
}
