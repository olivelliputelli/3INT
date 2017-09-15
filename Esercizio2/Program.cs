using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variabili e inizializzazione
            double velocita = 0.0d;
            string condizioniStrada;
            double spazioFrenata = 0.0d;
            double coefficienteF = 0.0d;

            Console.WriteLine("************  Esercizio N. 2 ************");
            // INPUT
            Console.Write("Velocità: ");
            velocita = double.Parse(Console.ReadLine());

            Console.WriteLine("R - Asfalto ruvido");
            Console.WriteLine("L - Asfalto liscio");
            Console.WriteLine("B - Asfalto bagnato");
            Console.WriteLine("G - Asfalto ghiacciato");
            Console.Write("Condizioni stradali (R,L,B,G): ");
            condizioniStrada = Console.ReadLine().ToUpper();

            // ELABORAZIONE
            if(condizioniStrada == "R")
            {
                coefficienteF = 0.6;
            }
            else if(condizioniStrada == "L")
            {
                coefficienteF = 0.5;
            }
            else if (condizioniStrada == "B")
            {
                coefficienteF = 0.4;
            }
            else if (condizioniStrada == "G")
            {
                coefficienteF = 0.1;
            }
            spazioFrenata = Math.Pow(velocita, 2) / (250 * coefficienteF);
            
            // OUTPUT
            Console.WriteLine($"Lo spazio di frenata con velocià {velocita} km/h " +
                $"e condizioni stradali ({condizioniStrada}) è {spazioFrenata} metri.");
        }
    }
}
