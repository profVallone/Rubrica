using System;

namespace Rubrica
{
    public abstract class Contatto
    {
        protected string nome;
        protected string cognome;
        protected string numero;

        public Contatto(string nome, string cognome, string numero)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.numero = numero;
        }
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