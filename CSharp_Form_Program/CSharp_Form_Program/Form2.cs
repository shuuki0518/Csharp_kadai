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
    public partial class Form2 : Form
    {
        // Form1へ返す値
        public string ReturnValue { get; private set; }

        public Form2(string text)
        {
            InitializeComponent();
            lblReceive.Text = text;
        }

        private void btnBunkatu_Click(object sender, EventArgs e)
        {
            // 元の文字列を取得
            string source = lblReceive.Text;

            // 「,」で分割
            string[] parts = source.Split(',');

            // いったん全部クリア
            txtBoxBunkatu1.Text = "";
            txtBoxBunkatu2.Text = "";
            txtBoxBunkatu3.Text = "";
            txtBoxBunkatu4.Text = "";

            // 分割結果を順に入れる
            if (parts.Length > 0) txtBoxBunkatu1.Text = parts[0];
            if (parts.Length > 1) txtBoxBunkatu2.Text = parts[1];
            if (parts.Length > 2) txtBoxBunkatu3.Text = parts[2];
            if (parts.Length > 3) txtBoxBunkatu4.Text = parts[3];
        }

        private void btnKuhakuSakujoA_Click(object sender, EventArgs e)
        {
            txtBoxBunkatu1.Text = txtBoxBunkatu1.Text.Trim();
            txtBoxBunkatu2.Text = txtBoxBunkatu2.Text.Trim();
            txtBoxBunkatu3.Text = txtBoxBunkatu3.Text.Trim();
            txtBoxBunkatu4.Text = txtBoxBunkatu4.Text.Trim();
        }

        private void btnKuhakuSakujoB_Click(object sender, EventArgs e)
        {
            txtBoxBunkatu1.Text = txtBoxBunkatu1.Text.Replace(" ", "");
            txtBoxBunkatu2.Text = txtBoxBunkatu2.Text.Replace(" ", "");
            txtBoxBunkatu3.Text = txtBoxBunkatu3.Text.Replace(" ", "");
            txtBoxBunkatu4.Text = txtBoxBunkatu4.Text.Replace(" ", "");
        }

        private void btnKeisei_Click(object sender, EventArgs e)
        {
            string result =
                txtBoxBunkatu1.Text + "," +
                txtBoxBunkatu2.Text + "," +
                txtBoxBunkatu3.Text + "," +
                txtBoxBunkatu4.Text;

            richTextBox2.Text = result;
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            int step = (int)txtLoopCount.Value;

            // 初期化
            richTextBox1.Clear();

            for (int i = 0; i < step; i++)
            {
                string line = "";

                for (int j = 0; j <= i; j++)
                {
                    line += j.ToString();
                }

                richTextBox1.AppendText(line + Environment.NewLine);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // 例：一番下のテキストボックスの内容を返す
            ReturnValue = richTextBox2.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public string RemoveSpaces(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            // カンマ前後の空白削除 + 全体の空白削除
            string result = input
                .Replace(" ", "")     // すべての半角スペース削除
                .Replace("　", "");   // 全角スペースも削除

            return result;
        }
    }
}
