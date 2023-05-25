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
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
            //イベント追加
            Start_button.Click += new EventHandler(StartButton_Click);
            SetUp_Button.Click += new EventHandler(SetUpButton_Click);
        }

        private void StartButton_Click(object sender, EventArgs e)//game開始のボタン
        {
            //GameをするFormに移動
            GameController f = new GameController
            {
                StartPosition = FormStartPosition.Manual,
                DesktopLocation = this.DesktopLocation
            };
            // f.ShowDialog();
            f.Show();
            this.Hide();

            //Form1.startMenu.Visible = false;
            //Form1.gameController.Visible = true;
        }

        private void SetUpButton_Click(object sender, EventArgs e)//設定のボタン
        {
            //設定画面に移動
            SetUpPage f = new SetUpPage
            {
                StartPosition = FormStartPosition.Manual,
                DesktopLocation = this.DesktopLocation
            };
            f.Show();
            this.Hide();
        }

        private void StartMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //formが閉じられたときにタスクがバックグラウンドに行かないようにする
            Environment.Exit(0);
        }
    }
}
