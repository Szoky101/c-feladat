using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirintus
{
    class LabSim
    {
        private List<string> Adatsorok;
        private char[,] Lab;

        public bool KeresesKesz { get; set; }
        public int KijaratOszlopIndex => OszlopokSzama - 1;
        public int KijaratSorIndex => SorokSzama - 2;
        public bool NincsMegoldas { get; set; }
        public int OszlopokSzama => Adatsorok[0].Length;
        public int SorokSzama => Adatsorok.Count;

        private void BeolvasAdatsorok(string forras)
        {
            foreach (var sor in File.ReadAllLines(forras)) this.Adatsorok.Add(sor);
        }

        private void FeltoltLab()
        {

        }

        public void KiirLab()
        {
 
        }

        public LabSim(string forras)
        {
            this.Adatsorok = new List<string>();
            BeolvasAdatsorok(forras);
            Lab = new char [SorokSzama, OszlopokSzama];
            FeltoltLab();
        }

        public void Utkereses()
        {
            KeresesKesz = false;
            NincsMegoldas = false;
            int r = 1; 
            int c = 0; 
            while (!KeresesKesz && !NincsMegoldas)
            {
                Lab[r, c] = 'O';
                if (Lab[r, c + 1] == ' ')
                {
                    c++;
                }
                else if (Lab[r + 1, c] == ' ')
                {
                    r++;
                }
                else
                {
                    Lab[r, c] = '-';
                    if (Lab[r, c - 1] == 'O')
                    {
                        c--;
                    } 
                    else
                    {
                        r--;
                    } 
                }
                KeresesKesz = r == KijaratSorIndex && c == KijaratOszlopIndex;
                if (KeresesKesz) Lab[r, c] = 'O';
                NincsMegoldas = r == 1 && c == 0;
            }
        }

    }
}
