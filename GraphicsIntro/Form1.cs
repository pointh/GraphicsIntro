using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsIntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawRectangle(Graphics g, Pen p, int x, int y)
        {
            Point[] ps =
            {
                new Point(x, y),
                new Point(x+100, y),
                new Point(x+100, y+100),
                new Point(x, y+100),
                new Point(x, y)
            };
            g.DrawLines(p, ps);
        }

        private void DrawCircle(Graphics g, Pen p, int x, int y, int r)
        {
            g.DrawEllipse(p, x-r, y-r, 2*r, 2*r);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen p1 = new Pen(Color.Red);
            Pen p2 = new Pen(Color.Blue);

            DrawRectangle(e.Graphics, p1, 10, 0);
            DrawRectangle(e.Graphics, p2, 150, 0);

            e.Graphics.TranslateTransform(20, 250);
            DrawRectangle(e.Graphics, p1, 10, 0);
            DrawRectangle(e.Graphics, p2, 150, 0);

            e.Graphics.RotateTransform(30);
            DrawRectangle(e.Graphics, p1, 10, 0);
            DrawRectangle(e.Graphics, p2, 150, 0);

            e.Graphics.RotateTransform(-60);
            e.Graphics.ScaleTransform(2.0f, 0.6f);
            DrawRectangle(e.Graphics, p1, 10, 0);
            DrawRectangle(e.Graphics, p2, 150, 0);
        }

       
        private void cycleButton_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Green);
            DrawCircle(e.Graphics, p,
                (sender as Control).Width / 3,
                (sender as Control).Height / 2,
                (sender as Control).Height / 4);
        }
    }
}
