using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section04
{
    class CityData
    {
        string city;
        int code;
    }
    
    class Program
    {

        Dictionary<string, int> AreaDic = new Dictionary<string, int>()
{
    { "前橋",4210 },
    { "みなかみ",4220 },
    { "宇都宮" ,4110},
    { "水戸",4010},
    { "さいたま",4999},

};
        //コードを保存する
        List<int> cityCode = new List<int>();

        static void Main(string[] args)
        {
            new Program();

        }

        //コンストラクタ
        public Program()
        {
            Console.WriteLine("yahoo!週間天気予報");
            Console.WriteLine();    //改行
            Console.WriteLine("地域コードを入力");

            int num = 1;
            foreach (KeyValuePair<string,int> pair in AreaDic)
            {
                Console.WriteLine("{0}:{1}", num++, pair.Key);
                cityCode.Add(pair.Value);   //コードをリストに保存

            }

            Console.WriteLine("9:その他(直接入力)");
            Console.WriteLine();    //改行

            Console.WriteLine(">");

            var selectArea = Console.ReadLine();
            int pos = int.Parse(selectArea);
            var results = GetWeatherReportFromYahoo(cityCode[pos - 1]);
            foreach (var s in results)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine(); //入力待ち
        }


        //public static int num = 0;
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("1:前橋");
        //    Console.WriteLine("2:みなかみ");
        //    Console.WriteLine("3:宇都宮");
        //    Console.WriteLine("4:水戸");
        //    Console.WriteLine("9:その他(直接入力)");
        //    Console.Write("入力:");
        //    num = int.Parse(Console.ReadLine());
        //    if(num== 9)
        //    {
        //        Console.Write("地域コードを入力:");
        //        num = int.Parse(Console.ReadLine());
        //    }
        //    new Program();      
        //}

        //public Program()
        //{
        //    int code = 0;
        //    if(num == 1)
        //    {
        //        code = 4210;
        //    }if(num == 2){
        //        code = 4220;
        //    }
        //    if(num == 3)
        //    {
        //        code = 4110;
        //    }if(num == 4)
        //    {
        //        code = 4010;
        //    }if (num == 9)
        //    {
        //        code = num;
        //    }
        //    var results = GetWeatherReportFromYahoo(code);
        //    foreach (var s in results)
        //    {
        //        Console.WriteLine(s);
        //    }
        //    Console.ReadLine();
        //}

        #region
        public void DownloadString()
        {
            var wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var html = wc.DownloadString("https://yahoo.co.jp/");
            Console.WriteLine(html);
        }
        //14-17(非同期処理)
        private void DownloadFileAsync()
        {
            var wc = new WebClient();
            var url = new Uri(@"C:\Users\yi32228\Downloads\Sample.xml");
            var filename = @"C:\temp\example.zip";
            wc.DownloadProgressChanged += wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += wc_DownloadFileCompleted;
            wc.DownloadFileAsync(url, filename);
            Console.ReadLine(); //アプリケーションが終了しないようにする
        }

        static void wc_DownloadProgressChanged(object sender,
                            DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine("{0}% {1}/{2}", e.ProgressPercentage,
                              e.BytesReceived, e.TotalBytesToReceive);
        }

        static void wc_DownloadFileCompleted(object sender,
                            System.ComponentModel.AsyncCompletedEventArgs e)
        {
            Console.WriteLine("ダウンロード完了");
        }

        //14-18(ストリームとしてダウンロード)
        public void OpenReadSample()
        {
            var wc = new WebClient();
            using (var stream = wc.OpenRead(@"https://yahoo.co.jp/"))
            using (var sr = new StreamReader(stream, Encoding.UTF8))
            {
                string html = sr.ReadToEnd();
                    Console.WriteLine(html);

            }
        }

        #endregion


        //リスト14-19
        private static IEnumerable<string> GetWeatherReportFromYahoo(int cityCode)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes)
                {
                    string s = Regex.Replace(node.Value, "[|]| - Yahoo!天気・災害", "");
                    yield return s;
                }
            }
        }

    }
}
