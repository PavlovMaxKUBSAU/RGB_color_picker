using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Form2 : Form
    {
        Bitmap bitmap;
        Graphics graph;
        Pen blackPen;
        SolidBrush brush = new SolidBrush(Color.FromArgb(0,0,0));

        public Form2()
        {
            InitializeComponent();

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graph = Graphics.FromImage(bitmap);
            blackPen = new Pen(Color.Black);
            blackPen.Width = 2;
            
            graph.FillRectangle(brush, 0, 0, 200, 200);
            
            pictureBox1.Image = bitmap;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            brush.Color = Color.FromArgb(red_trackBar.Value*10, green_trackBar.Value*10, blue_trackBar.Value*10);
            graph.FillRectangle(brush, 0, 0, 200, 200);
            pictureBox1.Image = bitmap;
        }
    }
}
