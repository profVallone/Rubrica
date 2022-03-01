using System;

namespace Rubrica
{
    public class Nodo
    {
        private Nodo succ;
        private object val;

        public Nodo(object val)
        {
            this.val = val;
        }

        public void setSucc(Nodo n)
        {
            this.succ = n;
        }

        public Nodo getSucc()
        {
            return this.succ;
        }

        public object getVal()
        {
            return val;
        }
    } 
}