using System;

namespace Clasa_Angajat
{
    public class Angajat : IAngajat
    {
        private string nume;
        private string prenume;
        private short lunaAngajare;
        private short anAngajare;

        public Angajat(string nume, string prenume, short lunaAngajare, short anAngajare)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.lunaAngajare = lunaAngajare;
            this.anAngajare = anAngajare;
        }


        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public int Vechime => GetVechime();

        private int GetVechime()
        {
            DateTime dataCurenta = DateTime.Now;
            int anCurent = dataCurenta.Year;
            int lunaCurenta = dataCurenta.Month;

            int luniRamase = 0, aniRamasi = 0;
            if(lunaAngajare >  lunaCurenta)
            {
                luniRamase = 12 - lunaAngajare - lunaCurenta;
                aniRamasi = anCurent - anAngajare - 1;
            }
            else
            {
                luniRamase = lunaCurenta - luniRamase;
                aniRamasi = anCurent - anAngajare;
            }

            return luniRamase + aniRamasi * 12;
        }
    }
}