using System;

namespace Rubrica
{
    public class Chiamata
    {
        public enum TipoChiamata { ENTRATA, USCITA };
        private Contatto contatto;
        private int durata;
        private int costo;
        TipoChiamata tipo;

        public Chiamata(Contatto contatto, int durata, int costo, TipoChiamata tipo)
        {
            this.contatto = contatto;
            this.durata = durata;
            this.costo = costo;
            this.tipo = tipo;
        }

        public override string ToString()
        {
            string tipo = (this.tipo == Chiamata.TipoChiamata.ENTRATA) ? "entrata da " : "uscita per ";
            return "Chiamata in " + tipo + contatto + " durata " + durata + " costo " + costo;
        }

        public Contatto getContatto()
        {
            return contatto;
        }

        public int getDurata()
        {
            return this.durata;
        }
    }


}