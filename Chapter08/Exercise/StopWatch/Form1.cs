using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch {
    public partial class Form1 : Form {
        Stopwatch sw = new Stopwatch();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //lbTD.Text = "00:00:00:00";
            lbTD.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            tmDisp.Tick += TmDisp_Tick; 
            tmDisp.Interval = 500;
            

        }

        private void startButton_Click(object sender, EventArgs e) {
            tmDisp.Start();
        }

        private void TmDisp_Tick(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        private void stopButton_Click(object sender, EventArgs e) {

        }

        private void resetButton_Click(object sender, EventArgs e) {

        }

        private void rapButton_Click(object sender, EventArgs e) {

        }
    }
}
