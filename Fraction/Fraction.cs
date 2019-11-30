using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Fraction
    {
        protected long Chis;
        protected long Znam;

        public Fraction(long chis, long znam = 1)
        {
            Chis = chis;
            Znam = znam;
            Fix();
            Cut();
        }
        public Fraction(double chis)
        {
            long znam = 1;
            while (chis != Convert.ToInt32(chis))
            {
                chis *= 10;
                znam *= 10;
            }
            Chis = Convert.ToInt32(chis);
            Znam = znam;
            Fix();
            Cut();
        }

        public void Cut()
        {
            int max, min;
            if (Chis == Znam)
            {
                Chis = 1;
                Znam = 1;
            }
            else
            {
                if (Chis > Znam)
                {
                    max = Convert.ToInt32(Chis);
                    min = Convert.ToInt32(Znam);
                }
                else
                {
                    max = Convert.ToInt32(Znam);
                    min = Convert.ToInt32(Chis);
                }
                while (max % min != 0)
                {
                    int tmp = max % min;
                    max = min;
                    min = tmp;
                }
                Chis /= min;
                Znam /= min;
            }
        }

        public static Fraction operator +(Fraction a)
        {
            return a;
        }
        public static Fraction operator -(Fraction a)
        {
            a.Chis = -a.Chis;
            return a;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.Chis * b.Znam + a.Znam * b.Chis, a.Znam * b.Znam);
        }
        public static Fraction operator +(Fraction a, int b)
        {
            return new Fraction(a.Chis * 1 + a.Znam * b, a.Znam);
        }
        public static Fraction operator +(int a, Fraction b)
        {
            return new Fraction(a * b.Znam + 1 * b.Chis, b.Znam);
        }
        public static Fraction operator +(Fraction a, double c)
        {
            Fraction b = new Fraction(c);
            return new Fraction(a.Chis * b.Znam + a.Znam * b.Chis, a.Znam * b.Znam);
        }
        public static Fraction operator +(double c, Fraction b)
        {
            Fraction a = new Fraction(c);
            return new Fraction(a.Chis * b.Znam + a.Znam * b.Chis, a.Znam * b.Znam);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a.Chis * b.Znam - a.Znam * b.Chis, a.Znam * b.Znam);
        }
        public static Fraction operator -(Fraction a, int b)
        {
            return new Fraction(a.Chis * 1 - a.Znam * b, a.Znam);
        }
        public static Fraction operator -(int a, Fraction b)
        {
            return new Fraction(a * b.Znam - 1 * b.Chis,b.Znam);
        }
        public static Fraction operator -(Fraction a, double c)
        {
            Fraction b = new Fraction(c);
            return new Fraction(a.Chis * b.Znam - a.Znam * b.Chis, a.Znam * b.Znam);
        }
        public static Fraction operator -(double c, Fraction b)
        {
            Fraction a = new Fraction(c);
            return new Fraction(a.Chis * b.Znam - a.Znam * b.Chis, a.Znam * b.Znam);
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.Chis * b.Chis, a.Znam * b.Znam);
        }
        public static Fraction operator *(Fraction a, int b)
        {
            return new Fraction(a.Chis * b, a.Znam);
        }
        public static Fraction operator *(int a, Fraction b)
        {
            return new Fraction(a * b.Chis, b.Znam);
        }
        public static Fraction operator *(Fraction a, double c)
        {
            Fraction b = new Fraction(c);
            return new Fraction(a.Chis * b.Chis, a.Znam * b.Znam);
        }
        public static Fraction operator *(double c, Fraction b)
        {
            Fraction a = new Fraction(c);
            return new Fraction(a.Chis * b.Chis, a.Znam * b.Znam);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return a * !b;
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            if (Convert.ToDouble(a) == Convert.ToDouble(b))
                return true;
            else return false;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            if (Convert.ToDouble(a) != Convert.ToDouble(b))
                return true;
            else return false;
        }
        public static bool operator >(Fraction a, Fraction b)
        {
            if (Convert.ToDouble(a) > Convert.ToDouble(b))
                return true;
            else return false;
        }
        public static bool operator <(Fraction a, Fraction b)
        {
            if (Convert.ToDouble(a) < Convert.ToDouble(b))
                return true;
            else return false;
        }
        public static bool operator >=(Fraction a, Fraction b)
        {
            if (Convert.ToDouble(a) >= Convert.ToDouble(b))
                return true;
            else return false;
        }
        public static bool operator <=(Fraction a, Fraction b)
        {
            if (Convert.ToDouble(a) <= Convert.ToDouble(b))
                return true;
            else return false;
        }


        public static Fraction operator !(Fraction a)
        {
            Fraction b = new Fraction(a.Znam, a.Chis);
            b.Fix();
            return b;
        }
        public void Fix()
        {
            if ((Chis < 0 && Znam < 0) || (Chis > 0 && Znam < 0))
            {
                Chis = -Chis;
                Znam = -Znam;
            }
        }
        public static implicit operator double(Fraction a)
        {
            return Convert.ToDouble(a.Chis) / Convert.ToDouble(a.Znam);
        }
        public override string ToString()
        {
            return $"{Chis} / {Znam}";
        }



    }
}
