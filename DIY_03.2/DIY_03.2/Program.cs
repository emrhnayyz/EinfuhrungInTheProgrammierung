using System;

namespace DIY_03._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a) if-Struktur
            Console.Write("Geben Sie die Nummer der Vorlesung ein: ");
            int vorlesung = Convert.ToInt32(Console.ReadLine());

            string textIf = "";

            if (vorlesung == 0 || vorlesung == 1 || vorlesung == 2)
            {
                textIf = "Diese Vorlesung habe ich mir bereits angeschaut.";
            }
            else if (vorlesung == 3)
            {
                textIf = "Mit dieser Vorlesung befasse ich mich gerade.";
            }
            else if (vorlesung >= 4 && vorlesung <= 7)
            {
                textIf = "Diese Vorlesung erwartet mich später.";
            }
            else
            {
                textIf = "Es gibt keine Vorlesung mit dieser Nummer.";
            }

            Console.WriteLine("if-Struktur: " + textIf);

            // b) switch...case-Struktur
            string textSwitch = "";

            switch (vorlesung)
            {
                case 0:
                case 1:
                case 2:
                    textSwitch = "Diese Vorlesung habe ich mir bereits angeschaut.";
                    break;
                case 3:
                    textSwitch = "Mit dieser Vorlesung befasse ich mich gerade.";
                    break;
                case 4:
                case 5:
                case 6:
                case 7:
                    textSwitch = "Diese Vorlesung erwartet mich später.";
                    break;
                default:
                    textSwitch = "Es gibt keine Vorlesung mit dieser Nummer.";
                    break;
            }

            Console.WriteLine("switch...case-Struktur: " + textSwitch);

            // c) switch-Ausdruck
            string textSwitchExpression = vorlesung switch
            {
                0 or 1 or 2 => "Diese Vorlesung habe ich mir bereits angeschaut.",
                3 => "Mit dieser Vorlesung befasse ich mich gerade.",
                >= 4 and <= 7 => "Diese Vorlesung erwartet mich später.",
                _ => "Es gibt keine Vorlesung mit dieser Nummer."
            };

            Console.WriteLine("switch-Ausdruck: " + textSwitchExpression);
        }
    }
}
