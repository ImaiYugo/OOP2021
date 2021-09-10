using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader
{
    public partial class Form1 : Form
    {
        IEnumerable<ItemData> items = null;
        List<string> link = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }
        

        private void btRead_Click(object sender, EventArgs e)
        {
            setRssTitle(tbUrl.Text);
        }

        private void setRssTitle(string uri)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var url = new Uri(uri);
                var stream = wc.OpenRead(url);
                XDocument xdoc = XDocument.Load(stream);

                items = xdoc.Root.Descendants("item").Select(x => new ItemData
                {
                    Title = (string)x.Element("title"),
                    Link = (string)x.Element("link"),
                    PubDate = (DateTime)x.Element("pubDate"),
                    Description = (string)x.Element("Description")

                });

                foreach (var item in items)
                {
                    lbTitles.Items.Add(item.Title);
                }

                //var Link = xdoc.Root.Descendants("link");
                //var nodes = xdoc.Root.Descendants("title");
                //foreach (var l in Link)
                //{
                //    link.Add(l.Value);
                //}
                //foreach (var node in nodes)
                //{
                //    lbTitles.Items.Add(node.Value);

                //}
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/top-picks.xml";

        }

        private void lbTitles_Click(object sender, EventArgs e)
        {
            //wbBrowser.Url = new Uri(link[lbTitles.SelectedIndex]);
            string link = (items.ToArray())[lbTitles.SelectedIndex].Link;   //配列へ変換して[]でアクセス
            wbBrowser.Url = new Uri(link);

            
        }

        
    }
}