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

        public static string CalcoloEquazioneDiSecondoGrado(double a, double b, double c)
        {
            double delta = Delta(a, b, c);
            if (delta == 0)
            {
                double x1 = -b / (2 * a);
                return $"C'è solo una soluzione {x1}";
            }
            else if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return $"Ci sono due soluzioni {x1} e {x2}";
            }
            else if (delta < 0)
            {
                return "Non ci sono soluzioni, perchè l'equazione è IMPOSSIBILE";
            }
            else
            {
                return "Non è un'equazione di secondo grado";
            }
        }

        public static string EquationDegree1(double a, double b)
        {
            string risultato;

            if (a == 0 && b == 0)
            {
                risultato = "INDETERMINATA";
            }
            else if (IsInconsisted(a, b) == true)
            {
                risultato = "IMPOSSIBILE";
            }
            else
            {
                risultato = $"{-(b / a)}";
            }
            return risultato;
        }
    }   
}
