using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Wuerfel
    {
        Random r = new Random();
        int aktuellerWurf;
        int letzterWurf;
        List<int> alle = new List<int>();

        public int LetzterWurf
        {
            get { return letzterWurf; }
        }
        public string Alle()
        {
            string l = "";
            foreach (int i in alle) {
                l += i;
            }

            return l;

        }

        public int Werfen()
        { 
            letzterWurf = aktuellerWurf;
            aktuellerWurf = r.Next(1, 7);
            alle.Add(aktuellerWurf);
            return aktuellerWurf;
        }
        
    }
}
