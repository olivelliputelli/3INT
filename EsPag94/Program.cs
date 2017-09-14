using System;

class Program
{
    static void Main()
    {
        int anno, mese, giorno, Y, M, D;

        // INPUT
        // cout << "Anno: ";
        // cin >> anno;
        Console.Write("Anno: ");
        anno = int.Parse(Console.ReadLine());

        Console.Write("Mese: ");
        mese = int.Parse(Console.ReadLine());

        Console.Write("Giono: ");
        giorno = int.Parse(Console.ReadLine());

        //ELABORAZIONE
        Y = anno;
        M = mese - 2;

        if(M <= 0)
        {
            Y = Y - 1;
            M = M + 12;
        }
        D = ((giorno + Y + (Y / 4) - (Y / 100) + (Y / 400) + (31 * M / 12)) % 7);

        //OUTPUT
        Console.WriteLine($"Risultato = {D}");      


    }
}

