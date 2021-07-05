
namespace Exercise1 {
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
            this.btAction = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.nudDay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLeapYear = new System.Windows.Forms.TextBox();
            this.BtAge = new System.Windows.Forms.Button();
            this.tbAge = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            this.SuspendLayout();
            // 
            // btAction
            // 
            this.btAction.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAction.Location = new System.Drawing.Point(371, 147);
            this.btAction.Name = "btAction";
            this.btAction.Size = new System.Drawing.Size(85, 31);
            this.btAction.TabIndex = 0;
            this.btAction.Text = "実行";
            this.btAction.UseVisualStyleBackColor = true;
            this.btAction.Click += new System.EventHandler(this.btAction_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbOutput.Location = new System.Drawing.Point(25, 110);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(337, 31);
            this.tbOutput.TabIndex = 1;
            // 
            // nudYear
            // 
            this.nudYear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudYear.Location = new System.Drawing.Point(12, 12);
            this.nudYear.Maximum = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(104, 31);
            this.nudYear.TabIndex = 2;
            this.nudYear.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // nudMonth
            // 
            this.nudMonth.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudMonth.Location = new System.Drawing.Point(162, 12);
            this.nudMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonth.Name = "nudMonth";
            this.nudMonth.Size = new System.Drawing.Size(104, 31);
            this.nudMonth.TabIndex = 2;
            this.nudMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDay
            // 
            this.nudDay.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudDay.Location = new System.Drawing.Point(312, 14);
            this.nudDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDay.Name = "nudDay";
            this.nudDay.Size = new System.Drawing.Size(104, 31);
            this.nudDay.TabIndex = 2;
            this.nudDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(122, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(272, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(422, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "日";
            // 
            // tbLeapYear
            // 
            this.tbLeapYear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbLeapYear.Location = new System.Drawing.Point(25, 147);
            this.tbLeapYear.Name = "tbLeapYear";
            this.tbLeapYear.Size = new System.Drawing.Size(337, 31);
            this.tbLeapYear.TabIndex = 1;
            // 
            // BtAge
            // 
            this.BtAge.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtAge.Location = new System.Drawing.Point(371, 213);
            this.BtAge.Name = "BtAge";
            this.BtAge.Size = new System.Drawing.Size(85, 31);
            this.BtAge.TabIndex = 0;
            this.BtAge.Text = "実行";
            this.BtAge.UseVisualStyleBackColor = true;
            this.BtAge.Click += new System.EventHandler(this.BtAge_Click);
            // 
            // tbAge
            // 
            this.tbAge.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAge.Location = new System.Drawing.Point(25, 213);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(337, 31);
            this.tbAge.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudDay);
            this.Controls.Add(this.nudMonth);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbLeapYear);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.BtAge);
            this.Controls.Add(this.btAction);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAction;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.NumericUpDown nudMonth;
        private System.Windows.Forms.NumericUpDown nudDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLeapYear;
        private System.Windows.Forms.Button BtAge;
        private System.Windows.Forms.TextBox tbAge;
    }
}

