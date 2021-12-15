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

namespace test1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
        }

		private void Main_Loaded(object sender, RoutedEventArgs e) {

            Grid grid = new Grid();
            grid.Width = 700;
            grid.Height = 600;
            grid.HorizontalAlignment = HorizontalAlignment.Left;
            grid.VerticalAlignment = VerticalAlignment.Top;
            grid.ShowGridLines = true;

            // Define the Columns
            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            ColumnDefinition colDef5 = new ColumnDefinition();
            grid.ColumnDefinitions.Add(colDef1);
            grid.ColumnDefinitions.Add(colDef2);
            grid.ColumnDefinitions.Add(colDef3);
            grid.ColumnDefinitions.Add(colDef4);
            grid.ColumnDefinitions.Add(colDef5);

            // Define the Rows
            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            RowDefinition rowDef5 = new RowDefinition();
            grid.RowDefinitions.Add(rowDef1);
            grid.RowDefinitions.Add(rowDef2);
            grid.RowDefinitions.Add(rowDef3);
            grid.RowDefinitions.Add(rowDef4);
            grid.RowDefinitions.Add(rowDef5);

            // Add the first text cell to the Grid
            Button bt1 = new Button();
            bt1.Content = "a";
            bt1.FontSize = 20;
            bt1.FontWeight = FontWeights.Bold;
            Grid.SetColumn(bt1, 1);
            Grid.SetRow(bt1, 0);

            Button bt2 = new Button();
            bt2.Content = "b";
            bt2.FontSize = 20;
            bt2.FontWeight = FontWeights.Bold;
            Grid.SetColumn(bt2, 2);
            Grid.SetRow(bt2, 0);

            Button bt3 = new Button();
            bt3.Content = "c";
            bt3.FontSize = 20;
            bt3.FontWeight = FontWeights.Bold;
            Grid.SetColumn(bt3, 3);
            Grid.SetRow(bt3, 0);

            Button bt4 = new Button();
            bt4.Content = "d";
            bt4.FontSize = 20;
            bt4.FontWeight = FontWeights.Bold;
            Grid.SetColumn(bt4, 4);
            Grid.SetRow(bt4, 0);



            // Add the second text cell to the Grid
            TextBlock txt2 = new TextBlock();
            txt2.Text = "Quarter 1";
            txt2.FontSize = 12;
            txt2.FontWeight = FontWeights.Bold;
            Grid.SetRow(txt2, 1);
            Grid.SetColumn(txt2, 0);

            // Add the third text cell to the Grid
            TextBlock txt3 = new TextBlock();
            txt3.Text = "Quarter 2";
            txt3.FontSize = 12;
            txt3.FontWeight = FontWeights.Bold;
            Grid.SetRow(txt3, 1);
            Grid.SetColumn(txt3, 1);

            // Add the fourth text cell to the Grid
            TextBlock txt4 = new TextBlock();
            txt4.Text = "Quarter 3";
            txt4.FontSize = 12;
            txt4.FontWeight = FontWeights.Bold;
            Grid.SetRow(txt4, 1);
            Grid.SetColumn(txt4, 2);

            // Add the sixth text cell to the Grid
            TextBlock txt5 = new TextBlock();
            Double db1 = new Double();
            db1 = 50000;
            txt5.Text = db1.ToString();
            Grid.SetRow(txt5, 2);
            Grid.SetColumn(txt5, 0);

            // Add the seventh text cell to the Grid
            TextBlock txt6 = new TextBlock();
            Double db2 = new Double();
            db2 = 100000;
            txt6.Text = db2.ToString();
            Grid.SetRow(txt6, 2);
            Grid.SetColumn(txt6, 1);

            // Add the final text cell to the Grid
            TextBlock txt7 = new TextBlock();
            Double db3 = new Double();
            db3 = 150000;
            txt7.Text = db3.ToString();
            Grid.SetRow(txt7, 2);
            Grid.SetColumn(txt7, 2);

            // Total all Data and Span Three Columns
            TextBlock txt8 = new TextBlock();
            txt8.FontSize = 16;
            txt8.FontWeight = FontWeights.Bold;
            txt8.Text = "Total Units: " + (db1 + db2 + db3).ToString();
            Grid.SetRow(txt8, 3);
            Grid.SetColumnSpan(txt8, 3);

            // Add the TextBlock elements to the Grid Children collection
            grid.Children.Add(bt1);
            grid.Children.Add(bt2);
            grid.Children.Add(txt2);
            grid.Children.Add(txt3);
            grid.Children.Add(txt4);
            grid.Children.Add(txt5);
            grid.Children.Add(txt6);
            grid.Children.Add(txt7);
            grid.Children.Add(txt8);

            // Add the Grid as the Content of the Parent Window Object
            Main.Content = grid;
            Main.Show();
		}
    }
}

