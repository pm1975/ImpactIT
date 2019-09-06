using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield
{
    /// <summary>
    /// Yield - Słowo klucz w C# (filtruje listę)
    /// </summary>
    class Program
    {
        static List<int> myList = new List<int>();
        static void Main(string[] args)
        {
            FillList();
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            //Ta lista to kolejna instancja. Kolejne zaśmiecanie pamięci
            foreach (var item in Filter())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            //Yield - filtrowanie tej listy, którą już mamy
            foreach (var item in FilterYield())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            //Yield - np. sumowanie
            foreach (var item in Total())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        static void FillList()
        {
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
        }
        static IEnumerable<int> Filter()
        {
            List<int> tmp = new List<int>();
            foreach (var item in myList)
            {
                if (item > 3) tmp.Add(item);
            }
            return tmp;
        }

        //Yield - wydajność (tłum.)
        //Custom iteration - pierwsze zastosowanie
        static IEnumerable<int> FilterYield()
        {
            foreach (var item in myList)
            {
                if (item > 3) yield return item;
            }
        }

        //Streetfull iteration - drugie zastosowanie
        static IEnumerable<int> Total()
        {
            int totalNumber = 0;
            foreach (var item in myList)
            {
                totalNumber += item;
                yield return (totalNumber);
            }
        }

        /*
         * Yield - dwie podstawowe funkcje:
         * custom iteration
         * stejtfull iteration          
         * Jeżeli chcemy zachować stan, bądź stworzyć swój własny filtr
         * to yield jest waszym najlepszym przyjacielem.
         * IEnumerable i IQueryable są bezstanowe. 
         * Lecą przez całą kolekcję i mają wszystko w głębokim poważaniu.
         * Żeby zachować stan yield pozwala nam zachować stan,
         * wykonać operacje na IEnumerable ze stanem.
         * Dzięki temu możemy uzyskać takie filtry, które są bardzo, bardzo oszczędne.
         * Tak samo możemy robić przeróżne obliczenia, np. zliczanie tych liczb.
         * Yield - przyjaciel, który pozwala wykonywać iteracje customowe,
         * udziwnione, bądź sumaryczne, żeby zachować stan, w jakim jesteście w danej liście
         * czy też kolekcji
         */

    }

}
