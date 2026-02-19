namespace CSharp_Form_Program
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblFileSelect = new System.Windows.Forms.Label();
            this.txtBoxFilePath = new System.Windows.Forms.TextBox();
            this.lblFileContentTitle = new System.Windows.Forms.Label();
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnPushTop = new System.Windows.Forms.Button();
            this.groupBoxReturn = new System.Windows.Forms.GroupBox();
            this.panelBack = new System.Windows.Forms.Panel();
            this.lblFileContent = new System.Windows.Forms.Label();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnFileUpdate = new System.Windows.Forms.Button();
            this.btnPushBottm = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.panelBackGround = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gradientLabel1 = new GradientLabel();
            this.lblF2rec = new System.Windows.Forms.Label();
            this.groupBoxReturn.SuspendLayout();
            this.panelBack.SuspendLayout();
            this.panelBackGround.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFileSelect
            // 
            this.lblFileSelect.AutoSize = true;
            this.lblFileSelect.Location = new System.Drawing.Point(34, 40);
            this.lblFileSelect.Name = "lblFileSelect";
            this.lblFileSelect.Size = new System.Drawing.Size(87, 15);
            this.lblFileSelect.TabIndex = 0;
            this.lblFileSelect.Text = "ファイル選択：";
            // 
            // txtBoxFilePath
            // 
            this.txtBoxFilePath.Location = new System.Drawing.Point(104, 13);
            this.txtBoxFilePath.Name = "txtBoxFilePath";
            this.txtBoxFilePath.Size = new System.Drawing.Size(290, 22);
            this.txtBoxFilePath.TabIndex = 1;
            // 
            // lblFileContentTitle
            // 
            this.lblFileContentTitle.AutoSize = true;
            this.lblFileContentTitle.Location = new System.Drawing.Point(34, 71);
            this.lblFileContentTitle.Name = "lblFileContentTitle";
            this.lblFileContentTitle.Size = new System.Drawing.Size(87, 15);
            this.lblFileContentTitle.TabIndex = 2;
            this.lblFileContentTitle.Text = "ファイル内容：";
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.BackColor = System.Drawing.Color.Yellow;
            this.btnFileSelect.Location = new System.Drawing.Point(477, 35);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(107, 23);
            this.btnFileSelect.TabIndex = 3;
            this.btnFileSelect.Text = "ファイル選択";
            this.btnFileSelect.UseVisualStyleBackColor = false;
            this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Yellow;
            this.btnDisplay.Location = new System.Drawing.Point(477, 70);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(107, 23);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "表示";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnPushTop
            // 
            this.btnPushTop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPushTop.Location = new System.Drawing.Point(477, 136);
            this.btnPushTop.Name = "btnPushTop";
            this.btnPushTop.Size = new System.Drawing.Size(107, 23);
            this.btnPushTop.TabIndex = 5;
            this.btnPushTop.Text = "PUSH";
            this.btnPushTop.UseVisualStyleBackColor = false;
            this.btnPushTop.Click += new System.EventHandler(this.btnPushTop_Click);
            // 
            // groupBoxReturn
            // 
            this.groupBoxReturn.Controls.Add(this.panelBack);
            this.groupBoxReturn.Location = new System.Drawing.Point(37, 199);
            this.groupBoxReturn.Name = "groupBoxReturn";
            this.groupBoxReturn.Size = new System.Drawing.Size(362, 105);
            this.groupBoxReturn.TabIndex = 6;
            this.groupBoxReturn.TabStop = false;
            this.groupBoxReturn.Text = "返却値";
            // 
            // panelBack
            // 
            this.panelBack.Controls.Add(this.lblF2rec);
            this.panelBack.Location = new System.Drawing.Point(23, 43);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(323, 30);
            this.panelBack.TabIndex = 0;
            // 
            // lblFileContent
            // 
            this.lblFileContent.Location = new System.Drawing.Point(101, 48);
            this.lblFileContent.Name = "lblFileContent";
            this.lblFileContent.Size = new System.Drawing.Size(242, 23);
            this.lblFileContent.TabIndex = 7;
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(477, 198);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(107, 23);
            this.btnYellow.TabIndex = 8;
            this.btnYellow.Text = "Yellow";
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Yellow;
            this.btnGreen.Location = new System.Drawing.Point(477, 241);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(107, 23);
            this.btnGreen.TabIndex = 9;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Yellow;
            this.btnBlue.Location = new System.Drawing.Point(477, 280);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(107, 23);
            this.btnBlue.TabIndex = 10;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnFileUpdate
            // 
            this.btnFileUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnFileUpdate.Location = new System.Drawing.Point(477, 319);
            this.btnFileUpdate.Name = "btnFileUpdate";
            this.btnFileUpdate.Size = new System.Drawing.Size(107, 23);
            this.btnFileUpdate.TabIndex = 11;
            this.btnFileUpdate.Text = "ファイル更新";
            this.btnFileUpdate.UseVisualStyleBackColor = false;
            this.btnFileUpdate.Click += new System.EventHandler(this.btnFileUpdate_Click);
            // 
            // btnPushBottm
            // 
            this.btnPushBottm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPushBottm.Location = new System.Drawing.Point(477, 368);
            this.btnPushBottm.Name = "btnPushBottm";
            this.btnPushBottm.Size = new System.Drawing.Size(107, 23);
            this.btnPushBottm.TabIndex = 12;
            this.btnPushBottm.Text = "PUSH";
            this.btnPushBottm.UseVisualStyleBackColor = false;
            this.btnPushBottm.Click += new System.EventHandler(this.btnPushBottm_Click);
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // panelBackGround
            // 
            this.panelBackGround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelBackGround.Controls.Add(this.txtBoxFilePath);
            this.panelBackGround.Controls.Add(this.lblFileContent);
            this.panelBackGround.Location = new System.Drawing.Point(26, 23);
            this.panelBackGround.Name = "panelBackGround";
            this.panelBackGround.Size = new System.Drawing.Size(576, 152);
            this.panelBackGround.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.EndColor = System.Drawing.Color.LightSkyBlue;
            this.gradientLabel1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gradientLabel1.ForeColor = System.Drawing.Color.White;
            this.gradientLabel1.Location = new System.Drawing.Point(50, 320);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(280, 81);
            this.gradientLabel1.StartColor = System.Drawing.Color.DarkBlue;
            this.gradientLabel1.TabIndex = 15;
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblF2rec
            // 
            this.lblF2rec.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblF2rec.Location = new System.Drawing.Point(3, 0);
            this.lblF2rec.Name = "lblF2rec";
            this.lblF2rec.Size = new System.Drawing.Size(320, 30);
            this.lblF2rec.TabIndex = 0;
            this.lblF2rec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.gradientLabel1);
            this.Controls.Add(this.btnPushBottm);
            this.Controls.Add(this.btnFileUpdate);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.groupBoxReturn);
            this.Controls.Add(this.btnPushTop);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnFileSelect);
            this.Controls.Add(this.lblFileContentTitle);
            this.Controls.Add(this.lblFileSelect);
            this.Controls.Add(this.panelBackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form①";
            this.groupBoxReturn.ResumeLayout(false);
            this.panelBack.ResumeLayout(false);
            this.panelBackGround.ResumeLayout(false);
            this.panelBackGround.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileSelect;
        private System.Windows.Forms.TextBox txtBoxFilePath;
        private System.Windows.Forms.Label lblFileContentTitle;
        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnPushTop;
        private System.Windows.Forms.GroupBox groupBoxReturn;
        private System.Windows.Forms.Label lblFileContent;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnFileUpdate;
        private System.Windows.Forms.Button btnPushBottm;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Panel panelBackGround;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private GradientLabel gradientLabel1;
        private System.Windows.Forms.Label lblF2rec;
    }
}

