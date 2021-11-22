using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelmanism
{
    public partial class FormGame : Form
    {
        private Card[] playingCards;    //遊ぶカードの束
        private Player player;          //プレイヤー
        private int gameSec;            //ゲーム時間


        public FormGame() {
            InitializeComponent();
        }

        /// <summary>
        /// カードの生成
        /// </summary>
        /// <param name="cards"></param>カード配列への参照
        private void CreateCards(ref Card[] cards) {
            string[] picture =
            {
                "〇","●","△","▲","□","■","◇","◆","☆","★","※","×",
            };
            //カードのインスタンスの作成
            cards = new Card[picture.Length * 2];
            for (int i = 0, j = 0; i < cards.Length; i+=2,j++) {
                cards[i] = new Card(picture[j]);
                cards[i + 1] = new Card(picture[j]);
            }
        }

        private void FormGame_Load(object sender, EventArgs e) {
            //カードの生成
            CreateCards(ref playingCards);
            //プレイヤーの生成
            player = new Player();

            //カードをフォームに動的に配置する
            SuspendLayout();

            const int offsetX = 30, offsetY = 50;
            for (int i = 0; i < playingCards.Length; i++) {
                //カード(ボタン)のプロパティを設定する
                playingCards[i].Name = "card" + i;
                int sizeW = playingCards[i].Size.Width;
                int sizeH = playingCards[i].Size.Height;
                playingCards[i].Location = new Point(offsetX + i % 8 * sizeW,
                                                        offsetY + i / 8 * sizeH);

                playingCards[i].Click += CardsButtons_Click;
            }
            Controls.AddRange(playingCards);
            ResumeLayout(false);
            labelGuidance.Text = "スタートボタンをクリックしてゲームを開始してください";
        }

        private void CardsButtons_Click(object sender, EventArgs e) {
            //めくるのは1枚目か?
            if (player.OpenCounter == 0) {
                //前回のカードが不一致ならカードを伏せる
                int b1 = player.BeforeOpenCardIndex1;
                int b2 = player.BeforeOpenCardIndex2;
                if (b1 != -1 && b2 != -1 && !MatchCard(playingCards,b1,b2)) {
                    playingCards[b1].Close();
                    playingCards[b2].Close();
                }

                //クリックしたボタンのNameからカードの添え字を取得する
                int n1 = int.Parse(((Button)sender).Name.Substring(4));
                //1枚目のカードを開く
                playingCards[n1].Open();
                player.NowOpenCardIndex1 = n1;  //開いたカードの添え字を格納

                labelGuidance.Text = "もう1枚めくってください";
            }else if(player.OpenCounter == 1) {
                //クリックしたボタンのNameからカードの添え字を取得する
                int n2 = int.Parse(((Button)sender).Name.Substring(4));
                //2枚目のカードを開く
                playingCards[n2].Open();
                player.NowOpenCardIndex2 = n2;  //開いたカードの添え字を格納

                //1枚目と2枚目のカードは一致したか?
                if (MatchCard(playingCards, player.NowOpenCardIndex1, player.NowOpenCardIndex2)) {
                    labelGuidance.Text = "カードが一致しました。次のカードをめくってください";
                } else {
                    labelGuidance.Text = "カードが不一致です。次のカードをめくってください";                   
                }
                //プレイヤーのカード情報をリセットする
                player.Reset();

                //全カードをめくったか
                if (AllOpenCard(playingCards)) {
                    labelGuidance.Text = "全部のカードが一致しました。お疲れさまでした";
                    timer1.Stop();
                    buttonStart.Enabled = true; //スタートボタン選択可
                }
            }
        }

        /// <summary>
        /// カードが全部開いたかチェック
        /// </summary>
        /// <param name="playingCards"></param>
        /// <returns> true:全部表　false:１枚以上の裏のカードがある</returns>
        private bool AllOpenCard(Card[] playingCards) {
            foreach (Card card in playingCards) {
                if (!card.State)
                    return false;
            }
            return true;
        }


        /// <summary>
        /// カードの一致チェック
        /// </summary>
        /// <param name="playingCards">カードの配列</param>
        /// <param name="nowOpenCardIndex1">1枚目にめくったカードの添え字</param>
        /// <param name="nowOpenCardIndex2">2枚目にめくったカードの添え字</param>
        /// <returns>true:一致 false:不一致　</returns>
        private bool MatchCard(Card[] cards, int index1, int index2) {
            if (index1 < 0 || index1 >= cards.Length||
                index2 < 0 || index2 >= cards.Length)
                return false;
            if (cards[index1].Picture.Equals(cards[index2].Picture)) {
                return true;
            }
            else {
                return false;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e) {
            //カードを混ぜる
            ShuffleCard(playingCards);

            //全部のカードを伏せる
            foreach (var card in playingCards) {
                card.Close();
            }
            buttonStart.Enabled = false; //スタートボタン選択不可
            gameSec = 100;
            timer1.Start();

            labelGuidance.Text = "クリックしてカードをめくってください";
        }

        /// <summary>
        /// シャッフル
        /// </summary>
        /// <param name="playingCards"></param>
        private void ShuffleCard(Card[] playingCards) {
            Random random = new Random();
            int n = playingCards.Length - 1;
            while (n > 0) {
                int r = random.Next(0, n);
                string tmp = playingCards[n].Picture;
                playingCards[n].Picture = playingCards[r].Picture;
                playingCards[r].Picture = tmp;
                n--;
            }
    }

        private void timer1_Tick(object sender, EventArgs e) {
            gameSec--;
            labelSec.Text = "残り" + gameSec + "秒";
            if (gameSec == 0) {
                timer1.Stop();
                foreach (var card in playingCards) {
                    card.Open();
                    buttonStart.Enabled = true;
                    labelGuidance.Text = "失敗!もう一度挑戦してください";
                }
            }
        }
    }
}
