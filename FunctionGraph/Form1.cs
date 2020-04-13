using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 1.0f);
            PointF[] fh = new PointF[100];
            e.Graphics.DrawLine(p, panel1.Width/20, 0, panel1.Width/20, panel1.Height);
            e.Graphics.DrawLine(p, 0, panel1.Height/2, panel1.Width, panel1.Height/2);

            int i = 0;
            float maxValue = 0.0f;
            float calculatedValue = 0.0f;
            for(float x = 0.0f; x < 10.0; x+=0.1f)
            {
                fh[i].X = x;
                calculatedValue = (float)(2 * x * Math.Sin(x));
                if (calculatedValue > maxValue)
                    maxValue = calculatedValue;
                fh[i++].Y = calculatedValue;
            }
            e.Graphics.TranslateTransform(panel1.Width / 20, panel1.Height / 2);
            e.Graphics.ScaleTransform(panel1.Width/10.0f , -1 * panel1.Height / maxValue/2);
            Pen q = new Pen(Color.Black, 0.01f); // don't scale the pen width
            e.Graphics.DrawCurve(q, fh);
        }
    }
}
