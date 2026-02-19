namespace CSharp_Form_Program
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdobtnMon = new System.Windows.Forms.RadioButton();
            this.rdobtnTue = new System.Windows.Forms.RadioButton();
            this.rdobtnWed = new System.Windows.Forms.RadioButton();
            this.rdobtnThu = new System.Windows.Forms.RadioButton();
            this.rdobtnFri = new System.Windows.Forms.RadioButton();
            this.rdobtnSat = new System.Windows.Forms.RadioButton();
            this.rdobtnSun = new System.Windows.Forms.RadioButton();
            this.lblDays = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdobtnDays = new System.Windows.Forms.RadioButton();
            this.rdobtnYears = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDays2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkboxCombo = new System.Windows.Forms.CheckBox();
            this.chkboxRadio = new System.Windows.Forms.CheckBox();
            this.chkboxLbl = new System.Windows.Forms.CheckBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdobtnZoom = new System.Windows.Forms.RadioButton();
            this.rdobtnStretch = new System.Windows.Forms.RadioButton();
            this.rdobtnCenter = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.lblDays);
            this.panel1.Controls.Add(this.rdobtnSun);
            this.panel1.Controls.Add(this.rdobtnSat);
            this.panel1.Controls.Add(this.rdobtnFri);
            this.panel1.Controls.Add(this.rdobtnThu);
            this.panel1.Controls.Add(this.rdobtnWed);
            this.panel1.Controls.Add(this.rdobtnTue);
            this.panel1.Controls.Add(this.rdobtnMon);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 269);
            this.panel1.TabIndex = 0;
            // 
            // rdobtnMon
            // 
            this.rdobtnMon.AutoSize = true;
            this.rdobtnMon.Location = new System.Drawing.Point(14, 16);
            this.rdobtnMon.Name = "rdobtnMon";
            this.rdobtnMon.Size = new System.Drawing.Size(55, 19);
            this.rdobtnMon.TabIndex = 0;
            this.rdobtnMon.TabStop = true;
            this.rdobtnMon.Text = "Mon";
            this.rdobtnMon.UseVisualStyleBackColor = true;
            this.rdobtnMon.CheckedChanged += new System.EventHandler(this.radioDay_CheckedChanged);
            // 
            // rdobtnTue
            // 
            this.rdobtnTue.AutoSize = true;
            this.rdobtnTue.Location = new System.Drawing.Point(14, 50);
            this.rdobtnTue.Name = "rdobtnTue";
            this.rdobtnTue.Size = new System.Drawing.Size(53, 19);
            this.rdobtnTue.TabIndex = 1;
            this.rdobtnTue.TabStop = true;
            this.rdobtnTue.Text = "Tue";
            this.rdobtnTue.UseVisualStyleBackColor = true;
            this.rdobtnTue.CheckedChanged += new System.EventHandler(this.radioDay_CheckedChanged);
            // 
            // rdobtnWed
            // 
            this.rdobtnWed.AutoSize = true;
            this.rdobtnWed.Location = new System.Drawing.Point(14, 87);
            this.rdobtnWed.Name = "rdobtnWed";
            this.rdobtnWed.Size = new System.Drawing.Size(54, 19);
            this.rdobtnWed.TabIndex = 2;
            this.rdobtnWed.TabStop = true;
            this.rdobtnWed.Text = "Wed";
            this.rdobtnWed.UseVisualStyleBackColor = true;
            this.rdobtnWed.CheckedChanged += new System.EventHandler(this.radioDay_CheckedChanged);
            // 
            // rdobtnThu
            // 
            this.rdobtnThu.AutoSize = true;
            this.rdobtnThu.Location = new System.Drawing.Point(14, 123);
            this.rdobtnThu.Name = "rdobtnThu";
            this.rdobtnThu.Size = new System.Drawing.Size(53, 19);
            this.rdobtnThu.TabIndex = 3;
            this.rdobtnThu.TabStop = true;
            this.rdobtnThu.Text = "Thu";
            this.rdobtnThu.UseVisualStyleBackColor = true;
            this.rdobtnThu.CheckedChanged += new System.EventHandler(this.radioDay_CheckedChanged);
            // 
            // rdobtnFri
            // 
            this.rdobtnFri.AutoSize = true;
            this.rdobtnFri.Location = new System.Drawing.Point(14, 158);
            this.rdobtnFri.Name = "rdobtnFri";
            this.rdobtnFri.Size = new System.Drawing.Size(44, 19);
            this.rdobtnFri.TabIndex = 4;
            this.rdobtnFri.TabStop = true;
            this.rdobtnFri.Text = "Fri";
            this.rdobtnFri.UseVisualStyleBackColor = true;
            this.rdobtnFri.CheckedChanged += new System.EventHandler(this.radioDay_CheckedChanged);
            // 
            // rdobtnSat
            // 
            this.rdobtnSat.AutoSize = true;
            this.rdobtnSat.Location = new System.Drawing.Point(14, 195);
            this.rdobtnSat.Name = "rdobtnSat";
            this.rdobtnSat.Size = new System.Drawing.Size(49, 19);
            this.rdobtnSat.TabIndex = 5;
            this.rdobtnSat.TabStop = true;
            this.rdobtnSat.Text = "Sat";
            this.rdobtnSat.UseVisualStyleBackColor = true;
            this.rdobtnSat.CheckedChanged += new System.EventHandler(this.radioDay_CheckedChanged);
            // 
            // rdobtnSun
            // 
            this.rdobtnSun.AutoSize = true;
            this.rdobtnSun.Location = new System.Drawing.Point(14, 231);
            this.rdobtnSun.Name = "rdobtnSun";
            this.rdobtnSun.Size = new System.Drawing.Size(53, 19);
            this.rdobtnSun.TabIndex = 6;
            this.rdobtnSun.TabStop = true;
            this.rdobtnSun.Text = "Sun";
            this.rdobtnSun.UseVisualStyleBackColor = true;
            this.rdobtnSun.CheckedChanged += new System.EventHandler(this.radioDay_CheckedChanged);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.BackColor = System.Drawing.Color.Lime;
            this.lblDays.Location = new System.Drawing.Point(128, 235);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(38, 15);
            this.lblDays.TabIndex = 7;
            this.lblDays.Text = "Days";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.lblDays2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.rdobtnYears);
            this.panel2.Controls.Add(this.rdobtnDays);
            this.panel2.Location = new System.Drawing.Point(256, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 100);
            this.panel2.TabIndex = 8;
            // 
            // rdobtnDays
            // 
            this.rdobtnDays.AutoSize = true;
            this.rdobtnDays.Checked = true;
            this.rdobtnDays.Location = new System.Drawing.Point(21, 16);
            this.rdobtnDays.Name = "rdobtnDays";
            this.rdobtnDays.Size = new System.Drawing.Size(59, 19);
            this.rdobtnDays.TabIndex = 8;
            this.rdobtnDays.TabStop = true;
            this.rdobtnDays.Text = "Days";
            this.rdobtnDays.UseVisualStyleBackColor = true;
            this.rdobtnDays.CheckedChanged += new System.EventHandler(this.radioDays_CheckedChanged);
            // 
            // rdobtnYears
            // 
            this.rdobtnYears.AutoSize = true;
            this.rdobtnYears.Location = new System.Drawing.Point(21, 50);
            this.rdobtnYears.Name = "rdobtnYears";
            this.rdobtnYears.Size = new System.Drawing.Size(64, 19);
            this.rdobtnYears.TabIndex = 9;
            this.rdobtnYears.Text = "Years";
            this.rdobtnYears.UseVisualStyleBackColor = true;
            this.rdobtnYears.CheckedChanged += new System.EventHandler(this.radioYears_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // lblDays2
            // 
            this.lblDays2.AutoSize = true;
            this.lblDays2.BackColor = System.Drawing.Color.Lime;
            this.lblDays2.Location = new System.Drawing.Point(228, 54);
            this.lblDays2.Name = "lblDays2";
            this.lblDays2.Size = new System.Drawing.Size(38, 15);
            this.lblDays2.TabIndex = 8;
            this.lblDays2.Text = "Days";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.btnCheck);
            this.panel3.Controls.Add(this.chkboxLbl);
            this.panel3.Controls.Add(this.chkboxRadio);
            this.panel3.Controls.Add(this.chkboxCombo);
            this.panel3.Location = new System.Drawing.Point(256, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 125);
            this.panel3.TabIndex = 11;
            // 
            // chkboxCombo
            // 
            this.chkboxCombo.AutoSize = true;
            this.chkboxCombo.Location = new System.Drawing.Point(21, 52);
            this.chkboxCombo.Name = "chkboxCombo";
            this.chkboxCombo.Size = new System.Drawing.Size(134, 19);
            this.chkboxCombo.TabIndex = 0;
            this.chkboxCombo.Text = "コンボボックス確認";
            this.chkboxCombo.UseVisualStyleBackColor = true;
            // 
            // chkboxRadio
            // 
            this.chkboxRadio.AutoSize = true;
            this.chkboxRadio.Location = new System.Drawing.Point(21, 15);
            this.chkboxRadio.Name = "chkboxRadio";
            this.chkboxRadio.Size = new System.Drawing.Size(125, 19);
            this.chkboxRadio.TabIndex = 1;
            this.chkboxRadio.Text = "ラジオボタン確認";
            this.chkboxRadio.UseVisualStyleBackColor = true;
            // 
            // chkboxLbl
            // 
            this.chkboxLbl.AutoSize = true;
            this.chkboxLbl.Location = new System.Drawing.Point(21, 88);
            this.chkboxLbl.Name = "chkboxLbl";
            this.chkboxLbl.Size = new System.Drawing.Size(123, 19);
            this.chkboxLbl.TabIndex = 2;
            this.chkboxLbl.Text = "ラベル表示確認";
            this.chkboxLbl.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Yellow;
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.Location = new System.Drawing.Point(191, 52);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 55);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "button1";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.MouseEnter += new System.EventHandler(this.btnCheck_MouseEnter);
            this.btnCheck.MouseLeave += new System.EventHandler(this.btnCheck_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.rdobtnCenter);
            this.panel4.Controls.Add(this.rdobtnStretch);
            this.panel4.Controls.Add(this.rdobtnZoom);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(12, 303);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(537, 135);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.BackgroundImage = global::CSharp_Form_Program.Properties.Resources.Kenrokuen_min;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(38, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(88, 100);
            this.panel5.TabIndex = 0;
            // 
            // rdobtnZoom
            // 
            this.rdobtnZoom.AutoSize = true;
            this.rdobtnZoom.Location = new System.Drawing.Point(174, 17);
            this.rdobtnZoom.Name = "rdobtnZoom";
            this.rdobtnZoom.Size = new System.Drawing.Size(63, 19);
            this.rdobtnZoom.TabIndex = 1;
            this.rdobtnZoom.TabStop = true;
            this.rdobtnZoom.Text = "Zoom";
            this.rdobtnZoom.UseVisualStyleBackColor = true;
            this.rdobtnZoom.CheckedChanged += new System.EventHandler(this.radioImageLayout_CheckedChanged);
            // 
            // rdobtnStretch
            // 
            this.rdobtnStretch.AutoSize = true;
            this.rdobtnStretch.Location = new System.Drawing.Point(174, 58);
            this.rdobtnStretch.Name = "rdobtnStretch";
            this.rdobtnStretch.Size = new System.Drawing.Size(76, 19);
            this.rdobtnStretch.TabIndex = 2;
            this.rdobtnStretch.TabStop = true;
            this.rdobtnStretch.Text = "Stretch";
            this.rdobtnStretch.UseVisualStyleBackColor = true;
            this.rdobtnStretch.CheckedChanged += new System.EventHandler(this.radioImageLayout_CheckedChanged);
            // 
            // rdobtnCenter
            // 
            this.rdobtnCenter.AutoSize = true;
            this.rdobtnCenter.Location = new System.Drawing.Point(174, 98);
            this.rdobtnCenter.Name = "rdobtnCenter";
            this.rdobtnCenter.Size = new System.Drawing.Size(72, 19);
            this.rdobtnCenter.TabIndex = 3;
            this.rdobtnCenter.TabStop = true;
            this.rdobtnCenter.Text = "Center";
            this.rdobtnCenter.UseVisualStyleBackColor = true;
            this.rdobtnCenter.CheckedChanged += new System.EventHandler(this.radioImageLayout_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Form③";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.RadioButton rdobtnSun;
        private System.Windows.Forms.RadioButton rdobtnSat;
        private System.Windows.Forms.RadioButton rdobtnFri;
        private System.Windows.Forms.RadioButton rdobtnThu;
        private System.Windows.Forms.RadioButton rdobtnWed;
        private System.Windows.Forms.RadioButton rdobtnTue;
        private System.Windows.Forms.RadioButton rdobtnMon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDays2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rdobtnYears;
        private System.Windows.Forms.RadioButton rdobtnDays;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.CheckBox chkboxLbl;
        private System.Windows.Forms.CheckBox chkboxRadio;
        private System.Windows.Forms.CheckBox chkboxCombo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdobtnCenter;
        private System.Windows.Forms.RadioButton rdobtnStretch;
        private System.Windows.Forms.RadioButton rdobtnZoom;
        private System.Windows.Forms.Panel panel5;
    }
}