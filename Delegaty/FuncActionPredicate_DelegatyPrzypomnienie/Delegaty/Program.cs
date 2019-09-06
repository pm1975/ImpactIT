using System;

namespace Delegaty
{
    class Program
    {
        delegate double CalculateAreaPointer(double r);
        //static CalculateAreaPointer cpointer = CalculateArea;
        static void Main(string[] args)
        {
            //double area = cpointer.Invoke(20);

            //CalculateAreaPointer cpointer = new CalculateAreaPointer(
            //        delegate (double r)
            //        {
            //            return Math.PI * r * r;
            //        });
            //double area = cpointer(20);

            //lambda
            CalculateAreaPointer cpointer = r => Math.PI * r * r;
            double area = cpointer(20);
        }


        //static double CalculateArea(double r)
        //{
        //    return Math.PI * r * r;
        //}
    }
}
