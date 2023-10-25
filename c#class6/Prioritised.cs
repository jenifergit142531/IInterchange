using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class6
{
    internal class Prioritised
    {

        public static void browsingHistory()
        {
            Stack<string> history = new Stack<string>();
            history.Push("w3schools");
            history.Push("hotstar - avatar");
            history.Push("Classroom - assigment");
            history.Push("watched kavala song");

            foreach(var i in history)
            {
                Console.WriteLine(i);
            }

            history.Pop();
            Console.WriteLine("After back button in browser :");
            foreach (var i in history)
            {
                Console.WriteLine(i);
            }
        }

        public static void LuggageSystem()
        {
            Queue luggage = new Queue();
            luggage.Enqueue("Handbag");
            luggage.Enqueue("Backpack");
            luggage.Enqueue("Trolley");
            luggage.Enqueue(100);
            foreach (var i in luggage)
            {
                Console.WriteLine(i);
            }

            luggage.Dequeue();
            Console.WriteLine("After dequeue :");
            foreach (var i in luggage)
            {
                Console.WriteLine(i);
            }



        }
    }
}
