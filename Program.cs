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
            listaAngajati.SortByName<Angajat>(); // metoda sorteaza in functie de nume
            FileManager.Output(listaAngajati, @"C:\Users\ALIN\source\repos\Clasa-Angajat\outputByName.txt");
            listaAngajati.Sort<Angajat>(); // metoda sorteaza in functie de vechime (masurata in luni)
            FileManager.Output(listaAngajati, @"C:\Users\ALIN\source\repos\Clasa-Angajat\outputBySeniority.txt");
        }
    }

   
}
