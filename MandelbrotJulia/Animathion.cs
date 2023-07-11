using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Animathion : Form
    {
        public double wx = 0, wy = 0; // перемещение по фракталу
        public double speed = 2f, zoom = 3f, zoomSpeed = 0.001d; // zoom - степень приближения фрактала, zoomspeed - разрешение нашего фрактала
        public int res = 1; // ускорение вычисления фрактала
        public int k = 5; // коэффициент скорости перемещения

        public int count = 0;

        DrawPx draw = new DrawPx();
        public Animathion()
        {
            InitializeComponent();
            DrawM(0, 0);
        }

        private void главноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Mandelbrot mandelbrot = new Mandelbrot(0, 0);
            mandelbrot.ShowDialog();
            Close();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            double a = (double)((e.X + (wx / res / zoom)) - ((pictureBox1.Width / res / 2d))) / (double)(pictureBox1.Width / res / zoom / 1.777f);
            double b = (double)((e.Y + (wy / res / zoom)) - ((pictureBox1.Height / res / 2d))) / (double)(pictureBox1.Height / res / zoom);

            if (count == 3)
            {
                DrawJ(a, b);
                count = 0;
            }
            else count += 1;
            label1.Text = "Re = " + a + ", Im = " + b;
        }

        public void DrawM(double pointX, double pointY)
        {
            if (res <= 1)
            {
                res = 1;
            }
            Bitmap frame = new Bitmap(pictureBox1.Width / res, pictureBox1.Height / res); // создание кадра, которое будет идти в picturbox
            for (int x = 0; x < pictureBox1.Width / res; x++) // перебираем пиксели
            {
                for (int y = 0; y < pictureBox1.Height / res; y++)// перебираем пиксели
                {
                    int it = draw.drawM(x, y, res, pictureBox1.Width, pictureBox1.Height, wx, wy, zoom, pointX, pointY, 50);
                    frame.SetPixel(x, y, Color.FromArgb(255, it % 8 * 16, it % 4 * 32, it % 2 * 64));
                }
            }
            pictureBox1.Image = frame;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void DrawJ(double pointX, double pointY)
        {
            if (res <= 1)
            {
                res = 1;
            }
            Bitmap frame = new Bitmap(pictureBox2.Width / res, pictureBox2.Height / res); // создание кадра, которое будет идти в picturbox
            for (int x = 0; x < pictureBox2.Width / res; x++) // перебираем пиксели
            {
                for (int y = 0; y < pictureBox2.Height / res; y++)// перебираем пиксели
                {
                    int it = draw.drawJ(x, y, res, pictureBox2.Width, pictureBox2.Height, wx, wy, zoom, pointX, pointY, 100);
                    frame.SetPixel(x, y, Color.FromArgb(255, it % 8 * 16, it % 4 * 32, it % 2 * 64));
                }
            }
            pictureBox2.Image = frame;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
