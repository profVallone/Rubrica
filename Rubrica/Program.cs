using System;

namespace Rubrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Rubrica r = new Rubrica();
            r.add(new ContattoPersonale("Mario", "Rossi", "32112312344", "Amico"));
            r.add(new ContattoLavorativo("Mario", "Bianchi", "3458586779", "Capo"));
            r.add(new ContattoPersonale("Vittorio", "Verde", "3839988777", "Amico"));
            r.add(new ContattoLavorativo("Francesco", "Gallo", "3458586779", "Collega"));
            r.add(new ContattoPersonale("Marta", "Fiore", "32112312456", "Moglie"));

            Console.WriteLine("Elenco rubrica");
            Console.WriteLine(r);
            
            r.chiama("Verde");
            r.ricevi("Verde");
            r.chiama("Rossi");
            r.chiama("Gallo");
            r.ricevi("Bianchi");
            r.chiama("Fiore");

            Console.WriteLine("Elenco chiamate effettuate");
            r.getChiamate();

            Console.WriteLine("Elenco chiamate personali");
            r.getChiamatePersonali();

            Console.WriteLine("Elenco chiamate lavorative");
            r.getChiamateLavorative();

            Console.WriteLine("Chiamata più lunga");
            Console.WriteLine(r.getChiamataLunga());

            Console.WriteLine("Persona chiamata più spesso");
            Console.WriteLine(r.getContattoFrequente());
        }
    }
}
