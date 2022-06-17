using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szenzorhalozat
{
    public class SzenzorHalozat : IEnumerable<Szenzor>
    {

        private List<Szenzor> szenzorok = new List<Szenzor>();

        public void Telepit(Szenzor ujSzenzor)
        {
            szenzorok.Add(ujSzenzor);
        }

        public double AtlagAlsoHatar()
        {
            int also = 0;
            int i = 0;

            foreach (Homero item in szenzorok)
            {
                i++;
                also += item.AlsoHatar;
            }

            return also / i;
        }


        public List<Szenzor> SzenzorokRendezve()
        {

            List<Szenzor> aktivak = new List<Szenzor>();

            foreach (Szenzor item in szenzorok)
                if(item.Aktiv)
                    aktivak.Add(item);


            int min = aktivak[0].Pozicio.x;
            int temp;

            aktivak = aktivak.OrderBy(objektum => objektum.Pozicio.x).ToList();
            aktivak = aktivak.OrderBy(objektum => objektum.Pozicio.y).ToList();

            return aktivak;

        }

        
        public IEnumerator<Szenzor> GetEnumerator()
        {
            foreach (Szenzor item in szenzorok)
            {
                if (item.Aktiv)
                    yield return (Szenzor)item.Clone();
            }
        }

    }
}
