using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var books = Books.GetBooks();

            Console.WriteLine("本の平均価格は" + books.Average(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("本の総ページ数は" + books.Sum(x => x.Pages) + "ページ");
            Console.WriteLine("最も高い本の価格は" + books.Max(x => x.Price) + "円");
            Console.WriteLine("最も安い本の価格は" + books.Min(x => x.Price) + "円");
            Console.WriteLine("500円以上の本は" + books.Count(x => x.Price >= 500) + "冊");
            Console.WriteLine("[物語]が含まれている本の数は" + books.Count(x => x.Title.Contains("物語")) + "冊");
            //foreach(var s in books.Where(n => n.Title.Contains("物語")).take(2)) {
            //    Console.WriteLine(s.Title);
            //}
            var bookData = books.Where(n => n.Title.Contains("物語")).Take(3);
            foreach (var book in bookData) {
                Console.WriteLine(book.Title);
            }

            var best = books.OrderByDescending(n=>n.Price).Take(3);
            foreach (var s in best) {
                Console.WriteLine(s.Title + " " + s.Price + "円");

            }

            var titles = books.Select(x => x.Title);
            foreach (var item in titles) {
                Console.WriteLine(item);
            }

        }
    }
}