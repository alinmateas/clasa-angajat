using System;
using System.Collections.Generic;

namespace Clasa_Angajat
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleQueue<Angajat> listaAngajati = new SimpleQueue<Angajat>();

            List<Angajat> angajati = FileManager.GetAngajati();
            foreach (var angajat in angajati)
            {
                listaAngajati.Add(angajat);
            }

            listaAngajati.Sort<Angajat>(); // metoda sorteaza in functie de vechime (masurata in luni)
        }
    }

   
}
