namespace CSharp_FormSakusei2
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnCheckWord = new System.Windows.Forms.Button();
            this.lblWordResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(63, 64);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(100, 22);
            this.txtWord.TabIndex = 0;
            // 
            // btnCheckWord
            // 
            this.btnCheckWord.Location = new System.Drawing.Point(63, 131);
            this.btnCheckWord.Name = "btnCheckWord";
            this.btnCheckWord.Size = new System.Drawing.Size(75, 23);
            this.btnCheckWord.TabIndex = 1;
            this.btnCheckWord.Text = "判定";
            this.btnCheckWord.UseVisualStyleBackColor = true;
            this.btnCheckWord.Click += new System.EventHandler(this.btnCheckWord_Click);
            // 
            // lblWordResult
            // 
            this.lblWordResult.AutoSize = true;
            this.lblWordResult.Location = new System.Drawing.Point(60, 206);
            this.lblWordResult.Name = "lblWordResult";
            this.lblWordResult.Size = new System.Drawing.Size(37, 15);
            this.lblWordResult.TabIndex = 2;
            this.lblWordResult.Text = "結果";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWordResult);
            this.Controls.Add(this.btnCheckWord);
            this.Controls.Add(this.txtWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnCheckWord;
        private System.Windows.Forms.Label lblWordResult;
    }
}

