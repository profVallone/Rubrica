using System;

namespace Rubrica
{
    public abstract class Contatto
    {
        protected string nome;
        protected string cognome;
        protected string numero;

        public abstract void chiama(ListaGenerica chiamate);
        public abstract void ricevi(ListaGenerica chiamate);

        public string getCognome()
        {
            return cognome;
        }

        public override string ToString()
        {
            return nome + " " + cognome;
        }
    }
}