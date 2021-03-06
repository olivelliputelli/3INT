﻿using System;

/// <summary>
/// Implementare un programma che, 
/// letto il valore del raggio, 
/// calcoli e scriva l'area del cerchio relativo.
/// </summary>
class Es1Pag67
{
    static void Main()
    {
        // dichiarazione ed 
        // inizializzazione delle variabili.
        double raggio = 0, area = 0;

        // INPUT
        Console.Write("Raggio: ");
        raggio = double.Parse(Console.ReadLine());
        
        // ELABORAZIONE
        area = Math.PI * Math.Pow(raggio,2);

        // OUTPUT
        Console.WriteLine($"Area = {area}");
    }
}

