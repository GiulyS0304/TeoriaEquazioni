using System;
using EquazioniLibrary;

namespace RisoluzioniEquazioni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RISOLUZIONE DI UN'EQUAZIONE");
            Console.WriteLine();
            Console.WriteLine("RICORDA!!");
            Console.WriteLine("Equazione di 1° grado = ax + b");
            Console.WriteLine("Equazione di 2° grado = ax^2 + bx + c");
            Console.WriteLine();
            Console.WriteLine("Che tipo di equazione vuoi risolvere?");
            Console.WriteLine("Digita 1 = Equazione di 1° grado o digita 2 = Equazione di 2° grado");

            string risposta = Console.ReadLine();
            if (risposta == "1")
            {
                Console.WriteLine();
                Console.WriteLine("Inserisci il valore del coefficiente a e b");
                Console.Write("ax = ");
                double ax = Convert.ToInt32(Console.ReadLine());
                Console.Write("b = ");
                double b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (Equazioni.IsDetermined(ax) == true)
                {
                    Console.WriteLine("L'equazione è DETERMINATA!!");
                    Console.WriteLine($"Il risultato è uguale a: {Equazioni.EquationDegree1(ax, b)}");
                }
                else if (Equazioni.IsInconsisted(ax, b) == true)
                {
                    Console.WriteLine("L'equazione è IMPOSSIBILE!!");
                }
                else 
                {
                    Console.WriteLine("L'equazione è INDETERMINATA!!");
                }
               
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Inserisci il valore del coefficiente a, b e del termine noto c");
                Console.Write("ax^2 = ");
                double ax2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("bx = ");
                double bx = Convert.ToInt32(Console.ReadLine());
                Console.Write("c = ");
                double c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                if (Equazioni.IsDegree2(ax2) == true)
                {
                    Console.WriteLine("Hai azzeccato!! L'equazione è di secondo grado");
                    Console.WriteLine();
                    Console.WriteLine("RICORDA!!");
                    Console.WriteLine("• Se il delta < 0 = equazione IMPOSSIBILE, non ci sono soluzioni");
                    Console.WriteLine("• Se il delta > 0 = ci sono due soluzioni");
                    Console.WriteLine("• Se il delta = 0 = c'è una sola soluzione");
                    Console.WriteLine();
                    Console.WriteLine(Equazioni.CalcoloEquazioneDiSecondoGrado(ax2, bx, c));
                }
                else
                {
                    Console.WriteLine("ATTENZIONE!! L'equazione non è di secondo grado");
                    Console.WriteLine("Riprova a rinserire i valori correttamente");
                }
                
            }


        }
    }
}
