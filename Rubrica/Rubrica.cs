using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubrica
{
    class Rubrica
    {
        private ListaGenerica contatti;
        private ListaGenerica chiamate;

        public Rubrica() 
        {
            Console.WriteLine("Rubrica creata");
            contatti = new ListaGenerica();
            chiamate = new ListaGenerica();
        }
        public void add(Contatto c)
        {
            contatti.add(new Nodo(c));
            Console.WriteLine("Aggiunto nuovo contatto");
        }

        public void chiama(string v)
        {
            Contatto c = cerca(v);
            if (c != null)
            {
                c.chiama(this.chiamate);
            }
            else
            {
                Console.WriteLine("Contatto non trovato!");
            }
        }

        public void getChiamatePersonali()
        {
            string ris = "";
            foreach (Nodo n in chiamate)
            {
                Chiamata c = (Chiamata)n.getVal();
                if (c.getContatto() is ContattoPersonale)
                ris += c.ToString() + "\n";
            }
            Console.WriteLine(ris);

        }

        public Contatto getContattoFrequente()
        {
            int maxVal = 0;
            Contatto maxC = null;
            foreach (Nodo n in chiamate)
            {
                Chiamata k = (Chiamata)n.getVal();
                Contatto c = k.getContatto();
                int count = 0;
                foreach (Nodo n2 in chiamate)
                {
                    Chiamata j = (Chiamata)n2.getVal();
                    Contatto c2 = j.getContatto();
                    if (c.GetType() == c2.GetType() && c2.Equals(c))
                    {
                        count++;
                    }
                }
                if (count > maxVal)
                {
                    maxVal = count;
                    maxC = c;
                }
            }
            return maxC;
        }
    

        public Chiamata getChiamataLunga()
        {
            Chiamata ris = null;
            ListaGenericaEnumerator en = chiamate.GetEnumerator();
            if (en.MoveNext())
            {
                Nodo n = (Nodo)en.Current;
                ris = (Chiamata)n.getVal();
            }
            else
            {
                return null;
            }
            
            foreach (Nodo n in chiamate)
            {
                Chiamata c = (Chiamata)n.getVal();
                if (c.getDurata() > ris.getDurata())
                {
                    ris = c;
                }
            }
            return ris;
        }

        public void getChiamateLavorative()
        {
            string ris = "";
            foreach (Nodo n in chiamate)
            {
                if (((Chiamata)n.getVal()).getContatto() is ContattoLavorativo)
                    ris += ((Chiamata)n.getVal()).ToString() + "\n";
            }
            Console.WriteLine(ris);

        }

        public void getChiamate()
        {

            string ris = "";
            foreach (Nodo n in chiamate)
            {
                ris += ((Chiamata)n.getVal()).ToString() + "\n";
            }
            Console.WriteLine(ris);
        }

        public void ricevi(string v)
        {
            Contatto c = cerca(v);
            if (c != null)
            {
                c.ricevi(chiamate);
            }
            else
            {
                Console.WriteLine("Contatto non trovato!");
            }
        }

        private Contatto cerca(string v)
        {
            foreach(Nodo n in contatti)
            {
                Contatto c = (Contatto)n.getVal();
                if (c.getCognome().Equals(v))
                {
                    return c;
                }
            }
            return null;
        }

        public override string ToString()
        {
            string ris = "";
            foreach(Nodo n in contatti)
            {
                Contatto c = (Contatto)n.getVal();
                ris += c.ToString() + "\n";
            }
            return ris;
        }

        
    }
}
