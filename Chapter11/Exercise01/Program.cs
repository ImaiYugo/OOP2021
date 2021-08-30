using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "Sample.xml";
            //Exercise01_1(file);
            //Console.WriteLine("-------");
            //Exercise01_2(file);
            //Console.WriteLine("-------");
            //Exercise01_3(file);
            //Console.WriteLine("-------");
            Exercise01_4(file);
            Console.WriteLine("-------");
        }

        

        private static void Exercise01_1(string file)
        {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                                  .Select(x => new
                                  {
                                      Name = x.Element("name").Value,
                                      Teammembers = x.Element("teammembers").Value
                                  });
            //foreach (var xnovelist in xdoc.Root.Elements())
            //{
            //    var xname = xnovelist.Element("name");
            //    var xno = xnovelist.Element("teammembers");
            //    Console.WriteLine("{0},{1}", xname.Value, xno.Value);
            //}
        }

        private static void Exercise01_2(string file)
        {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                                  .Select(x => new
                                  {
                                      Firstplayed = x.Element("firstplayed").Value,
                                      Name = x.Element("name").Attribute("kanji").Value
                                  }).OrderBy(x => int.Parse(x.Firstplayed));

            foreach (var sport in sports)
            {
                Console.WriteLine("{0} {1}", sport.Name, sport.Firstplayed);
            }
        }
 
        //    var xnovelists = xdoc.Root.Elements()
        //                         .OrderBy(x => x.Element("firstplayed"));

        //    foreach (var xnovelist in xnovelists)
        //    {
        //        var xname = xnovelist.Element("name kanji");
        //        Console.WriteLine("{0}",xname);
        //    }
        

        private static void Exercise01_3(string file)
        {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                                  .Select(x => new
                                  {
                                      Name = x.Element("name").Value,
                                      Teammembers = x.Element("teammembers").Value
                                  })
                                  .OrderByDescending(x => int.Parse(x.Teammembers))
                                  .First();

            Console.WriteLine("{0}", sports.Name);
        }

        private static void Exercise01_4(string file)
        {
            var newfile = "sports.xml";//出力する新しいファイル
            //p２９０ リスト11.15を参考にする
            var xdoc = XDocument.Load(file);
            var element = new XElement("ballsport",
                 new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                 new XElement("teammembers", "11"),
                 new XElement("firstplayed", "186")
              );
            xdoc.Root.Add(element);
        }
    }
}
