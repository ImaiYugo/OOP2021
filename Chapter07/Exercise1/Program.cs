using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);
        }

        private static void Exercise1_1(string text) {
            var dict = new Dictionary<char, int > ();
            foreach (var c in text) {
                //大文字小文字を区別しないためすべて大文字に変換して処理
                var uc = char.ToUpper(c);
                if ('A' <= uc && uc <= 'Z') {
                    if (dict.ContainsKey(uc)){
                        dict[uc]++;
                    } else {
                        dict[uc] =1;
                    }
                }
            }
            //Aから並び変えて出力
            //var sort = dict.OrderBy(n=>n);



           //var sort = dict.OrderBy(n=>n);
           // foreach (var s in dict) {
           //     Console.WriteLine(s);
           // }

        }

        private static void Exercise1_2(string text) {
            
        }
    }
}
