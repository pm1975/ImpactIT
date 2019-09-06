using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Customer Customers = new Customer();
            Customers.GetAddress("Nisko");
            Customers.GetAddress(1234567);

            var a = Customers[1234567];
            var b = Customers["Nisko"];

        }
    }
}
