using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public interface IDraw
    {
        int drawJ(int x, int y, int res, int Width, int Height, double wx, double wy, double zoom, double pointX, double pointY, int iteretion);
        int drawM(int x, int y, int res, int Width, int Height, double wx, double wy, double zoom, double pointX, double pointY, int iteretion);
    }
}
