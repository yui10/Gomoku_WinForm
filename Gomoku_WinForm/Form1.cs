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
    public partial class Form1 : Form
    {
        public static StartMenu startMenu;
        public static GameController gameController;
        public Form1()
        {
            InitializeComponent();

            startMenu = new StartMenu();
            gameController = new GameController();

            startMenu.TopLevel = false;
            gameController.TopLevel = false;
            //panel1.Controls.Add(startMenu);
            //panel1.Controls.Add(gameController);
            //panel1.Dock = DockStyle.Fill;

            //startMenu.Visible = true;
            //gameController.Visible = false;
        }

    }
}
