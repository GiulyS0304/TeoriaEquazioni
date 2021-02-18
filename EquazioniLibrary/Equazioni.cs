using System;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            if (a != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsInconsisted(double a, double b)
        {
            if (a == 0 && b != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsDegree2(double a)
        {
            if (a == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static double Delta(double a, double b, double c)
        {
            double delta = (b * b) - (4 * a * c);
            return delta;
        }
    }   
}
