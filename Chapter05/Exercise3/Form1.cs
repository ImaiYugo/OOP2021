using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class form1 : Form {
        public form1() {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e) {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";
            InputText.Text = "NoveList=谷崎潤一郎;BestWork=春琴抄;Born=1886;";
        }

        private void Button5_3_1_Click(object sender, EventArgs e) {
            var count = inputStrText.Text.Count(c => c == ' ');
            TextBox5_3_1.Text = "空白の数:"+count.ToString();
        }

        private void Button5_3_2_Click(object sender, EventArgs e) {
            TextBox5_3_2.Text = inputStrText.Text.Replace("big", "small");
        }

        private void Button5_3_3_Click(object sender, EventArgs e) {
            //string[] words = inputStrText.Text.Split(' ');
            //TextBox5_3_3.Text = "単語の数:"+words.Count().ToString();
            TextBox5_3_3.Text = inputStrText.Text.Split(' ').Length.ToString();
        }

        private void Button5_3_4_Click(object sender, EventArgs e) {
            string[] words = inputStrText.Text.Split(' ');
            var yonmoji = words.Where(s => s.Length <= 4);
            foreach (var n in yonmoji) {
                TextBox5_3_4.Text += n + " ";
            }
        }

        private void Button5_3_5_Click(object sender, EventArgs e) {
            var array = inputStrText.Text.Split(' ').ToArray();
            var sb = new StringBuilder();
            foreach (var i in array) {
                sb.Append(i).Append(" ");
            }
            TextBox5_3_5.Text = sb.ToString();
        }

        private void Button5_4_Click(object sender, EventArgs e) {
            //var delete = TextBox5_4.Text.IndexOf("=");
            //TextBox5_4.Text = TextBox5_4.Text.Replace("NoveList=", "作　 家:");
            //TextBox5_4.Text = TextBox5_4.Text.Replace("BestWork=", "代表作:");
            //TextBox5_4.Text = TextBox5_4.Text.Replace("Born=","誕生年:");
            //var num = TextBox5_4.Text.Split(';');
            //TextBox5_4.Text = num[0] + Environment.NewLine +num[1] + Environment.NewLine + num[2];

            foreach (var pair in InputText.Text.Split(';')) {
                var array = pair.Split('=');
                TextBox5_4.Text += ToJapanese(array[0]) + ":" + array[1] + Environment.NewLine;
            }       

        }
        private string ToJapanese(string key) {
            switch(key){
                case "NoveList":
                    return "作家 ";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生年";
            }
            throw new ArgumentException("引数が正しくありません");
        }
    }
}