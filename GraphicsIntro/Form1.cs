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

        private void DrawShape(Graphics g, Pen p, int x, int y)
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
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen p1 = new Pen(Color.Red);
            Pen p2 = new Pen(Color.Blue);

            DrawShape(e.Graphics, p1, 10, 0);
            DrawShape(e.Graphics, p2, 150, 0);

            e.Graphics.TranslateTransform(20, 250);
            DrawShape(e.Graphics, p1, 10, 0);
            DrawShape(e.Graphics, p2, 150, 0);

            e.Graphics.RotateTransform(30);
            DrawShape(e.Graphics, p1, 10, 0);
            DrawShape(e.Graphics, p2, 150, 0);

            e.Graphics.RotateTransform(-60);
            e.Graphics.ScaleTransform(2f, 0.5f);
            DrawShape(e.Graphics, p1, 10, 0);
            DrawShape(e.Graphics, p2, 150, 0);
        }
    }
}
