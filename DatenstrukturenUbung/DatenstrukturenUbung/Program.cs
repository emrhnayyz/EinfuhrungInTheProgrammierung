namespace DatenstrukturenUbung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklaration
            string input, secondHalf, verticalStr;
            int lenStr, firstOccurence_e;
            bool[] tests = new bool[4];

            //Eingabe
            Console.WriteLine("Bitte geben Sie einen String ein");
            input = Console.ReadLine();

            //Auswertung
            lenStr = input.Length;
            firstOccurence_e = input.IndexOf('e'); //-1, wenn nicht drin
            tests[0] = input == ""; //Leerstring
            tests[1] = input == input.ToUpper(); //keine Kleinbuchstaben
            tests[2] = !input.Contains(' ');
            // letztes Zeichen Buchstabe
            char letztesZeichen = input.ToLower().Last();
            string umlaute = "äöüß";
            tests[3] = letztesZeichen >= 97 && letztesZeichen <= 122 || umlaute.Contains(letztesZeichen); // a=97, z=122
                                                                                                          //weitere String
            secondHalf = input.Substring((lenStr - 1) / 2);
            verticalStr = input.Replace(',', '\n');
            string[] ergebnis = "Bananas,Milch,Eier,".Split(',');

            //Ausgabe
            Console.WriteLine("1:" + lenStr);
            Console.WriteLine("2:" + firstOccurence_e);
            Console.WriteLine("3:" + tests[0]);
            Console.WriteLine("4:" + tests[1]);
            Console.WriteLine("5:" + tests[2]);
            Console.WriteLine("6:" + tests[3]);
            Console.WriteLine("7:" + secondHalf);
            Console.WriteLine("8:" + verticalStr);

        }
    }
}