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

        Dictionary<string, int> AreaDic = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
        }
        List<string> link = new List<string>();

        private void btRead_Click(object sender, EventArgs e)
        {
            setRssTitle(tbUrl.Text);
        }

        private void setRssTitle(string uri)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var stream = wc.OpenRead(uri);
                XDocument xdoc = XDocument.Load(tbUrl.Text);
                var nodes = xdoc.Root.Descendants("title");
                var Link = xdoc.Root.Descendants("link");
                foreach (var l in Link)
                {
                    link.Add(l.Value);
                }
                foreach (var node in nodes)
                {
                    lbTitles.Items.Add(node.Value);

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/top-picks.xml";
            
        }

        private void lbTitles_Click(object sender, EventArgs e)
        {
            //未完成
            wbBrowser.Url = new Uri(link[lbTitles.SelectedIndex]);
        }
    }
}
