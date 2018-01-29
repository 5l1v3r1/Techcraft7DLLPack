using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Techcraft7_DLL_Pack
{
    public static class MoreMath
    {
        public static int Factorial(int input)
        {
            int output = input;
            bool error = false;
            try
            {
                for (int i = input - 1; i > 0; i--)
                {
                    output *= i;
                }
            }
            catch (Exception e)
            {
                error = true;
                return 0;
            }
            if (!error)
            {
                return output;
            }
            return 0;
        }
        public static int AbsoluteValue(int n)
        {
            if (n < 0)
            {
                n *= -1;
            }
            return n;
        }
        public static Point ReflectY(int x, int y)
        {
            x *= -1;
            Point output = new Point(x,y);
            return output;
        }
        public static Point ReflectX(int x, int y)
        {
            y *= -1;
            Point output = new Point(x, y);
            return output;
        }
        public static Point DialateOrigin(int x, int y, int scale_factor)
        {
            Point output = new Point(scale_factor * x, scale_factor * y);
            return output;
        }
        public static int DistanceUsingPythagTheory(int a, int b)
        {
            int output = 0;
            Convert.ToInt32(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
            return output;
        }
    }
}
