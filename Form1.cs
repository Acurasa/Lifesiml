﻿using Lifesiml.Logic;
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
        private Core core;
        private Graphics gdi;
       


        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawNew();
        }
        public void RunGame()
        {
            if (timer1.Enabled)
            {
                return;
            }

            setRes.Enabled = false; setDens.Enabled = false;
            res = (UInt16)setRes.Value;
            core = new Core(row: screen.Height / res, col: screen.Width / res,(int)setDens.Value);
            Text = $"Gen № : {core.Gen}";

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

        private void DrawNew()
        {
            
            gdi.Clear(Color.Black);
            var space = core.GetCurrentAge();
            for (int x = 0;x < space.GetLength(0); x++)
            {
                for (int y = 0; y < space.GetLength(1); y++)
                {
                    if(space[x,y])
                        gdi.FillRectangle(Brushes.Cyan, x * res, y * res, res - 1, res - 1);
                    
                }
            }
            
            
            
            
            //
            //

            screen.Refresh();
            Text = $"Gen № : {core.Gen}";
            core.GenerateNew();
        }



        private void runButton_Click(object sender, EventArgs e)
        {
            RunGame();
        }

        private void screen_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled)
                return; ;

            if (e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / res;
                var y = e.Location.Y / res;
                core.AddCell(x,y);
            }
            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / res;
                var y = e.Location.Y / res;
                core.RemoveCell(x, y);
            }


        }

       
        private void stopButton_Click(object sender, EventArgs e)
        {
            StopGame();
            setRes.Enabled = true; setDens.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
