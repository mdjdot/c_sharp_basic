using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            //Brush brush = new SolidBrush(Color.Red);
            Brush brush = new HatchBrush(HatchStyle.Percent50, Color.Red);
            Rectangle rectangle = new Rectangle(10, 10, 200, 100);
            graphics.FillRectangle(brush, rectangle);

            Pen pen = new Pen(Color.Blue, 3);
            Point p1 = new Point(50, 300);
            Point p2 = new Point(350, 300);
            graphics.DrawLine(pen, p1, p2);

        }
    }
}
