using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szenzorhalozat
{
    public abstract class Szenzor : ICloneable
    {

        private Pozicio pozicio;

        public Pozicio Pozicio
        {
            get { return pozicio; }
            private set 
            { 
                pozicio = value; 
            }
        }



        public Szenzor(Pozicio pozicio)
        {
            this.Pozicio = pozicio;
        }


        public override string ToString()
        {
            return String.Format("");
        }


        public abstract bool Aktiv
        {
            get;
        }

        public abstract string Adatkuldes();


        public abstract object Clone();
    }
}
