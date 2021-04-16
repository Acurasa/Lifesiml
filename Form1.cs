using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lifesiml
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private ushort res;
        private bool[,] space; private int row, col;
        private Graphics gdi;
        Random random = new Random();


        private void timer1_Tick(object sender, EventArgs e)
        {
            GenerateNew();
        }
        public void RunGame()
        {
            if (timer1.Enabled)
            {
                return;
            }

            setRes.Enabled = false; setDens.Enabled = false;
            res = (UInt16)setRes.Value;
            row = screen.Height / res; col = screen.Width / res;
            space = new bool[col, row];
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    space[i, j] = random.Next((int)setDens.Value) == 0;
                }
            }
            screen.Image = new Bitmap(screen.Height, screen.Width);
            gdi = Graphics.FromImage(screen.Image);
            //gdi.FillRectangle(Brushes.Cyan, 0, 0, res, res);
            timer1.Start();
        }

        private void StopGame()
        {
            if (timer1.Enabled)
                timer1.Stop();
            if (timer1.Enabled == false)
                return;
        }

        private void GenerateNew()
        {
            var newArr = new bool[col, row];
            gdi.Clear(Color.Black);
            for (int i = 1; i < col; i++)
            {

                for (int j = 1; j < row; j++)
                {
                    var CellNumber = GetCells(i, j);
                    if (!space[i, j] && CellNumber == 3)
                        newArr[i, j] = true;
                    else if (space[i, j] && (CellNumber < 2 || CellNumber > 3))
                        newArr[i, j] = false;
                    else
                        newArr[i, j] = space[i, j];

                    if (space[i, j])
                        gdi.FillRectangle(Brushes.Cyan, i * res, j * res, res, res);
                }
            }
            //
            //
            space = newArr;
            screen.Refresh();
        }
        private int GetCells(int x, int y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var cols = (x + i + col) % col;
                    var rows = (y + j + row) % row;
                    var check = cols == x && rows == y;
                    // space[i, j] = space[cols, rows];
                    var Alive = space[cols, rows];
                    if (Alive && !check)
                    {
                        count++;
                    }
                }

            }
            return count;
        }


        private void runButton_Click(object sender, EventArgs e)
        {
            RunGame();
        }

        private void screen_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled)
                return; ;
        
            if(e.Button == MouseButtons.Left)
                {
                var x = e.Location.X / res;
                var y = e.Location.Y / res;
                var isOK = isOnScreen(x, y);
                if(isOK)
                    space[x, y] = true;
            }
            if(e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / res;
                var y = e.Location.Y / res;
                var isOK = isOnScreen(x, y);
                if (isOK)
                    space[x, y] = false;
            }
         
           
        }

        bool isOnScreen(int x, int y)
        {
            return x >= 0 && y >= 0 && x < col && y < row;
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            StopGame();
            setRes.Enabled = true; setDens.Enabled = true;
        }
    }
}
