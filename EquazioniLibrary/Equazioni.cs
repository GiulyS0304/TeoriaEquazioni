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

        public static bool IsInconsisted(double b)
        {
            if (b != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
