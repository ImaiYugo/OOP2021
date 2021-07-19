using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2 {
    public partial class Form1 : Form {
        string inputPath = "";  //変換元ファイル
        string outputPath = ""; //変換先ファイル
        public Form1() {
            InitializeComponent();
        }

        //変換元のファイルを指定
        private void btOppen_Click(object sender, EventArgs e) {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                inputPath = ofdOpenFile.FileName;
            }
        }

        //変換したファイルの保存先を決定
        private void btChangeFile_Click(object sender, EventArgs e) {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                outputPath = ofdOpenFile.FileName;
            }
        }

        //行番号を追加する
        private void btChange_Click(object sender, EventArgs e) {
            var lines = File.ReadLines(inputPath).Select((s, n) => string.Format("{0,4}: {1}",n+1,s)).ToArray();
            File.WriteAllLines(outputPath,lines);
        }

        private void btA_Click(object sender, EventArgs e) {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                    inputPath = ofdOpenFile.FileName;                
            }
        }

        private void btB_Click(object sender, EventArgs e) {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                outputPath = ofdOpenFile.FileName;
            }
        }

        private void btAdd_Click(object sender, EventArgs e) {
            aa
        }
    }
}
