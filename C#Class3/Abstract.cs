using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Class3
{
    //abstract class Movie
      class Movie
    {

        //public abstract void movieList();

        public virtual void movieList()
        {
            Console.WriteLine("All lanugages  movies are included in this list ");
        }
        public void showTimings()
        {
            Console.WriteLine("Three shows available : Morning,Matinee and Night show");
        }
    }
    class Tollywood : Movie
    {
        public override void movieList()
        {
            Console.WriteLine("1.Leo \n 2.Vikram \n 3.LGM ");
        }
    }
    class Hollywood : Tollywood
    {
        public override void movieList()
        {
            Console.WriteLine("1.Avatar \n 2.Tenet \n 3.Inception ");
        }
    }
}
