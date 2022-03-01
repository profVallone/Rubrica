using System.Collections;

namespace Rubrica
{
    public class ListaGenericaEnumerator : IEnumerator
    {
        private Nodo curr;
        private Nodo t;

        public ListaGenericaEnumerator(Nodo t)
        {
            this.t = t;
            curr = null;
        }

        public object Current { get { return curr; } }

        public bool MoveNext()
        {
            switch (curr)
            {
                case null:
                    curr = t;
                    return true;
                default:
                    if (curr.getSucc() != null)
                    {
                        curr = curr.getSucc();
                        return true;

                    }
                    else
                    {
                        return false;
                    }
            }
        }

        public void Reset()
        {
        curr = null;
        }
    }
}