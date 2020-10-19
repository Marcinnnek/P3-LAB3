using System;
using System.Dynamic;

namespace P3_LAB3_ZADANIE
{
    class Program
    {
        static void Main(string[] args)
        {
            TableSum();
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
                    Console.WriteLine(suma);
                    Console.WriteLine($"wartość po indeksem {i}, {j} {tablica[i][j]} ");
                }
            }
            Console.WriteLine($"suma: {suma}");
        }
    }
}
