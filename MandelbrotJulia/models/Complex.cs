using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Complex : IComplex
    { // класс для обработки комплексных чисел
        public double a;
        public double bi;

        public Complex(double a, double bi)
        {
            this.a = a;
            this.bi = bi;
        }

        public void Sqr()
        {
            double tmp = (a * a) - (bi * bi); // вычисление действительной части
            bi = 2.0d * a * bi; // вычисление мнимой части
            a = tmp;
        }

        public double Magn()
        {
            return Math.Sqrt((a * a) + (bi * bi));
        }

        public void Add(Complex c)
        {
            a += c.a;
            bi += c.bi;
        }

    }
}
