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

        public static void Output(SimpleQueue<Angajat> listaAngajati, string path)
        {
            string[] lines = GetAngajatiInLines(listaAngajati);

            System.IO.File.WriteAllLines(path, lines);
        }

        private static string[] GetAngajatiInLines(SimpleQueue<Angajat> listaAngajati)
        {
            StringBuilder[] lines = new StringBuilder[listaAngajati.Count];
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = new StringBuilder();
            }

            Angajat[] angajati = listaAngajati.RetrieveAll();
            for (int i = 0; i < angajati.Length; i++)
            {
                lines[i].Append(angajati[i].Nume + " " + angajati[i].Prenume + "  |   " + GetLuna(angajati[i].Vechime) + " Luni " + "si " + GetAn(angajati[i].Vechime) + " Ani" );
            }

            string[] linesString = new string[listaAngajati.Count];
            for (int i = 0; i < linesString.Length; i++)
            {
                linesString[i] = lines[i].ToString();
            }

            return linesString;
        }

        private static string GetAn(int vechime)
        {
            return (vechime / 12).ToString();
        }

        private static string GetLuna(int vechime)
        {
            return (vechime % 12).ToString();
        }
    }
}