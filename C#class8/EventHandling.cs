using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_class8
{
    public delegate void delAlarm();
    public delegate void delTv();

    public class EventHandling
    {

        //create an event
        public event delAlarm press;
        public event delTv remote;


        public void raiseEvent()
        {
            press();
            remote();
        }

        


        public void alarm()
        {
            Console.WriteLine("Wake UP !!!! Wake UP ");
        }

        public void Tv()
        {
            Console.WriteLine("Changing channels in TV");
        }




    }
}
