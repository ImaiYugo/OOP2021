
namespace StopWatch {
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
            this.components = new System.ComponentModel.Container();
            this.lbTD = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.rapButton = new System.Windows.Forms.Button();
            this.tmDisp = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbTD
            // 
            this.lbTD.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbTD.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTD.Location = new System.Drawing.Point(1, 19);
            this.lbTD.Name = "lbTD";
            this.lbTD.Size = new System.Drawing.Size(356, 67);
            this.lbTD.TabIndex = 0;
            this.lbTD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startButton.Location = new System.Drawing.Point(12, 106);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(175, 54);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "スタート";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.resetButton.Location = new System.Drawing.Point(193, 106);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(175, 54);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "リセット";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stopButton.Location = new System.Drawing.Point(12, 166);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(175, 54);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "ストップ";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // rapButton
            // 
            this.rapButton.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rapButton.Location = new System.Drawing.Point(193, 166);
            this.rapButton.Name = "rapButton";
            this.rapButton.Size = new System.Drawing.Size(175, 54);
            this.rapButton.TabIndex = 1;
            this.rapButton.Text = "ラップ+";
            this.rapButton.UseVisualStyleBackColor = true;
            this.rapButton.Click += new System.EventHandler(this.rapButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(549, 234);
            this.Controls.Add(this.rapButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.lbTD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTD;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button rapButton;
        private System.Windows.Forms.Timer tmDisp;
    }
}

