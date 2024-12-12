using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public class Auto
    {
        public string Marke;
        public int PS;
        public int AktuelleGeschwindigkeit;
        public int AktuellerGang;
        public bool IstMotorGestartet;
        public int TankFuellstand;

        public Auto(string marke, int ps) {
            Marke = marke;
            PS = ps;
        }
        public void Auftanken()
        {
            if (IstMotorGestartet == false) 
            TankFuellstand = 1001;
        }
        public void Bremse()
        {
            if (AktuelleGeschwindigkeit > 0)
            {
                AktuelleGeschwindigkeit -= 20;
            }

            Schalten();       
        }

        private void Schalten()
        {
            if (AktuelleGeschwindigkeit < 11)
                AktuellerGang = 1;
            else if (AktuelleGeschwindigkeit < 21)
                AktuellerGang = 2;
            else if (AktuelleGeschwindigkeit < 41)
                AktuellerGang = 3;
            else if (AktuelleGeschwindigkeit < 71)
                AktuellerGang = 4;
            else if (AktuelleGeschwindigkeit < 101)
                AktuellerGang = 5;
            else
                AktuellerGang = 6;
        }
        public void GibGas()
        {
            if (IstMotorGestartet == true && TankFuellstand > 0)
            {
                if (PS < 50 )
                {
                    if (AktuelleGeschwindigkeit < 100)
                    AktuelleGeschwindigkeit += 5;
                    TankFuellstand -= 5;
                    if (TankFuellstand <= 0)
                    {
                        AktuelleGeschwindigkeit = 0;
                        IstMotorGestartet = false;
                    }


                }
                else if (PS < 100 )
                {
                    if (AktuelleGeschwindigkeit < 150)
                    AktuelleGeschwindigkeit += 10; 
                    TankFuellstand -= 10;
                    if (TankFuellstand <= 0)
                    {
                        AktuelleGeschwindigkeit = 0;
                        IstMotorGestartet = false;
                    }

                }
                else if (PS < 150)
                {
                    if (AktuelleGeschwindigkeit < 200)
                        AktuelleGeschwindigkeit += 15; 
                        TankFuellstand -= 20;
                    if (TankFuellstand <= 0)
                    {
                        AktuelleGeschwindigkeit = 0;
                        IstMotorGestartet = false;
                    }
                }
                else if (PS < 200)
                {
                    if (AktuelleGeschwindigkeit < 250)
                        AktuelleGeschwindigkeit += 20; 
                        TankFuellstand -= 40;
                    if (TankFuellstand <= 0)
                    {
                        AktuelleGeschwindigkeit = 0;
                        IstMotorGestartet = false;
                    }
                }
                else if (PS < 250)
                {
                    if (AktuelleGeschwindigkeit < 300)
                        AktuelleGeschwindigkeit += 25;
                        TankFuellstand -= 50;
                    if (TankFuellstand <= 0)
                    {
                        AktuelleGeschwindigkeit = 0;
                        IstMotorGestartet = false;
                    }
                }
                else if (PS < 300)
                {
                    if (AktuelleGeschwindigkeit < 350)
                        AktuelleGeschwindigkeit += 30;
                        TankFuellstand -= 60;
                    if (TankFuellstand <= 0)
                    {
                        AktuelleGeschwindigkeit = 0;
                        IstMotorGestartet = false;
                    }

                }
                else if (PS < 350)
                {
                    if (AktuelleGeschwindigkeit < 425)
                        AktuelleGeschwindigkeit += 35;
                        TankFuellstand -= 70;
                    if (TankFuellstand <= 0)
                    {
                        AktuelleGeschwindigkeit = 0;
                        IstMotorGestartet = false;
                    }
                }
                else if (PS < 400)
                {
                    if (AktuelleGeschwindigkeit < 500)
                        AktuelleGeschwindigkeit += 40;
                        TankFuellstand -= 75;
                    if (TankFuellstand <= 0)
                    {
                        AktuelleGeschwindigkeit = 0;
                        IstMotorGestartet = false;
                    }
                }
            }

            Schalten();
        }
        public void Hupe()
        {
            MessageBox.Show("Hup Hup XD");
        }
        public void SchalteMotorAus()
        {
            IstMotorGestartet = false;
        }
        public void StarteMotor()
        {
            IstMotorGestartet=true;
    }
        override public string ToString()
        {
            return Marke;
        }
    }
}
