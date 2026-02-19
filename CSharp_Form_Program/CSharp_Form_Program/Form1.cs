using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSharp_Form_Program
{
    public partial class Form1 : Form
    {
        string txtFilePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter ="すべてのファイル (*.*)|*.*";
            ofd.Title = "ファイルを選択してください";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtBoxFilePath.Text = ofd.FileName;
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string path = txtBoxFilePath.Text;

            //未入力チェック
            if (string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show(
                    "ファイルを選択してください",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            //存在チェック
            if (!File.Exists(path))
            {
                MessageBox.Show(
                    Message_manage.Msg2,
                    Message_manage.Title4,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop
                );
                return;
            }

            //読み込み（例外対策）
            try
            {
                lblFileContent.Text = File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "ファイルの読み込みに失敗しました。\n" + ex.Message,
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnPushTop_Click(object sender, EventArgs e)
        {
            //確認ダイアログを表示
            DialogResult result = MessageBox.Show(
                Message_manage.Msg1,   // 画面遷移してもよろしいですか？
                Message_manage.Title3, // 確認
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            //キャンセルなら何もしない
            if (result != DialogResult.OK)
            {
                return;
            }

            //OKのときだけ Form2 を開く
            using (Form2 form2 = new Form2(lblFileContent.Text))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    //Form2からの返却値を受け取る
                    lblF2rec.Text = form2.ReturnValue;
                }
            }
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            panelBack.BackColor = Color.Yellow;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            panelBack.BackColor = Color.Green;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            panelBack.BackColor = Color.Blue;
        }

        private void btnFileUpdate_Click(object sender, EventArgs e)
        {
            string path = txtBoxFilePath.Text;

            // 未選択
            if (string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show(
                    Message_manage.Title1,
                    Message_manage.Title3,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 存在確認
            if (!File.Exists(path))
            {
                MessageBox.Show(
                    Message_manage.Msg2,
                    Message_manage.Title4,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            try
            {
                //現在の内容を取得
                string originalText = File.ReadAllText(path);

                //Form②で加工
                Form2 form2 = new Form2(originalText);
                string updatedText = form2.RemoveSpaces(originalText);

                //上書き保存
                File.WriteAllText(path, updatedText);

                MessageBox.Show("ファイルを更新しました");

                //画面表示も更新
                lblFileContent.Text = updatedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新に失敗しました\n" + ex.Message);
            }
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            gradientLabel1.Text = DateTime.Now.ToString("HH:mm:ss");

            gradientLabel1.StartColor = Color.White;
            gradientLabel1.EndColor = Color.Blue;
            gradientLabel1.Invalidate();
        }

        private void btnPushBottm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                Message_manage.Msg1,
                Message_manage.Title3,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.OK)
            {
                return;
            }

            using (Form3 form3 = new Form3())
            {
                form3.ShowDialog();
            }
        }
    }
}
