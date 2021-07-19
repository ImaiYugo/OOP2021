
namespace Exercise {
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btOppen = new System.Windows.Forms.Button();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btReadAllLines = new System.Windows.Forms.Button();
            this.btReadLine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(12, 64);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(620, 315);
            this.tbOutput.TabIndex = 0;
            // 
            // btOppen
            // 
            this.btOppen.Location = new System.Drawing.Point(33, 19);
            this.btOppen.Name = "btOppen";
            this.btOppen.Size = new System.Drawing.Size(71, 39);
            this.btOppen.TabIndex = 1;
            this.btOppen.Text = "開く...";
            this.btOppen.UseVisualStyleBackColor = true;
            this.btOppen.Click += new System.EventHandler(this.btOppen_Click);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(110, 39);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(103, 19);
            this.tbKey.TabIndex = 2;
            // 
            // btReadAllLines
            // 
            this.btReadAllLines.Location = new System.Drawing.Point(233, 19);
            this.btReadAllLines.Name = "btReadAllLines";
            this.btReadAllLines.Size = new System.Drawing.Size(88, 38);
            this.btReadAllLines.TabIndex = 3;
            this.btReadAllLines.Text = "ReadAllLines";
            this.btReadAllLines.UseVisualStyleBackColor = true;
            this.btReadAllLines.Click += new System.EventHandler(this.btReadAllLines_Click);
            // 
            // btReadLine
            // 
            this.btReadLine.Location = new System.Drawing.Point(348, 19);
            this.btReadLine.Name = "btReadLine";
            this.btReadLine.Size = new System.Drawing.Size(88, 38);
            this.btReadLine.TabIndex = 3;
            this.btReadLine.Text = "ReadLines";
            this.btReadLine.UseVisualStyleBackColor = true;
            this.btReadLine.Click += new System.EventHandler(this.btReadLine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 391);
            this.Controls.Add(this.btReadLine);
            this.Controls.Add(this.btReadAllLines);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.btOppen);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btOppen;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Button btReadAllLines;
        private System.Windows.Forms.Button btReadLine;
    }
}

