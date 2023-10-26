using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szgya_20231026_nepesseg
{
    class Orszag
    {
        public string Orszagnev { get; private set; }
        public int Terulet { get; private set; }
        public int Nepesseg { get; private set; }
        public string Fovaros { get; private set; }
        public int FovarosNepesseg { get; private set; }

        public int Nepsuruseg => this.Nepesseg / this.Terulet;

        public bool MeghaladjaA30Szazalekot => this.FovarosNepesseg > this.Nepesseg * 0.3;

        public Orszag(string orszagnev, int terulet, int nepesseg, string fovaros, int fovarosNepesseg)
        {
            this.Orszagnev = orszagnev;
            this.Terulet = terulet;
            this.Nepesseg = nepesseg;
            this.Fovaros = fovaros;
            this.FovarosNepesseg = fovarosNepesseg;
        }

        public Orszag(string sor)
        {
            string[] adatok = sor.Split(';');
            this.Orszagnev = adatok[0];
            this.Terulet = int.Parse(adatok[1]);
            this.Nepesseg = int.Parse(adatok[2].Replace("g","0000"));
            this.Fovaros = adatok[3];
            this.FovarosNepesseg = int.Parse(adatok[4]) * 1000;
        }

        public override string ToString()
        {
            return $"{this.Orszagnev} ({this.Fovaros})";
        }
    }

}
