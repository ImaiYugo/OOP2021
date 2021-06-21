using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            #region 問題5.1
            Console.Write("文字列1を入力:");
            var s1 = Console.ReadLine();
            Console.Write("文字列2を入力:");
            var s2 = Console.ReadLine();

            if (String.Compare(s1, s2, ignoreCase:true) == 0)
                Console.WriteLine("等しい");
            else
                Console.WriteLine("等しくない");
            #endregion

            #region 問題5-2
            Console.Write("数列1を入力:");
            var t1 = Console.ReadLine();
            Console.Write("数列2を入力:");
            var t2 = Console.ReadLine();
            #endregion

        }

    }
}
