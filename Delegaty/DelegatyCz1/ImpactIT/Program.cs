using System;

namespace ImpactIT
{
    //class Program
    //{
    //    public delegate void SomeMethodDel();

    //    static void Main(string[] args)
    //    {
    //        SomeMethodDel someDele = SomeMethod;
    //        someDele.Invoke();
    //    }

    //    static void SomeMethod()
    //    {
    //        Console.WriteLine("Jestem tu!");
    //        Console.ReadKey();
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            SomeLongRunningData sm = new SomeLongRunningData();
            sm.SomeMethod(CallBackMethod);
            Console.ReadKey();
        }

        static void CallBackMethod(int i)
        {
            Console.WriteLine(i);
        }
    }

    class SomeLongRunningData
    {
        public delegate void CallBack(int i);
        public void SomeMethod(CallBack obj)
        {
            for (int i = 0; i < 1000; i++)
            {
                obj(i);
                // Robi się coś w tle
            }

        }
    }
    /*
     * Do zapamiętania:
     * Delegat odpowiada tylko za zwrot danych (tak zwane CallBack'i). Nic poza tym.
     */
}
