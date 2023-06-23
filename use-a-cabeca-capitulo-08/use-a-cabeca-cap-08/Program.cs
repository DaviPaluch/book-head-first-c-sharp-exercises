using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace use_a_cabeca_cap_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck( 17,KindOfDuck.Mallard),
                new Duck( 18,KindOfDuck.Muscovy),
                new Duck( 14,KindOfDuck.Decoy),
                new Duck( 11,KindOfDuck.Muscovy),
                new Duck( 14,KindOfDuck.Mallard),
                new Duck( 13,KindOfDuck.Decoy)
            };



            Console.WriteLine("Lista Sem Ordenação: ");
            foreach (Duck duck in ducks)
                Console.WriteLine(duck.ToString());



            DuckComparer_bySize duckComparer_BySize = new DuckComparer_bySize();

            ducks.Sort(duckComparer_BySize);



            Console.WriteLine("Lista Ordenada Por Peso: ");
            foreach (Duck duck in ducks)
                Console.WriteLine(duck.ToString());





            DuckComparer_byKind duckComparer_ByKind = new DuckComparer_byKind();

            ducks.Sort(duckComparer_ByKind);


            Console.WriteLine("Lista Ordenada por Tipo de Pato: ");
            foreach (Duck duck in ducks)
                Console.WriteLine(duck.ToString());



            DuckComparer duckComparer = new DuckComparer();
            ducks.Sort(duckComparer);

            Console.WriteLine("Lista Ordenada por Comparação Complexa: ");
            foreach (Duck duck in ducks)
                Console.WriteLine(duck.ToString());




            Console.ReadKey();
        }
    }
}
