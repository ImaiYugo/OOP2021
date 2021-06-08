using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_2 {
    class Program {
        static void Main(string[] args) {

            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", };

            // 3.2.1
            Exercise2_1(names);
            Console.WriteLine("-----");

            // 3.2.2
            Exercise2_2(names);
            Console.WriteLine("-----");

            // 3.2.3
            Exercise2_3(names);
            Console.WriteLine("-----");

            // 3.2.4
            Exercise2_4(names);
            Console.WriteLine("-----");

            Exercise2_5(names);
        }

        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("<都市名を入力>");
            var line = Console.ReadLine();
            var index = names.FindIndex(s => s == line);
                 Console.WriteLine("{0}番目",index);
        }

        private static void Exercise2_2(List<string> names) {
            var count = names.Count(n => n.Contains('o'));
                Console.WriteLine(count);
        }

        private static void Exercise2_3(List<string> names) {
            var selected = names.Where(n => n.Contains('o')).ToArray();
            foreach (var s in selected)
                Console.WriteLine(s);
        }

        private static void Exercise2_4(List<string> names) {
            //var Bnum = names.Where(n => n[0] == 'B').Select(n=>n.Length);
            var Bnum = names.Where(n => n.StartsWith("B")).Select(n => n.Length);
            foreach (var s in Bnum) {
                Console.WriteLine(s);

            }
        }
        private static void Exercise2_5(List<string> names) {
            int count = 0;
            foreach (var name in names) {
                count += name.Count(c => char.IsLower(c));
            }
            Console.WriteLine(count);
            Console.WriteLine("アルファベットを入力");
            
            for(int i = 0; i <= 10; i++) {
                var abc = Console.ReadLine();
            }           
        }
    }
}
