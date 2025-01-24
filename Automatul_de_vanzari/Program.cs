using System;

namespace AutomatVanzari
{
    class Program
    {
        static void Main(string[] args)
        {
            Automat automat = new Automat();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nSuma actuala: " + automat.Suma + " centi");
                Console.WriteLine("Alegeți o opțiune:");
                Console.WriteLine("1. Inserare Nichel (5 centi)");
                Console.WriteLine("2. Inserare Dime (10 centi)");
                Console.WriteLine("3. Inserare Sfert (25 centi)");
                Console.WriteLine("4. Cere produs");
                Console.WriteLine("5. Iesire");

                string optiune = Console.ReadLine();

                switch (optiune)
                {
                    case "1":
                        automat.InseraMoneda(5); 
                        break;
                    case "2":
                        automat.InseraMoneda(10); 
                        break;
                    case "3":
                        automat.InseraMoneda(25); 
                        break;
                    case "4":
                        automat.CereProdus();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Optiune invalida.Va rugam sa incercati din nou.");
                        break;
                }
            }
        }
    }

    class Automat
    {
        public int Suma { get; private set; }

        public Automat()
        {
            Suma = 0;
        }

        public void InseraMoneda(int valoare)
        {
            Suma += valoare;
            Console.WriteLine("Ati inserat " + valoare + " centi.");
        }

        public void CereProdus()
        {
            if (Suma >= 20)
            {
                Console.WriteLine("Produsul a fost eliberat.");
                Suma -= 20;

                if (Suma > 0)
                {
                    Console.WriteLine("Rest: " + Suma + " centi.");
                }
                else
                {
                    Console.WriteLine("Nu mai aveti rest.");
                }
            }
            else
            {
                Console.WriteLine("Nu aveti suficienti bani pentru a cumpara produsul (20  necesari).");
            }
            Console.ReadKey();
        }

    }
}