using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFractionClassPractice
{
    public class Fraction
    {
        public int Top { get; set; }
        public int Bottom { get; set; }

        public Fraction(int top = 0, int bottom = 1)
        {

        }

        public static Fraction operator +(Fraction left, Fraction right)
        {
            int newTop = (left.Top * right.Bottom) + (left.Bottom * right.Top);
            int newBottom = left.Bottom * right.Bottom;
            return new Fraction(newTop, newBottom);
        }

        public static Fraction operator -(Fraction left, Fraction right)
        {
            int newTop = (left.Top * right.Bottom) - (left.Bottom * right.Top);
            int newBottom = left.Bottom * right.Bottom;
            if (newTop < 0)
            {
                throw new Exception("Fractions are negative");
            }
            else
                return new Fraction(newTop, newBottom);
        }

        public override string ToString()
        {
            return $"Your new fraction is: {Top}/{Bottom}";
        }
    }
}
