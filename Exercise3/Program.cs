using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3 {
    class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter("Sales.csv");
            //List<Sale> sales = ReadSales("Sales.csv");

            //var amountPerStrore = sales.GetPerStoreSales();     //  店舗別売り上げを求める
            var amountPerCategory = sales.GetPerCategorySales();     //  商品カテゴリ別売り上げを求める
            foreach (var obj in amountPerCategory) {
                Console.WriteLine("{0} {1:#,0}円", obj.Key, obj.Value);
            }
        }
    }
}
