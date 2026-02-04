using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace CSharp_FormSakusei2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtWord_Click(object sender, EventArgs e)
        {
            /*
            //テキストボックスが空白の場合
            if (string.IsNullOrEmpty(txtWord.Text))
            {
                lblWordResult.Text = "からっぽ";
                lblWordResult.ForeColor = Color.Yellow;
            }
            else
            {
                CheckWord(txtWord.Text);
            }
            */
        }

        //入力内容チェックメソッド
        private void CheckWord(string text)
        {
            bool hasMountain = text.Contains("山");
            bool hasSea = text.Contains("海");

            if (hasMountain && hasSea)
            {
                lblWordResult.Text = "どちらも含まれている";
                lblWordResult.ForeColor = Color.Red;
            }
            else if (hasMountain)
            {
                lblWordResult.Text = "山が含まれている";
                lblWordResult.ForeColor = Color.Green;
            }
            else if (hasSea)
            {
                lblWordResult.Text = "海が含まれている";
                lblWordResult.ForeColor = Color.Blue;
            }
            else
            {
                lblWordResult.Text = "どちらも含まれてない";
                lblWordResult.ForeColor = Color.Black;
            }
        }

        private void btnCheckWord_Click(object sender, EventArgs e)
        {
            //テキストボックスが空白の場合
            if (string.IsNullOrEmpty(txtWord.Text))
            {
                lblWordResult.Text = "からっぽ";
                lblWordResult.ForeColor = Color.Yellow;
            }
            else
            {
                CheckWord(txtWord.Text);
            }
        }
    }
}
