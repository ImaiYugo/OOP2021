
namespace RssReader
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wbTwo = new System.Windows.Forms.WebBrowser();
            this.btBack = new System.Windows.Forms.Button();
            this.btFoward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wbTwo
            // 
            this.wbTwo.Location = new System.Drawing.Point(12, 58);
            this.wbTwo.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbTwo.Name = "wbTwo";
            this.wbTwo.ScriptErrorsSuppressed = true;
            this.wbTwo.Size = new System.Drawing.Size(776, 394);
            this.wbTwo.TabIndex = 0;
            this.wbTwo.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbTwo_DocumentCompleted);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(12, 12);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(87, 40);
            this.btBack.TabIndex = 1;
            this.btBack.Text = "戻る";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btFoward
            // 
            this.btFoward.Location = new System.Drawing.Point(105, 12);
            this.btFoward.Name = "btFoward";
            this.btFoward.Size = new System.Drawing.Size(87, 40);
            this.btFoward.TabIndex = 1;
            this.btFoward.Text = "進む";
            this.btFoward.UseVisualStyleBackColor = true;
            this.btFoward.Click += new System.EventHandler(this.btFoward_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btFoward);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.wbTwo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btFoward;
        public System.Windows.Forms.WebBrowser wbTwo;
    }
}