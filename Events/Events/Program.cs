using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Eventy - jak plakaty na słupie informacyjnym
            Odbiorcy dostają informację, że coś się wydarzyło i reagują na to zdarzenie (event).
            Tworzymy niezależne aplikacje blokowe, gdzie jeden blok nie zależy od drugiego.
            Komunikują się pomiędzy sobą zdarzeniami.
            Zmieniając coś w jednym bloku, nie zmieniamy w drugim, 
            dlatego że event w jednym bloku tylko się podnosi, a drugi tylko na niego reaguje.
            Mamy luźne połączenie pomiędzy blokami kodu.
            Tu: symulujemy to AgendaManagerem i SMSSenderem.

            */
            AgendaManager amgr = new AgendaManager();
            SMSSender sms = new SMSSender();

            //sms oczekuje, że jak się coś pojawi, to on coś zrobi
            amgr.AddedAgenda += sms.OnAddedAgenda;

            amgr.AddAgenda(new Agenda()
            {
                AgendaDate = DateTime.Now.AddDays(2),
                AgendaName = "Kubuś Puchatek i złote gatki"
            });


            Console.ReadKey();
        }


    }
}
