using Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            var yms = new YearMonth[] {
                new YearMonth(1990, 1),
                new YearMonth(2000, 2),
                new YearMonth(2010, 3),
                new YearMonth(2020, 4),
                new YearMonth(2030, 5),
            };

            Exercise2_2(yms);
            Console.WriteLine("-------");

            //FindFirst21C(yms);
            //Console.WriteLine("-------");

            Exercise2_4(yms);
            Console.WriteLine("-------");

            Exercise2_5(yms);
            Console.WriteLine("-------");
        }

        private static void Exercise2_2(YearMonth[] yms) {
            foreach(var ym in yms){
                Console.WriteLine(ym);           
            }       
        }

        //4.2.3
        static YearMonth FindFirst21C(YearMonth[] yms) {
            foreach(var ym in yms) {
                if (ym.Is21Century)
                    return ym;
            }
            return null;
        }

        private static void Exercise2_4(YearMonth[] yms) {
            var yearmonth = FindFirst21C(yms);
            var s = yearmonth != null ? yearmonth.ToString() : "21世紀のデータはありません";
            Console.WriteLine(s);
        }

        private static void Exercise2_5(YearMonth[] yms) {
            var add = yms.Select(s => s.AddOneMonth()).ToArray();
            foreach (var n in add)
                Console.WriteLine(n);
            //yms.Select(ym => ym.AddOneMonth()).ToList().ForEach(Console.WriteLine);
        }
    }
}
