using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        
        private void btToday_Click(object sender, EventArgs e) {
            var today = DateTime.Now;

            tbDD.Text = string.Format("{0:yyyy/M/d HH:mm}", today) + "\r\n";
            tbDD.Text += today.ToString("yyyy年MM年dd日 HH時mm分ss秒") + "\r\n";

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            var datestr = today.ToString("ggyy", culture);
            var dayOfWeek = culture.DateTimeFormat.GetDayName(today.DayOfWeek);

            tbDD.Text += string.Format("{0}年{1,2}月{2,2}日({3})", datestr, today.Month, today.Day, dayOfWeek);
            //tbDD.Text = today.ToString("d");
        }

        private void Form1_Load(object sender, EventArgs e) {
            //Timer tm = new Timer(); コントロールで追加したので不要
            tm.Tick += Tm_Tick;
            tm.Interval = 500;
            tm.Start();
            tssTimeLabel.Text = DateTime.Now.ToString();
        }
        //タイマーが切れたときに呼ばれるイベントハンドラ
        private void Tm_Tick(object sender, EventArgs e) {
            tssTimeLabel.Text = DateTime.Now.ToString();
        }
    }
}
