using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_FromSakusei
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 数字とバックスペースのみ許可
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNumber.Text);

            //5以下
            if (num < 5)
            {
                //2の倍数
                if (num % 2 == 0)
                {
                    lblResult.Text = "5より小さい2の倍数";
                }
                else
                {
                    lblResult.Text = "5より小さい2の倍数ではない";
                }
            }
            else
            {
                //2の倍数
                if (num % 2 == 0)
                {
                    lblResult.Text = "5以上　2の倍数";
                }
                else
                {
                    lblResult.Text = "5以上　2の倍数ではない";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
