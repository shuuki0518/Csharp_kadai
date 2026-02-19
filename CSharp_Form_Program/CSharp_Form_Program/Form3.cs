using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Form_Program
{
    public partial class Form3 : Form
    {

        string[] days =
            {
        "", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"
        };

        string[] months =
            {
        "", "Jan.", "Feb.", "Mar.", "Apr.", "May", "Jun.",
        "Jul.", "Aug.", "Sep.", "Oct.", "Nov.", "Dec."
        };


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {


            string[] days = { "", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            string[] months = { "", "Jan", "Feb", "Mar", "Apr", "May", "Jun",
                        "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            rdobtnMon.Text = days[1];
            rdobtnTue.Text = days[2];
            rdobtnWed.Text = days[3];
            rdobtnThu.Text = days[4];
            rdobtnFri.Text = days[5];
            rdobtnSat.Text = days[6];
            rdobtnSun.Text = days[7];


            comboBox1.Items.Clear();
            comboBox1.Text = "";

            lblDays.Text = "Days";
        }

        private void radioDay_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null && rb.Checked)
            {
                lblDays.Text = rb.Text;
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex <= 0) return;

            lblDays2.Text = comboBox1.SelectedItem.ToString();
        }

        private void radioDays_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdobtnDays.Checked) return;

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(days);

            comboBox1.SelectedIndex = 0;
            lblDays2.Text = "Days";
        }

        private void radioYears_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdobtnYears.Checked) return;

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(months);

            comboBox1.SelectedIndex = 0;
            lblDays2.Text = "Years";
        }

        private void btnCheck_MouseEnter(object sender, EventArgs e)
        {
            //ボタン色変更
            btnCheck.BackColor = Color.Black;
            btnCheck.ForeColor = Color.Yellow;

            //チェックON
            chkboxRadio.Checked = true;
            chkboxCombo.Checked = true;
            chkboxLbl.Checked = true;
        }

        private void btnCheck_MouseLeave(object sender, EventArgs e)
        {
            //ボタン色を戻す
            btnCheck.BackColor = Color.Yellow;
            btnCheck.ForeColor = Color.Black;
        }

        private void radioImageLayout_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (!rb.Checked) return;

            if (rb == rdobtnZoom)
            {
                panel5.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else if (rb == rdobtnStretch)
            {
                panel5.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (rb == rdobtnCenter)
            {
                panel5.BackgroundImageLayout = ImageLayout.Center;
            }
        }
    }
}
