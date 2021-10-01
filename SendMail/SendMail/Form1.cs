﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail
{
    public partial class Form1 : Form
    {
        //設定画面
        private ConfigForm configForm = new ConfigForm();
     
        //設定情報
        private Settings settings = Settings.getInstance();

        public Form1()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                //メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress(configForm.settings.MailAddr);
                //宛先（To）
                mailMessage.To.Add(tbTo.Text);
                mailMessage.CC.Add(tbCc.Text);
                mailMessage.Bcc.Add(tbBcc.Text);

                //件名（タイトル）
                mailMessage.Subject = tbTitle.Text;
                //本文
                mailMessage.Body = tbMessage.Text;

                //SMTPを使ってメールを送信する
                SmtpClient smtpClient = new SmtpClient();
                //メール送信のための認証情報を設定（ユーザー名、パスワード）
                smtpClient.Credentials
                    = new NetworkCredential(configForm.settings.MailAddr, configForm.settings.Pass);
                smtpClient.Host = configForm.settings.Host;
                smtpClient.Port = configForm.settings.Port;
                smtpClient.EnableSsl = configForm.settings.Ssl;
                smtpClient.SendAsync(mailMessage,"");

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("送信完了");
        }

        private void btConfig_Click(object sender, EventArgs e) {
            configForm.ShowDialog();
        }
    }
}
