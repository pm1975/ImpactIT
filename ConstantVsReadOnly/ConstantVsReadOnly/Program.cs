using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantVsReadOnly
{
    /// <summary>
    /// Constant vs ReadOnly
    /// </summary>
    class Program
    {
        public const int thisIsConst = 10; //Const - w trakcie kompilacji
        public static readonly double thisIsReadOnly = 99.66; // readonly - runtime

        public const string MyKey = "MyKey";
        public static readonly double betterPI = Math.PI;

        static Program()
        {
            //w momencie kiedy tworzymy klasę, czyli w runtime
            thisIsReadOnly = 10.11;
            betterPI = Convert.ToDouble(ConfigurationManager.AppSettings[MyKey], CultureInfo.InvariantCulture);
        }

        static void Main(string[] args)
        {
            //nie można - jest błąd
            //thisIsConst = 10;
            //thisIsReadOnly = 11.11;
        }
    }
}
