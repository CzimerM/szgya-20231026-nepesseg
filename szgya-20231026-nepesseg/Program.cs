using System;
using System.Text;

namespace szgya_20231026_nepesseg
{
    class Program
    {
        public static void Main(string[] args) 
        {
            var orszagok = new List<Orszag>();

            var sr = new StreamReader("../../../src/adatok-utf8.txt", Encoding.UTF8);
            _ = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                orszagok.Add(new Orszag(sr.ReadLine()));
            }

            Console.WriteLine($"4.feladat\nA beolvasott országok száma {orszagok.Count}");

            Console.WriteLine($"5.feladat\nKína népsűrűsége: {orszagok.Find(o => o.Orszagnev == "Kína").Nepsuruseg} fő/km^2");

            Console.WriteLine($"6.feladat\nKínában a lakosság {orszagok.Find(o => o.Orszagnev == "Kína").Nepesseg - orszagok.Find(o => o.Orszagnev == "India").Nepesseg} fővel volt több.");

            var harmadik = orszagok.OrderByDescending(o => o.Nepesseg).ToList()[2];
            Console.WriteLine($"7.feladat\nA harmadik legnépesebb ország: {harmadik.Orszagnev}, a lakosság {harmadik.Nepesseg} fő.");

            Console.WriteLine("8. feladat - A következő országok lakosságának több mint 30%-a a fővárosban lakik");
            var fovarosbanTobbMintHarminc = orszagok.Where(o => o.MeghaladjaA30Szazalekot);
            foreach (var orszag in fovarosbanTobbMintHarminc)
            {
                Console.WriteLine($"\t{orszag}");
            }

        }
    }
}
