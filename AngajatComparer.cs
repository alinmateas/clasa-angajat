using System;
using System.Collections;

namespace Clasa_Angajat
{
    class AngajatComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Angajat x1 = (Angajat)x;
            Angajat y1 = (Angajat)y;
            return x1.Nume[0].CompareTo(y1.Nume[0]);
        }
    }
}
