using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class SMSSender
    {
        //własna implementacja eventu. On będzie odbiorcą eventu.
        //musi mieć taką samą liczbę argumetów i nazwę co publisher.
        public void OnAddedAgenda(object o, AgendaEventArgs e)
        {
            Console.WriteLine("SMS Sender: SMS was send !!! Date:" + e.Agenda.AgendaDate + " Tytuł: " + e.Agenda.AgendaName);
        }

    }
}
