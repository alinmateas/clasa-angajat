using System;
using System.Collections.Generic;
using System.Text;

namespace Clasa_Angajat
{
    public static class FileManager
    {

        public static List<Angajat> GetAngajati()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\ALIN\source\repos\Clasa-Angajat\input.txt");
            List<Angajat> listaAngajati = GetLinesToList(lines);
            return listaAngajati;
        }

        private static List<Angajat> GetLinesToList(string[] lines)
        {
            List<Angajat> listaAngajati = new List<Angajat>();
            for (int i = 0; i < lines.Length; i++)
            {
                Angajat angajat = new Angajat();
                char[] seps = { ' ' };

                StringBuilder nume = new StringBuilder();
                StringBuilder prenume = new StringBuilder();

                string[] tokens = lines[i].Split(seps, StringSplitOptions.RemoveEmptyEntries);

                nume.Append(tokens[0]);
                prenume.Append(tokens[1]);


                string[] tokensVechime = tokens[2].Split(new char[] { '/' });
                short vechimeLuna = short.Parse(tokensVechime[0]);
                int vechimeAn = int.Parse(tokensVechime[1]);

                angajat.Nume = nume.ToString();
                angajat.Prenume = prenume.ToString();
                angajat.setVechime(vechimeAn, vechimeLuna);

                listaAngajati.Add(angajat);
            }

            return listaAngajati;
        }
    }
}