using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku_WinForm
{
    public partial class SetUpPage : Form
    {
        public SetUpPage()
        {
            InitializeComponent();
            //イベント追加
            Cancel_button.Click += new EventHandler(Cancel_button_Click);
            OK_button.Click += new EventHandler(OK_button_Click);
            //マクロを代入
            numeric_mapsize.Value = Define.MAP_SIZE;
            numeric_putsize.Value = Define.PUT_MAX;

            switch (Define.GAME_MODE)
            {
                case 1:
                    modeChange_checkBox.Text = "Normal";
                    break;
                case 2:
                    modeChange_checkBox.Text = "Hard";
                    break;
            }
        }

        private void Cancel_button_Click(object send, EventArgs e)//キャンセルボタン
        {
            bool flag = false;
            int mode = 1;
            if (modeChange_checkBox.Checked)
            {
                mode = 2;
            }

            //値が変更されるか
            if (numeric_mapsize.Value != Define.MAP_SIZE)
                flag = true;
            else if (numeric_putsize.Value != Define.PUT_MAX)
                flag = true;
            else if (mode != Define.GAME_MODE)
                flag = true;

            if (flag)
            {
                //変更するか表示
                DialogResult dialog = MessageBox.Show("変更内容を保存しますか", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                if (dialog == DialogResult.Yes)//はいがおされたとき
                {
                    if (numeric_mapsize.Value >= numeric_putsize.Value)//マスのサイズを揃える数を超えていないか
                    {
                        //マクロに反映
                        Define.MAP_SIZE = int.Parse(numeric_mapsize.Value.ToString());
                        Define.PUT_MAX = int.Parse(numeric_putsize.Value.ToString());
                    }
                    else
                    {
                        //エラーを表示
                        _ = MessageBox.Show("盤面のサイズは揃える数より大きくして下さい", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (modeChange_checkBox.Checked)
                    {
                        Define.GAME_MODE = 2;
                    }
                    else
                    {
                        Define.GAME_MODE = 1;
                    }
                }
                else if (dialog == DialogResult.Cancel)//キャンセルなら終了
                {
                    return;
                }
            }

            //スタート画面に移動
            StartMenu f = new StartMenu
            {
                StartPosition = FormStartPosition.Manual,
                DesktopLocation = this.DesktopLocation
            };
            f.Show();
            this.Hide();
        }
        private void OK_button_Click(object send, EventArgs e)//OKがクリックされたら
        {
            if (numeric_mapsize.Value >= numeric_putsize.Value)//マスのサイズを揃える数を超えていないか
            {
                Define.MAP_SIZE = int.Parse(numeric_mapsize.Value.ToString());
                Define.PUT_MAX = int.Parse(numeric_putsize.Value.ToString()); ;
            }
            else
            {
                //DialogResult error = MessageBox.Show("盤面のサイズは揃える数より大きくして下さい", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = MessageBox.Show("盤面のサイズは揃える数より大きくして下さい", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (modeChange_checkBox.Checked)
            {
                Define.GAME_MODE = 2;
            }
            else
            {
                Define.GAME_MODE = 1;
            }

            //スタート画面に移動
            StartMenu f = new StartMenu
            {
                StartPosition = FormStartPosition.Manual,
                DesktopLocation = this.DesktopLocation
            };
            f.Show();
            this.Hide();
        }
        private void Reset_button_Click(object sender, EventArgs e)//リセットボタン
        {
            //警告メッセージ
            DialogResult dialog = MessageBox.Show("本当に初期値に戻しますか", "", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
            if (dialog == DialogResult.Yes)
            {
                numeric_mapsize.Value = Define.MAP_SIZE = 13;
                numeric_putsize.Value = Define.PUT_MAX = 5;
                modeChange_checkBox.Text = "Normal";
                Define.GAME_MODE = 1;
            }
        }

        private void SetUpPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            //formが閉じられたときにタスクがバックグラウンドに行かないようにする
            Environment.Exit(0);
        }

        private void ModeChange_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (modeChange_checkBox.Checked)
            {
                modeChange_checkBox.Text = "Hard";
            }
            else
            {
                modeChange_checkBox.Text = "Normal";
            }
        }
    }
}
