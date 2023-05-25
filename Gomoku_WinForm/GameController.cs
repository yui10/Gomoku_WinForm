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
    public partial class GameController : Form
    {
        private int[,] map = new int[Define.MAP_SIZE + 2, Define.MAP_SIZE + 2];
        private int now_player = 0;
        private int turn = 1;
        private bool game_flag = true;
        private int Ball_Size = 25;

        public GameController()
        {
            InitializeComponent();

            //イベント追加
            this.button1.Click += new EventHandler(StartMenu_Click);//ボタン
            this.MouseClick += new MouseEventHandler(Click_Mouse);//マウスクリック
            this.Resize += new EventHandler(Form_Resize);//windowサイズ変更

            Data_Set();

            this.MinimumSize = new Size(100 + Ball_Size * (Define.MAP_SIZE + 2), 489);//formの最小サイズ
        }
        private void StartMenu_Click(object sender, EventArgs e)//ボタンクリック
        {
            if (button1.Text == "リタイア")
            {
                DialogResult dialog = MessageBox.Show("本当にリタイアしますか", "pause", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
                if (dialog == DialogResult.No)
                {
                    return;
                }
            }

            //スタート画面表示処理
            StartMenu f = new StartMenu
            {
                //formの状を取得し今ある位置と同じところに画面を表示する
                StartPosition = FormStartPosition.Manual
            };
            if (this.WindowState == FormWindowState.Normal)
            {
                f.DesktopLocation = this.DesktopLocation;
            }
            else
            {
                f.DesktopLocation = this.RestoreBounds.Location;
            }
            f.Show();
            this.Hide();
            //Form1.startMenu.Visible = true;
            //Form1.gameController.Visible = false;
        }

        private void Rematch_button_Click(object sender, EventArgs e)
        {
            Data_Set();
            Invalidate();
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            //枠組みだけ表示
            Draw_Frame(sender, e);

            //色指定
            SolidBrush Color_Red = new SolidBrush(Color.Red);
            SolidBrush Color_Blue = new SolidBrush(Color.Blue);
            //◯と×表示
            for (int i = 1; i <= Define.MAP_SIZE; i++)
            {
                for (int j = 1; j <= Define.MAP_SIZE; j++)
                {
                    if (map[i, j] == Define.PLAYER1)
                        e.Graphics.DrawString("◯", new Font("MS ゴシック", Ball_Size / 2), Color_Blue, 25 + ((j - 1) * Ball_Size) + (float)Ball_Size / 15, 50 + ((i - 1) * Ball_Size) + (float)Ball_Size / 6);
                    else if (map[i, j] == Define.PLAYER2)
                        e.Graphics.DrawString("×", new Font("MS ゴシック", Ball_Size), Color_Red, 25 + ((j - 1) * Ball_Size) - (float)(Ball_Size / 7), 50 + ((i - 1) * Ball_Size) - (float)(Ball_Size / 3));
                }
            }
        }

        private void Draw_Frame(object sender, PaintEventArgs e)
        {
            //色指定
            SolidBrush Color_Black = new SolidBrush(Color.Black);
            //横の枠
            for (int i = 1; i < Define.MAP_SIZE + 2; i++)
            {
                Point point = new Point(25, 50 + (i - 1) * Ball_Size);
                Size size = new Size(Define.MAP_SIZE * Ball_Size, Define.LINE_WIDTH);
                Rectangle rectangle = new Rectangle(point, size);
                e.Graphics.FillRectangle(Color_Black, rectangle);
            }
            //縦の枠
            for (int i = 1; i < Define.MAP_SIZE + 2; i++)
            {
                Point point = new Point(25 + (i - 1) * Ball_Size, 50);
                Size size = new Size(Define.LINE_WIDTH, Define.MAP_SIZE * Ball_Size);
                Rectangle rectangle = new Rectangle(point, size);
                e.Graphics.FillRectangle(Color_Black, rectangle);
            }
        }

        private void Form_Resize(object sender, System.EventArgs e)//windowのサイズが変更されると起こる
        {
            //formの縦横の短い方を取得
            Control control = (Control)sender;
            int min = control.Width;
            if (min > control.Height)
            {
                min = control.Height;
            }

            //ボタンの位置変更
            button1.Location = new Point(control.Width - 121, control.Height - 74);
            Rematch_button.Location = new Point(control.Width - 202, control.Height - 74);

            //マスのサイズを再計算
            Ball_Size = (int)((min - 100) / Define.MAP_SIZE);
            Console.WriteLine("ball:{0}", Ball_Size);
            //labelの位置も変更
            turn_label.Location = new Point(25 + Ball_Size * (Define.MAP_SIZE / 2));
            Invalidate();//再描画
        }

        private void Click_Mouse(object sender, MouseEventArgs e)//マウスクリック
        {
            if (game_flag)//Game続行のフラグ
            {
                int x = this.PointToClient(Cursor.Position).X;//クリックされた場所
                bool flag = false;
                Console.WriteLine(now_player);
                Console.WriteLine(x);
                //どこに置くか計算
                if (x >= 25)
                {
                    x = (x - 25) / Ball_Size + 1;
                }
                else
                {
                    x = -100;
                }
                Console.WriteLine("x:{0}", x);
                int Put_return = Puts(x, now_player, map);
                switch (Put_return)//置いて、その結果によって分岐
                {
                    case -2:
                        Console.WriteLine("そこには置くことが出来ません");
                        break;
                    case -1:
                        Console.WriteLine("1～%dの範囲を指定してください\n", Define.MAP_SIZE);
                        break;
                    case 0:
                        flag = true;
                        break;
                    case 10:
                    case 11:
                        Console.WriteLine("Player%dの勝ち\n", now_player);
                        game_flag = false;
                        //Invalidate();
                        button1.Text = "スタートに戻る";
                        Rematch_button.Visible = true; //ボタン表示
                                                       //メッセージボックスを表示
                        _ = MessageBox.Show("Player" + (Put_return % 10 + 1).ToString() + "の勝ち\n", "勝者"/*, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1*/);
                        break;
                    default:
                        break;
                }
                //置けた時
                if (flag == true)
                {
                    now_player ^= 0x01;//Plyer判定
                    turn++;
                    //色々描画
                    turn_label.Text = turn.ToString("D2") + "手目";
                    //Invalidate();
                    if (Show(map) <= 0)//置けるとこまだあるか
                    {
                        _ = MessageBox.Show("置けるところが無くなりました\nプログラムを終了します", "終了します"/*, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1*/);
                        button1.Visible = true;
                        return;
                    }
                }
            }
        }

        private int Puts(int x, int putdata, int[,] map)//置く
        {
            //値が正しい範囲のものか
            if (x < 1 || Define.MAP_SIZE < x) return -1;

            int i, y = 0;

            for (i = Define.MAP_SIZE; i >= 1; i--)//積み上げられるか
            {
                if (map[i, x] == Define.NO_ITEM)
                {
                    if (Define.GAME_MODE == 1)
                    {
                        map[i, x] = putdata;
                    }
                    else if (Define.GAME_MODE == 2)
                    {
                        for (int j = i; j < Define.MAP_SIZE; j++)
                        {
                            map[j, x] = map[j + 1, x];
                        }
                        map[Define.MAP_SIZE, x] = putdata;
                    }
                    y = i;
                    break;
                }
            }

            if (y < 1) return -2;//置けないなら終了

            Invalidate();

            if (Define.GAME_MODE == 1)
            {
                int checkdata = Check(y, x, putdata, map);
                if (checkdata != -1)
                {
                    return checkdata;
                }
            }
            else if (Define.GAME_MODE == 2)
            {
                int return_data = 0;
                for (i = y; i <= Define.MAP_SIZE; i++)
                {
                    int check_data = Check(i, x, map[i, x], map);
                    if (check_data >= 10)
                    {
                        if (return_data != putdata + 10)
                        {
                            return_data = check_data;
                        }
                    }
                }
                return return_data;
            }

            return 0;
        }

        private int Check(int y, int x, int putdata, int[,] map)
        {
            if (map[y, x] < Define.PLAYER1)
            {
                return -1;
            }

            int[] value = new int[10];
            Array.Clear(value, 0, 10);
            int value_count = 1;

            //周囲の自分のマスをカウント
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int count = 0;
                    if (i == 0 && j == 0)
                    {
                        count = 1;
                    }
                    else if (map[y + i, x + j] == putdata)
                    {
                        for (int k = 1; k < Define.MAP_SIZE; k++)
                        {
                            if (map[y + i * k, x + j * k] == putdata)
                            {
                                count++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    value[value_count] = count;
                    value_count++;
                }
            }

            //揃ったか
            for (int i = 1; i <= 4; i++)
            {
                if (value[i] + value[5] + value[10 - i] >= Define.PUT_MAX)
                {
                    return putdata + 10;
                }
            }

            return 0;
        }

        private int Show(int[,] map)
        {
            int count = 0;
            for (int i = 1; i <= Define.MAP_SIZE; i++)
            {
                Console.Write("{0}", i);
            }
            Console.WriteLine();
            for (int i = 1; i <= Define.MAP_SIZE; i++)
            {
                for (int j = 1; j <= Define.MAP_SIZE; j++)
                {
                    switch (map[i, j])
                    {
                        case Define.PLAYER1:
                            Console.Write("●");
                            break;
                        case Define.PLAYER2:
                            Console.Write("×");
                            break;
                        case Define.NO_ITEM:
                            Console.Write("□");
                            count++;
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine();
            }
            return count;
        }

        private void Data_Set()//データをリセットする
        {
            now_player = 0;
            turn = 1;
            game_flag = true;
            for (int i = 0; i < Define.MAP_SIZE + 2; i++)
            {
                for (int j = 0; j < Define.MAP_SIZE + 2; j++)
                {
                    map[i, j] = Define.NO_ITEM;
                }
            }

            int min = this.Width;
            if (min > this.Height)
            {
                min = this.Height;
            }
            Ball_Size = (int)((min - 100) / Define.MAP_SIZE);//相対的なマスのサイズ
            turn_label.Location = new Point(25 + Ball_Size * (Define.MAP_SIZE / 2));//turnを表示するLabelの位置も変更

            Rematch_button.Visible = false;//ボタンを隠す

            Show(map);
            button1.Text = "リタイア";
            turn_label.Text = turn.ToString("D2") + "手目";
            Invalidate();
        }

        private void GameController_FormClosed(object sender, FormClosedEventArgs e)
        {
            //formが閉じられたときにタスクがバックグラウンドに行かないようにする
            Environment.Exit(0);
        }

    }

    public static class Define //マクロ
    {
        public const int NO_ITEM = -1;
        public const int PLAYER1 = 0;
        public const int PLAYER2 = 1;
        public static int MAP_SIZE = 13;
        public static int PUT_MAX = 5;
        public const int LINE_WIDTH = 1;
        public static int GAME_MODE = 1;
    }
}
