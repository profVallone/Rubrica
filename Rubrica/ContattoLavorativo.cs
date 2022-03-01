namespace Rubrica
{
    internal class ContattoLavorativo : Contatto
    {
        private static readonly int costo = 1;
        private string ruolo;



        public ContattoLavorativo(string nome, string cognome, string numero, string ruolo)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.numero = numero;
            this.ruolo = ruolo;
        }

        public override void chiama(ListaGenerica chiamate)
        {
            int durata = new System.Random().Next(1, 20);
            int costo = durata * ContattoLavorativo.costo;
            Chiamata c = new Chiamata(this, durata, costo, Chiamata.TipoChiamata.USCITA);
            chiamate.add(new Nodo(c));
        }

        public override void ricevi(ListaGenerica chiamate)
        {
            int durata = new System.Random().Next(1, 20);
            int costo = 0;
            Chiamata c = new Chiamata(this, durata, costo, Chiamata.TipoChiamata.ENTRATA);
            chiamate.add(new Nodo(c));
        }

        public override bool Equals(object obj)
        {
            ContattoLavorativo c = (ContattoLavorativo)obj;
            return (this.nome == c.nome &&
                this.cognome== c.cognome&&
                this.numero == c.numero &&
                this.ruolo == c.ruolo);
        }
    }
}