namespace Rubrica
{
    public class ContattoPersonale : Contatto
    {
        private static readonly int costo = 2; 
        private string relazione;

        public ContattoPersonale(string nome, string cognome, string numero, string relazione) : base(nome, cognome, numero)
        {
            this.relazione = relazione;
        }

        public override void chiama(ListaGenerica chiamate)
        {
            int durata = new System.Random().Next(1,20);
            int costo = durata * ContattoPersonale.costo;
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
            ContattoPersonale c = (ContattoPersonale)obj;
            return (this.nome == c.nome &&
                this.cognome == c.cognome &&
                this.numero == c.numero &&
                this.relazione == c.relazione);
        }
    }
}