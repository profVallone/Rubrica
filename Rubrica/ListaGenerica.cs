using System;
using System.Collections;

namespace Rubrica
{
    public class ListaGenerica: IEnumerable
    {
        private Nodo t;
        private Nodo c;
        private int dim;
        public ListaGenerica()
        {
            dim = 0;
        }

        public void add(Nodo n)
        {
            if (t == null)
            {
                t = n;
                c = n;
            }
            else
            {
                c.setSucc(n);
                c = n;
            }
            dim++;
           
        }

        public int getDim()
        {
            return dim;
        }
       
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }

        public ListaGenericaEnumerator GetEnumerator()
        {
            return new ListaGenericaEnumerator(this.t);
        }
    }
}