using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail
{
    public partial class ConfigForm : Form
    {
        public Settings settings = Settings.getInstance();


        public ConfigForm() {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, EventArgs e) {            
            tbHost.Text = settings.sHost();         //ホスト
            tbPort.Text = settings.sPort();         //ポート
            tbUserName.Text = settings.sMailAddr(); //ユーザー名
            tbPass.Text = settings.sPass();         //パスワード
            cbSsl.Checked = settings.bSsl();        //SSL
            tbSender.Text = settings.sMailAddr();   //送信元
        }

        private void btOk_Click(object sender, EventArgs e) {
            SettingRegist();
            this.Close();

        }

        private void btApply_Click(object sender, EventArgs e) {
            SettingRegist();
        }

        //送信データ登録
        private void SettingRegist() {
            settings.Host = tbHost.Text;
            settings.Port = int.Parse(tbPort.Text);
            settings.MailAddr = tbUserName.Text;
            settings.Pass = tbPass.Text;
            settings.Ssl = cbSsl.Checked;
        }

        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
        }        
    }
}
