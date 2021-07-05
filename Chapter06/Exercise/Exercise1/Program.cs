using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {

    class Book {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }

    class Program {

        static void Main(string[] args) {
            var numbers = new int[] {5,10,17,9,3,21,10,40,21,3,35,};
            var books = new List<Book> {
               new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            #region テスト用ドライバ

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
            Console.WriteLine("-----");

            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);

            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);

            Console.WriteLine("-----");

            Exercise2_7(books);
            #endregion
        }

        #region 6-1
        private static void Exercise1_1(int[] numbers) {
            var max = numbers.Max(x => x);
            Console.WriteLine(max);
        }

        private static void Exercise1_2(int[] numbers) {
            //for (int i = numbers.Length-1; i >= numbers.Length -2; i--) {
            //    Console.WriteLine(numbers[i]);
            //}
            var skip = numbers.Length - 2;
            foreach (var n in numbers.Skip(skip))
                Console.WriteLine(n);
        }

        private static void Exercise1_3(int[] numbers) {
            var moji = numbers.Select(x => x.ToString());
            foreach (var item in moji)
                Console.WriteLine(item);
        }

        private static void Exercise1_4(int[] numbers) {
            var three = numbers.OrderBy(x=>x).Take(3);
            foreach (var item in three)
                Console.WriteLine(item);
        }

        private static void Exercise1_5(int[] numbers) {
            var result = numbers.Distinct().Count(x => x >= 10);
            Console.WriteLine(result);
        }
        #endregion

        #region 6-2
        private static void Exercise2_1(List<Book> books) {
            var book = books.FirstOrDefault(n=>n.Title.Contains("ワンダフル・C#ライフ"));
            if(book != null) {
                Console.WriteLine("{0}円　{1}ページ",book.Price,book.Pages);
            }
        }

        private static void Exercise2_2(List<Book> books) {
            Console.WriteLine(books.Count(x => x.Title.Contains("C#")) + "冊");
        }

        private static void Exercise2_3(List<Book> books) {
            //var cbooks = books.Where(x => x.Title.Contains("C#"));
            //var count = 0;
            //foreach (var s in cbooks) {
            //    count += s.Pages;
            //}
            //Console.WriteLine("平均"+count/books.Count+"ページ");

            var average = books.Where(n => n.Title.Contains("C#")).Average(n => n.Pages);
            Console.WriteLine(average);
        }

        private static void Exercise2_4(List<Book> books) {
            var book = books.FirstOrDefault(n => n.Price >= 4000);
            if(book != null){
                Console.WriteLine(book.Title);
            }
            
        }

        private static void Exercise2_5(List<Book> books) {
            var book = books.Where(n => n.Price < 4000).Max(s=>s.Pages);
            Console.WriteLine(book+"ページ");
        }

        private static void Exercise2_6(List<Book> books) {
            var book = books.OrderByDescending(x => x.Pages);
            foreach (var n in book) {
                Console.WriteLine("{0} {1}円",n.Title,n.Price);
            }
        }

        private static void Exercise2_7(List<Book> books) {
            var book = books.Where(n => n.Title.Contains("C#") && n.Pages <= 500);
            foreach (var s in book) {
                Console.WriteLine(s.Title);
            }
        }
        #endregion
    }
}
