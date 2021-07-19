
namespace Exercise2 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btChangeFile = new System.Windows.Forms.Button();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveFile = new System.Windows.Forms.OpenFileDialog();
            this.btChange = new System.Windows.Forms.Button();
            this.btOppen = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btA = new System.Windows.Forms.Button();
            this.btB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btChangeFile
            // 
            this.btChangeFile.Location = new System.Drawing.Point(114, 21);
            this.btChangeFile.Name = "btChangeFile";
            this.btChangeFile.Size = new System.Drawing.Size(91, 28);
            this.btChangeFile.TabIndex = 1;
            this.btChangeFile.Text = "変換先";
            this.btChangeFile.UseVisualStyleBackColor = true;
            this.btChangeFile.Click += new System.EventHandler(this.btChangeFile_Click);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // sfdSaveFile
            // 
            this.sfdSaveFile.FileName = "openFileDialog1";
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(224, 21);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(91, 28);
            this.btChange.TabIndex = 1;
            this.btChange.Text = "行番号を振る";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // btOppen
            // 
            this.btOppen.Location = new System.Drawing.Point(12, 21);
            this.btOppen.Name = "btOppen";
            this.btOppen.Size = new System.Drawing.Size(91, 28);
            this.btOppen.TabIndex = 1;
            this.btOppen.Text = "開く";
            this.btOppen.UseVisualStyleBackColor = true;
            this.btOppen.Click += new System.EventHandler(this.btOppen_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(322, 23);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(101, 25);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "末尾に追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(536, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btA
            // 
            this.btA.Location = new System.Drawing.Point(322, 54);
            this.btA.Name = "btA";
            this.btA.Size = new System.Drawing.Size(101, 25);
            this.btA.TabIndex = 2;
            this.btA.Text = "A選択";
            this.btA.UseVisualStyleBackColor = true;
            this.btA.Click += new System.EventHandler(this.btA_Click);
            // 
            // btB
            // 
            this.btB.Location = new System.Drawing.Point(322, 85);
            this.btB.Name = "btB";
            this.btB.Size = new System.Drawing.Size(101, 25);
            this.btB.TabIndex = 2;
            this.btB.Text = "B選択";
            this.btB.UseVisualStyleBackColor = true;
            this.btB.Click += new System.EventHandler(this.btB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btB);
            this.Controls.Add(this.btA);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btOppen);
            this.Controls.Add(this.btChangeFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btChangeFile;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.OpenFileDialog sfdSaveFile;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btOppen;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btA;
        private System.Windows.Forms.Button btB;
    }
}

