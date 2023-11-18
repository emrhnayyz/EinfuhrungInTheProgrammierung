using System;

namespace Hausaufgabe02_1
{
    class Program
    {
        static void Main()
        {
            
            Console.Write("Bitte geben Sie die Anzahl Ihrer Geschwister ein: ");
            uint varUInt = uint.Parse(Console.ReadLine());

            
            Console.Write("Bitte geben Sie den Wert von Pi (π) aus dem Gedächtnis ein: ");
            double varDbl = double.Parse(Console.ReadLine());

            
            Console.Write("Bitte geben Sie Ihr persönliches Lebensmotto ein: ");
            string varStr1 = Console.ReadLine();

            
            Console.Write("Bitte geben Sie eine Potenz im Format a^b (z.B. 2^11) ein: ");
            string input = Console.ReadLine();
            string[] parts = input.Split('^');
            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            string varStr2 = $"{a}^{b}";

            
            bool[] arrBool = new bool[3];
            arrBool[0] = (varUInt > 0);  
            arrBool[1] = (varUInt % 2 == 0);  
            arrBool[2] = (Math.Abs(varDbl - Math.PI) <= 0.01);  

            
            string[] arrStr = new string[2];
            arrStr[0] = a.ToString();  
            arrStr[1] = b.ToString();  

            
            Console.WriteLine("Anzahl Geschwister: " + varUInt);
            Console.WriteLine("Pi (π) aus dem Gedächtnis: " + varDbl);
            Console.WriteLine("Persönliches Lebensmotto: " + varStr1);
            Console.WriteLine("Potenz (a^b): " + varStr2);

            Console.WriteLine("Ergebnisse der Tests (arrBool):");
            Console.WriteLine("Hat die Person Geschwister? " + arrBool[0]);
            Console.WriteLine("Ist die Anzahl der Geschwister gerade? " + arrBool[1]);
            Console.WriteLine("Schätzung von π ist maximal 0.01 abweichend? " + arrBool[2]);

            Console.WriteLine("Potenzeingabe (arrStr):");
            Console.WriteLine("Basis a: " + arrStr[0]);
            Console.WriteLine("Exponent b: " + arrStr[1]);
        }
    }
}
