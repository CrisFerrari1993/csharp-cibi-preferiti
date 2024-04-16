using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] favouriteFoods = { "sushi", "pizza", "pasta al regu", "paella", "pizzoccheri", "cheesecake" };
            //- La lunghezza della classifica
            Console.WriteLine($"L'array è lungo {favouriteFoods.Length}");
            //-La vostra classifica(dunque stampare l’intero array in ordine indicando la posizione in classifica)
            Array.Sort(favouriteFoods);
            for(int i = 0; i < favouriteFoods.Length; i++)
            {
                Console.WriteLine($"Numero {i + 1} : {favouriteFoods[i]}");
            }
            //- Il vostro cibo top (prima posizione della classifica)
            Console.WriteLine($"Il mio piatto prefertito è {favouriteFoods.First()}");
            //- Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
            Console.WriteLine($"Il mio piatto prefertito ma non troppo è {favouriteFoods.Last()}");

            //BONUS
            //Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana.Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari. In questo caso vanno stampati i 2 elementi in centro alla vostra classifica.

            // variabile che prende l'indice degli elementi nella metà
            int startIndex = (favouriteFoods.Length - 3) / 3;

            // stampo gli elementi a meta classifica a schermo
            for (int i = startIndex; i < startIndex + 2; i++)
            {
                Console.WriteLine($"Elemento a metà classifica: {favouriteFoods[i]}");
            }
        }
    }
}
