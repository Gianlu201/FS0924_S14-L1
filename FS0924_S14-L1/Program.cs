using System;
using System.Text;

namespace FS0924_S14_L1
{
    using FS0924_S14_L1.Models;

    internal static class Program
    {
        static List<Food> foods = new List<Food>()
        {
            new Food() { Name = "Coca Cola 150ml", Price = 2.5 },
            new Food() { Name = "Insalata di pollo", Price = 5.2 },
            new Food() { Name = "Pizza Margherita", Price = 10 },
            new Food() { Name = "Pizza 4 Formaggi", Price = 12.5 },
            new Food() { Name = "Pz patatine fritte", Price = 3.5 },
            new Food() { Name = "Insalata di riso", Price = 8 },
            new Food() { Name = "Frutta di stagione", Price = 5 },
            new Food() { Name = "Pizza fritta", Price = 5 },
            new Food() { Name = "Piadina vegetariana", Price = 6 },
            new Food() { Name = "Panino Hamburger", Price = 7.9 },
        };

        static List<int> conto = new List<int>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            bool loop = true;

            while (loop)
            {
                ShowMenu();
                string? option = Console.ReadLine();

                if (int.TryParse(option, out int scelta))
                {
                    switch (scelta)
                    {
                        case <= 0:
                            // Opzione non valida
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nOpzione non valida, riprova..");
                            Console.ReadKey();
                            Console.ResetColor();
                            break;

                        case < 11:
                            conto.Add(scelta);
                            break;

                        case 11:
                            loop = false;
                            break;

                        case > 11:
                            // Opzione non valida
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nOpzione non valida, riprova..");
                            Console.ReadKey();
                            Console.ResetColor();
                            break;
                    }
                }
                else
                {
                    // Opzione non valida
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOpzione non valida, riprova..");
                    Console.ReadKey();
                    Console.ResetColor();
                }
            }

            // FUNZIONE PER CALCOLARE CONTO
            CalcolaConto();
            Console.ReadKey();
        }

        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("==============MENU==============");
            for (int i = 0; i < foods.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {foods[i].Name} (€{foods[i].Price:0.00})");
            }
            Console.WriteLine("11: Stampa conto finale e conferma");
            Console.WriteLine("==============MENU==============\n");
            Console.Write("Inserisci opzione: ");
        }

        static void CalcolaConto()
        {
            double? sum = 0;

            Console.WriteLine("\n\n");
            Console.WriteLine("======Riepilogo======");
            foreach (int i in conto)
            {
                Console.WriteLine($"- {foods[i].Name} (€{foods[i].Price:0.00})");
                sum += foods[i].Price;
            }

            Console.WriteLine($"\nTotal: €{sum:0.00}");
        }
    }
}
