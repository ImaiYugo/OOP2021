using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public fmMain() {
            InitializeComponent();
            dgvRegistData.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit(); //アプリケーション終了
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btDataAdd_Click(object sender, EventArgs e) {
            if (cbAuther.Text == "" || cbCarName.Text == "") {
                MessageBox.Show("入力されていません");
                return;
            } else {
                CarReport carReport = new CarReport {
                    Date = dtpDate.Value,
                    Auther = cbAuther.Text,
                    Maker = selectedGroup(),
                    CarName = cbCarName.Text,
                    Report = tbReport.Text,
                    Picture = pbPicture.Image
                };
                listCarReport.Add(carReport);
                setCbAuthor(cbAuther.Text);
                setCbCarName(cbCarName.Text);
            }
        }

        private CarReport.MakerGroup selectedGroup() {
            foreach (var g in gbMaker.Controls) {
                if (((RadioButton)g).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)g).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
        }
        //コンボボックスに記録者をセットする
        private void setCbAuthor(string auther) {
            if (!cbAuther.Items.Contains(auther)) {
                cbAuther.Items.Add(auther);
            }

        }
        //コンボボックスに車名をセットする
        private void setCbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName)) {
                cbCarName.Items.Add(carName);
            }
        }

        private void dgvRegistData_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1)
                return;

            CarReport selectCar = listCarReport[e.RowIndex];

            //取得したデータ項目を各コントロールへ設定
            dtpDate.Value = selectCar.Date;
            cbAuther.Text = selectCar.Auther;
            setMakerRadioButton(selectCar.Maker);
            cbCarName.Text = selectCar.CarName;
            tbReport.Text = selectCar.Report;
            pbPicture.Image = selectCar.Picture;            
        }


        private void setMakerRadioButton(CarReport.MakerGroup mg) {
            switch (mg) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rbImport.Checked = true;
                    break;                   
                default:
                    rbOther.Checked = true;
                    break;
            }
        }


        private void btDataDelete_Click(object sender, EventArgs e) {
            listCarReport.RemoveAt(dgvRegistData.CurrentRow.Index);
        }

        private void btDataCorrect_Click(object sender, EventArgs e) {
            listCarReport[dgvRegistData.CurrentRow.Index].UpDate (
                dtpDate.Value,cbAuther.Text,selectedGroup(),
                cbCarName.Text,tbReport.Text,pbPicture.Image );
        }
    }
}
