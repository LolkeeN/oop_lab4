using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veselov_V_O_oop_lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.CreateGraphics().DrawRectangle(new Pen(Color.Black, 1), new System.Drawing.Rectangle(0, 0, 30, 40));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float x0 = 20;
            float y0 = 30;
            pictureBox1.CreateGraphics().DrawPolygon(new Pen(Color.Blue, 1), new PointF[] { new PointF(x0 + 10, y0 - 20), new PointF(x0 + 40, y0 + 10), new PointF(x0 + 70, y0 - 20) });
        }
    }
}
