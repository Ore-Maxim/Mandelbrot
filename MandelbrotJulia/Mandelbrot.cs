using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Mandelbrot : Form
    {
        //Пикселей в одном делении оси
        const int PIX_IN_ONE = 150;
        //Длина стрелки
        const int ARR_LEN = 10;

        bool key_zoom = false, key_julia = false;
        public double wx = -130, wy = 0; // перемещение по фракталу
        public double speed = 2f, zoom = 2.5f, zoomSpeed = 0.001d; // zoom - степень приближения фрактала, zoomspeed - разрешение нашего фрактала
        public int res = 1; // ускорение вычисления фрактала
        public int k = 5; // коэффициент скорости перемещения
        public int iteretion = 1;

        public double pointX = 0, pointY = 0;
        DrawPx draw = new DrawPx();

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                res -= 1;
            }
            if (e.KeyCode == Keys.E)
            {
                res += 1;
            }

            if (e.KeyCode == Keys.Up)
            {
                wy -= speed * (5 - Math.Abs(zoom));
            }
            if (e.KeyCode == Keys.Down)
            {
                wy += speed * (5 - Math.Abs(zoom));
            }

            if (e.KeyCode == Keys.Left)
            {
                wx -= speed * (5 - Math.Abs(zoom));
            }
            if (e.KeyCode == Keys.Right)
            {
                wx += speed * (5 - Math.Abs(zoom));
            }


            if (e.KeyCode == Keys.Space)
            {
                timer1.Stop();
                Draw(pointX, pointY);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (key_zoom == true)
            {
                zoom -= (zoomSpeed / zoom) * k;
                Draw(pointX, pointY);
            }
        }
        private void включитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Paint -= PictureBox1_Paint;
            key_zoom = true;
        }
        private void выключитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            key_zoom = false;
        }
        private void ускоритьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            k += 1;
        }
        private void замедлитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (k <= 1)
            {
                k = 1;
            }
            else k -= 1;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            translation translation = new translation();
            translation.ShowDialog();
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            оПрограмме programm = new оПрограмме();
            programm.ShowDialog();
            Close();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iteretion < 256)
            {
                iteretion *= 2;
            }
            Draw(pointX, pointY);
        }
        private void renderPixelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iteretion < 256)
            {
                iteretion *= 2;
            }
            Draw(pointX, pointY);
        }

        private void сохранитьИзображениеКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Сохранить изображение как...";
                sfd.OverwritePrompt = true;
                sfd.CheckPathExists = true;
                sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files(*.*)|*.*";
                sfd.ShowHelp = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(sfd.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(800, 450);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public Mandelbrot(double pointX, double pointY)
        {
            InitializeComponent();
            pictureBox1.Paint += PictureBox1_Paint;
            this.pointX = pointX;
            this.pointY = pointY;

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (key_julia == true)
            {
                Hide();
                double x = ((e.X + (wx / res / zoom)) - ((Width / 2d) / res)) / (double)(Width / zoom / res / 1.777f);
                double y = ((e.Y + (wy / res / zoom)) - ((Height / res / 2d))) / (double)(Height / res / zoom);
                Julia julia = new Julia(x, y);
                julia.ShowDialog();
                Close();
            }

        }
        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox1.ClientSize.Width / 2;
            int h = pictureBox1.ClientSize.Height / 2;
            //Смещение начала координат в центр PictureBox
            e.Graphics.TranslateTransform(w, h);
            DrawXAxis(new Point(-w, 0), new Point(w, 0), e.Graphics);
            DrawYAxis(new Point(0, h), new Point(0, -h), e.Graphics);
            //Центр координат
            e.Graphics.FillEllipse(Brushes.Red, -2, -2, 4, 4);
        }

        //Рисование оси X
        private void DrawXAxis(Point start, Point end, Graphics g)
        {
            g.DrawLine(Pens.Orange, PIX_IN_ONE, -5, PIX_IN_ONE, 5);
            DrawText(new Point(PIX_IN_ONE, 5), (0.5).ToString(), g);
            //Деления в отрицательном направлении оси
            for (int i = -PIX_IN_ONE; i > start.X; i -= PIX_IN_ONE)
            {
                g.DrawLine(Pens.Orange, i, -5, i, 5);
                DrawText(new Point(i, 5), (i / PIX_IN_ONE).ToString(), g);
            }
            //Ось
            g.DrawLine(Pens.Orange, start, end);
            //Стрелка
            g.DrawLines(Pens.Orange, GetArrow(start.X, start.Y, end.X, end.Y, ARR_LEN));
        }

        //Рисование оси Y
        private void DrawYAxis(Point start, Point end, Graphics g)
        {
            g.DrawLine(Pens.Orange, -5, -PIX_IN_ONE - 20, 5, -PIX_IN_ONE - 20);
            DrawText(new Point(5, -PIX_IN_ONE - 20), (1).ToString(), g, true);

            g.DrawLine(Pens.Orange, -5, PIX_IN_ONE + 50, 5, PIX_IN_ONE + 50);
            DrawText(new Point(5, PIX_IN_ONE + 50), (0.9).ToString(), g, true);
            //Ось
            g.DrawLine(Pens.Orange, start, end);
            //Стрелка
            g.DrawLines(Pens.Orange, GetArrow(start.X, start.Y, end.X, end.Y, ARR_LEN));
        }

        //Рисование текста
        private void DrawText(Point point, string text, Graphics g, bool isYAxis = false)
        {
            var f = new Font(Font.FontFamily, 10);
            var size = g.MeasureString(text, f);
            var pt = isYAxis
                ? new PointF(point.X + 1, point.Y - size.Height / 2)
                : new PointF(point.X - size.Width / 2, point.Y + 1);
            var rect = new RectangleF(pt, size);
            g.DrawString(text, f, Brushes.Orange, rect);
        }

        //Вычисление стрелки оси
        public static PointF[] GetArrow(float x1, float y1, float x2, float y2, float len = 10, float width = 4)
        {
            PointF[] result = new PointF[3];
            //направляющий вектор отрезка
            var n = new PointF(x2 - x1, y2 - y1);
            //Длина отрезка
            var l = (float)Math.Sqrt(n.X * n.X + n.Y * n.Y);
            //Единичный вектор
            var v1 = new PointF(n.X / l, n.Y / l);
            //Длина стрелки
            n.X = x2 - v1.X * len;
            n.Y = y2 - v1.Y * len;
            result[0] = new PointF(n.X + v1.Y * width, n.Y - v1.X * width);
            result[1] = new PointF(x2, y2);
            result[2] = new PointF(n.X - v1.Y * width, n.Y + v1.X * width);
            return result;
        }
        public void Draw(double pointX, double pointY)
        {
            if (res <= 1)
            {
                res = 1;
            }
            Bitmap frame = new Bitmap(Width / res, Height / res); // создание кадра, которое будет идти в picturbox
            for (int x = 0; x < Width / res; x++) // перебираем пиксели
            {
                for (int y = 0; y < Height / res; y++)// перебираем пиксели
                {
                    int it = draw.drawM(x, y, res, Width, Height, wx, wy, zoom, pointX, pointY, iteretion);
                    frame.SetPixel(x, y, Color.FromArgb(255, it % 8 * 16, it % 4 * 32, it % 2 * 64));
                }
            }
            pictureBox1.Image = frame;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            key_julia = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (key_julia == true)
            {
                if (res <= 1)
                {
                    res = 1;
                }
                double x = ((e.X + (wx / res / zoom)) - ((Width / 2d) / res)) / (double)(Width / zoom / res / 1.777f);
                double y = ((e.Y + (wy / res / zoom)) - ((Height / res / 2d))) / (double)(Height / res / zoom);
                label1.Text = "Re = " + x + ", Im = " + y;
            }
        }

        private void анимацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Animathion animathion = new Animathion();
            animathion.ShowDialog();
            Close();
        }

        private void построениеТочекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Dots dots = new Dots();
            dots.ShowDialog();
            Close();
        }

        public Julia Julia
        {
            get => default;
            set
            {
            }
        }

        public DrawPx DrawPx
        {
            get => default;
            set
            {
            }
        }

        public Complex Complex
        {
            get => default;
            set
            {
            }
        }

        public оПрограмме оПрограмме
        {
            get => default;
            set
            {
            }
        }

        public translation translation
        {
            get => default;
            set
            {
            }
        }
    }

}
