using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeratorVsIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List
            List<int> myList = new List<int>();
            myList.Add(100);
            myList.Add(200);
            myList.Add(300);
            myList.Add(400);
            myList.Add(1001);
            myList.Add(1002);
            myList.Add(1004);
            #endregion

            //korzysta z enumeratora
            //IEnumerable<int> ienumerable = myList.AsEnumerable();

            //foreach (var item in ienumerable)
            //{
            //    Console.WriteLine(item);
            //}

            //-----------------------
            //wie w jakim stanie numeracji się znajduje
            //gdy będziemy go przekazywać dalej, będzie zachowywał stan kursora w którym był
            IEnumerator<int> ienumerator = myList.GetEnumerator();

            //while(ienumerator.MoveNext())
            //{
            //    Console.WriteLine(ienumerator.Current.ToString());
            //}
            LoopTo1000(ienumerator);
            Console.ReadKey();
        }

        static void LoopTo1000(IEnumerator<int> e)
        {
            while (e.MoveNext())
            {
                Console.WriteLine(e.Current.ToString());
                if (e.Current > 999)
                {
                    LoopAbove1000(e);
                }
            }
        }

        private static void LoopAbove1000(IEnumerator<int> e)
        {
            while (e.MoveNext())
            {
                Console.WriteLine(e.Current.ToString());
            }
        }


    }
}
