using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {


    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public static int GetAge(DateTime birthday, DateTime today) {
            var age = today.Year - birthday.Year;
            if (today < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }

        private void btAction_Click(object sender, EventArgs e) {
            //var today = DateTime.Today;
            var today = new DateTime((int)nudYear.Value,(int)nudMonth.Value,(int)nudDay.Value);
            DayOfWeek dayOfweek = today.DayOfWeek;
            string dow = " ";

            switch (dayOfweek) {
                case DayOfWeek.Sunday:
                    dow = "日";
                    break;
                case DayOfWeek.Monday:
                    dow = "月";
                    break;
                case DayOfWeek.Tuesday:
                    dow = "火";
                    break;
                case DayOfWeek.Wednesday:
                    dow = "水";
                    break;
                case DayOfWeek.Thursday:
                    dow = "木";
                    break;
                case DayOfWeek.Friday:
                    dow = "金";
                    break;
                case DayOfWeek.Saturday:
                    dow = "土";
                    break;
            }
            tbOutput.Text = dow + "曜日です";

            var isLeapYear = DateTime.IsLeapYear(today.Year);
            if (isLeapYear)
                tbLeapYear.Text = "閏年です";
            else
                tbLeapYear.Text = "閏年ではありません";

            //tbOutput.Text = DateTime.Today.DayOfYear.ToString();
            TimeSpan diff = DateTime.Today - today.Date;
            tbOutput.Text = diff.Days+"日間";
        }

        private void BtAge_Click(object sender, EventArgs e) {
            var birthday = new DateTime(2000, 8, 11);
            var today = DateTime.Today;
            tbAge.Text = GetAge(birthday, today).ToString();
        }
    }
}
