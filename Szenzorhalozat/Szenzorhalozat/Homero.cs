using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szenzorhalozat
{
    public class Homero : Szenzor, IHomero
    {

        // TODO:
        //      1. Implement ToString()
        //      2. Adatkuldes() -> StringBuilder?


        Random rnd = new Random();

        private int alsoHatar;

        public int AlsoHatar
        {
            get { return alsoHatar; }
            private set 
            {

                if (value < -60)
                    throw new AlacsonyAlsoHatarException("A megadott alsóhatár túl alacsony (Celsius)!");

                alsoHatar = value; 
            }
        }

        private int felsoHatar;

        public int FelsoHatar
        {
            get { return felsoHatar; }
            private set 
            { 
                felsoHatar = value; 
            }
        }

        private bool aktiv;

        public override bool Aktiv { get => aktiv; }


        public float HomersekletMer()
        {
            if (!Aktiv)
                throw new SzenzorInaktivException("A szenzor inaktív!");

            return (float)rnd.NextDouble() * (felsoHatar - alsoHatar + 1) + (alsoHatar + 1);

        }

        public void HatarokatBeallit(int also, int felso)
        {

            if (also > felso)
                throw new RosszHatarokException("Az alsó határérték nem lehet magasabb mint a felső");

            this.AlsoHatar = also;
            this.FelsoHatar = felso;

        }


        public void SetAktiv(bool ertek)
        {
            this.aktiv = ertek;
        }


        public Homero(int x, int y, int also, int felso)
        {
            Pozicio ujPozicio = new Pozicio(x, y);

            HatarokatBeallit(also, felso);
        }


        public override object Clone()
        {
            Homero ujHomero = new Homero(this.AlsoHatar, this.FelsoHatar, this.Aktiv);
            return ujHomero;
        }

        public override string ToString()
        {
            return String.Format("");
        }

        public override string Adatkuldes()
        {

            float homerseklet = HomersekletMer();

            return "(" + this.Pozicio.x + ";" + this.Pozicio.y + ") pozíción 2022.05.13. 16:53 időpontban " +
                    homerseklet.ToString("0.00") + " fok";
            
        }

    }
}
