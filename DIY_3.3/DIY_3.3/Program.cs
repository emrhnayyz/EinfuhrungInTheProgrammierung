using System;

namespace DIY_03.III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a) Durch 5 teilbare Zahlen zwischen 25 und 50 ausgeben
            Console.WriteLine("a) Durch 5 teilbare Zahlen zwischen 25 und 50:");
            for (int i = 25; i <= 50; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // b) Halbierungsschritte zählen
            Console.Write("\nb) Eine Zahl eingeben: ");
            double zahlB = Convert.ToDouble(Console.ReadLine());
            int halbierungsSchritte = 0;

            while (zahlB >= 1)
            {
                zahlB /= 2;
                halbierungsSchritte++;
            }

            Console.WriteLine($"Anzahl der Halbierungsschritte: {halbierungsSchritte}");

            // c) Zahl im Intervall [5;10] einlesen
            double zahlC;
            do
            {
                Console.Write("\nc) Eine Zahl im Intervall [5;10] eingeben: ");
                zahlC = Convert.ToDouble(Console.ReadLine());

            } while (zahlC < 5 || zahlC > 10);

            Console.WriteLine($"Die eingegebene Zahl im Intervall [5;10] ist: {zahlC}");

            // d) Zahl erraten Spiel
            Random random = new Random();
            int gesuchteZahl = random.Next(101);
            int versuche = 0;
            int gerateneZahl;

            do
            {
                Console.Write("\nd) Ratet eine Zahl zwischen 0 und 100: ");
                gerateneZahl = Convert.ToInt32(Console.ReadLine());
                versuche++;

                if (gerateneZahl < gesuchteZahl)
                {
                    Console.WriteLine("Die gesuchte Zahl ist größer.");
                }
                else if (gerateneZahl > gesuchteZahl)
                {
                    Console.WriteLine("Die gesuchte Zahl ist kleiner.");
                }
                else
                {
                    Console.WriteLine($"Herzlichen Glückwunsch! Du hast die richtige Zahl {gesuchteZahl} gefunden!");
                }

            } while (gerateneZahl != gesuchteZahl);

            Console.WriteLine($"Anzahl der Versuche: {versuche}");
        }
    }
}
