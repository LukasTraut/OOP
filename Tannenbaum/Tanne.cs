using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaum
{
    public class Tanne
    {
        int sb;
        int sh;
        int kh;
        string zeichnung;

        public int Sb
        {
            get { return sb; }
            set { sb = value;  }
        }

        public int Sh
        {
            get { return sh; }
            set { sh = value; }
        }
        public int Kh
        {
            get { return kh; }
            set { kh = value; }
        }
        public string Zeichnung
        {
            get { return zeichnung; }
            set {zeichnung = value;}
        }

        public void Zeichnen()
        {
            ZeichneKrone(kh);
            ZeichneStamm(sb, sh, kh);
        }

        private void ZeichneKrone(int kronenhöhe)
        {
            int Kronen_Abstand = kronenhöhe - 1;
            int stern = 1;
            for (int h = 0; h <= kronenhöhe - 1; h++)
            {
                for (int a = 0; a < Kronen_Abstand; a++)
                {
                   zeichnung += " ";
                }
                for (int s = 0; s < stern; s++)
                {
                    zeichnung += "*"; // Console.Write("*");
                }
                stern += 2;

                zeichnung += "\r\n";

                Kronen_Abstand--;
            }
        }
        private void ZeichneStamm(int stammbreite, int stammhöhe, int kronenhöhe)
        {
            int sba = kronenhöhe / 2;
            string SH = kronenhöhe.ToString();
            int kronenbreite = (kronenhöhe * 2) - 1;
            int links_space = (kronenbreite / 2) - 1;

            string kronen = new string('*', stammbreite);
            string links_string = new string(' ', links_space);
            for (int ls = 0; ls <= stammhöhe - 1; ls++)
            {
                zeichnung += links_string + kronen + "\r\n";
            }
        }

     }
}
