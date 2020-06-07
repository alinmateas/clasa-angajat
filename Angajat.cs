using System;
using System.Collections;

namespace Clasa_Angajat
{
    public class Angajat : IAngajat, IComparable
    {
        private string nume;
        private string prenume;
        private short lunaAngajare;
        private int anAngajare;

        public Angajat()
        {
        }

        public Angajat(string nume, string prenume, short lunaAngajare, int anAngajare)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.lunaAngajare = lunaAngajare;
            this.anAngajare = anAngajare;
        }


        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public int Vechime => GetVechime();

        public int CompareTo(object obj)
        {
            Angajat other = (Angajat)obj;

            if (this.GetVechime() > other.GetVechime())
                return -1;
            else if(this.GetVechime() < other.GetVechime())
                return 1;
            
            return 0;
        }

        private int GetVechime() //returneaza vechimea unui angajat in luni
        {
            DateTime dataCurenta = DateTime.Now;
            int anCurent = dataCurenta.Year;
            int lunaCurenta = dataCurenta.Month;

            int luniRamase = 0, aniRamasi = 0;

            if(lunaAngajare >  lunaCurenta)
            {
                luniRamase = 12 - lunaAngajare - lunaCurenta;
                aniRamasi = anCurent % 100 - anAngajare - 1;
            }
            else
            {
                luniRamase = lunaCurenta - lunaAngajare;
                aniRamasi = anCurent % 100 - anAngajare;
            }

            return luniRamase + aniRamasi * 12;
        }

        public void setVechime(int an, short luna)
        {
            this.anAngajare = an;
            this.lunaAngajare = luna;
        }
    }
}