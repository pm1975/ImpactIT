using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    public class AgendaManager
    {
        public delegate void AddedAgendaEventHandler(object o, AgendaEventArgs e);
        public event AddedAgendaEventHandler AddedAgenda;

        //Pabliszer eventu
        /// <summary>
        /// Event publisher powinien być (konwencja)
        /// 1. protected
        /// 2. virtual
        /// 3. void
        /// 4. Nazwa powinna zaczynać się na "On"
        /// </summary>
        protected virtual void OnAddedAgenda(Agenda newAgenda)
        {
            if (AddedAgenda != null)
                AddedAgenda(this, new AgendaEventArgs() { Agenda = newAgenda });
        }
        public void AddAgenda(Agenda newAgenda)
        {
            Console.WriteLine("AddAgenda: Zaczynam dodawać ...");
            Thread.Sleep(3000);
            OnAddedAgenda(newAgenda); //tu publisher podnosi event
            Console.WriteLine("AddAgenda: Skonczylem dodawać ...");
        }
    }
}
