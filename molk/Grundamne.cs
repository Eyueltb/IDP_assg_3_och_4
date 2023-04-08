using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace molk
{
    public class Grundamne
    {
        public string namn;
        public int Z;
        public string typ;
        public double smaltpunkt;
        public double kokpunkt;

        public Grundamne(string namn, int Z, string typ, double smaltpunkt, double kokpunkt)
        {
            this.namn = namn;
            this.Z = Z;
            this.typ = typ;
            this.smaltpunkt = smaltpunkt;
            this.kokpunkt = kokpunkt;
        }

        public void Print()
        {
            Console.WriteLine($"Grundämne: {namn}\n" +
                              $"Atomnummer: {Z}\n" +
                              $"typ: {typ}\n" +
                              $"smältpunkt: {smaltpunkt} K\n" +
                              $"kokpunkt: {kokpunkt} K");
        }
    }
}
