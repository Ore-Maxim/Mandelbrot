using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public interface IComplex
    {
        void Sqr();
        double Magn();
        void Add(Complex c);
    }
}
