using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test3
{
    public partial class AcessForm : Form
    {
        private string passName = "0000";
        private string passWord = "0000";

        public AcessForm() {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.DesktopLocation = new Point(235, 290);
            this.ActiveControl = this.tbName;
        }

        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btOk_Click(object sender, EventArgs e) {
            if(tbName.Text == passName && tbPass.Text == passWord) {

            }
        }
    }
}
