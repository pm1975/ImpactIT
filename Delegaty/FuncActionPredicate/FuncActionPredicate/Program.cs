using System;

namespace FuncActionPredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            //skrót do tworzenia delegatu
            //Func<to co dostaje, to co otrzymujemy>
            Func<Double, Double> cpointer = r => Math.PI * r * r;
            double area = cpointer(20);
            Func<Double, Double, int> cpointer2 = (r, y) => (int)(Math.PI * r * y);
            double area2 = cpointer2(20, 20);

            //skrót do niezwracających niczego delegatów
            //Action - nie zwraca niczego. Jest to delegat typu void.
            Action<string> MyAction = s => Console.WriteLine(s);
            MyAction("To ja");

            //Zwraca prawdę lub fałsz
            Predicate<string> CheckIfStringIsGeatherThan5 = dowolnanazwa => dowolnanazwa.Length > 5;
            Console.WriteLine(CheckIfStringIsGeatherThan5("Ala ma kota"));

        }
    }
}
