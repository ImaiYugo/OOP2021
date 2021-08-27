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
            Exercise01_1(file);
            Console.WriteLine("-------");
            Exercise01_2(file);
            Console.WriteLine("-------");
            Exercise01_3(file);
            Console.WriteLine("-------");

        }

        private static void Exercise01_1(string file)
        {
            var xdoc = XDocument.Load(file);
            foreach (var xnovelist in xdoc.Root.Elements())
            {
                var xname = xnovelist.Element("name");
                var xno = xnovelist.Element("teammembers");
                Console.WriteLine("{0},{1}", xname.Value, xno.Value);
            }
        }

        private static void Exercise01_2(string file)
        {
            var xdoc = XDocument.Load(file);
            var xnovelists = xdoc.Root.Elements()
                                 .OrderBy(x => x.Element("firstplayed"));

            foreach (var xnovelist in xnovelists)
            {
                var xname = xnovelist.Element("name kanji");
                Console.WriteLine("{0}",xname);
            }
        }

        private static void Exercise01_3(string file)
        {
            var xdoc = XDocument.Load(file);
        }
    }
}
