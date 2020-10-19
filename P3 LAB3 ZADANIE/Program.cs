using System;
using System.Dynamic;
using System.Text;

namespace P3_LAB3_ZADANIE
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckString();
            TableSum();

        }
        static void CheckString()
        {
            Console.WriteLine("Podaj zdanie.");
            string? zdanie = Console.ReadLine();
           
            if (string.IsNullOrEmpty(zdanie))
            {
                Console.WriteLine("Pusty String!");
            }
            else if(!zdanie.EndsWith("."))
            {
                zdanie = zdanie += ".";
            }

            zdanie = zdanie.Trim();
            zdanie = char.ToUpper(zdanie[0]) + zdanie.Substring(1);
         
            zdanie = string.Join(" ", zdanie.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries));    // zaczynamy od split który dzieli string na podciągi oraz usuwa puste podciągi 
            Console.WriteLine(zdanie);                                                                               // następnie join łączy te podciągi wraz z separatorem " "
        }

        static void TableSum()
        {
            Console.Write("Podaj pierwszy wymiar tablicy: ");
            int firstDimension = int.Parse(Console.ReadLine());
            int secondDimension;

            double[][] tablica = new double[firstDimension][];  // definicja z deklaracją pierwszgo wymiaru tablicy poszarpanej

            Random rnd = new Random();

            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write("Podaj drugi wymiar tablicy: ");
                secondDimension = int.Parse(Console.ReadLine());
                tablica[i] = new double[secondDimension];       // drugi wymiar podany przez użytkownika

                //tablica[i] = new double[rnd.Next(10)];        // losowa długość drugiego wymiaru
                //tablica[i] = new double[2];                   // test
                for (int j = 0; j < tablica[i].Length; j++)
                {
                    //Console.WriteLine(tablica[i].Length);
                    tablica[i][j] = rnd.Next(100);              // wartości z zakresu 0-100
                    //tablica[i][j] = 10;                       // test
                }
            }

            double suma = 0;

            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica[i].Length; j++)
                {
                    suma += tablica[i][j];
                    //Console.WriteLine(suma);
                    Console.WriteLine($"Wartość po indeksem [{i}][{j}]  {tablica[i][j]}, suma: {suma}");
                }
            }
            Console.WriteLine($"Suma: {suma}");
        }
    }
}
