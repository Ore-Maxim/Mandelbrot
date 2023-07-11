using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class DrawPx : IDraw
    {

        public int drawM(int x, int y,int res, int Width, int Height, double wx, double wy, double zoom, double pointX, double pointY, int iteretion)
        {

            double a = (double)((x + (wx / res / zoom)) - ((Width / res / 2d))) / (double)(Width / res / zoom / 1.777f);
            double b = (double)((y + (wy / res / zoom)) - ((Height / res / 2d))) / (double)(Height / res / zoom);

            Complex c = new Complex(a, b); // указание координаты
            Complex z = new Complex(pointX, pointY); // указание отображения -1.7433419053321, 0.0000907687489

            int it = 0;

            do
            {
                it++;
                z.Sqr();
                z.Add(c);
                if (z.Magn() > 2.0d) // на оси Re 
                {
                    break;
                }
            } while (it < iteretion); // выполняется процесс итерация
            return it;
        }

       
        public int drawJ(int x, int y, int res, int Width, int Height, double wx, double wy, double zoom, double pointX, double pointY, int iteretion)
        {
            // масштабируем расположение позиций
            double a = (double)((x + (wx / res / zoom)) - ((Width / 2d) / res)) / (double)(Width / zoom / res / 1.777f);
            double b = (double)((y + (wy / res / zoom)) - ((Height / 2d) / res)) / (double)(Height / zoom / res);
            Complex c = new Complex(pointX, pointY);  //0.28,0.0113 ; -1 0
            Complex z = new Complex(a, b);


            int it = 0;

            do
            {
                it++;
                z.Sqr();
                z.Add(c);
                if (z.Magn() > 2.0d)
                {
                    break;
                }
            } while (it < iteretion);

            return it;
        }
    }
}
