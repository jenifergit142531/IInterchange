using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class CRUDClass
    {
        public static void SelectMovie()
        {

            using (var context = new EFCoreContext())
            {
                foreach (var i in context.TamilMovies)
                {
                    Console.WriteLine("Movie Name " + i.MovieName);
                    Console.WriteLine("Seats " + i.Seats);
                    Console.WriteLine("Ticket Price " + i.Price);
                }
            }
        }
        public static void InsertMovie()
        {
            using (var context = new EFCoreContext())
            {
                List<Movie> movies = new List<Movie>
                {
                    new Movie{MovieName="Leo",Seats=2,Price=300},
                     new Movie{MovieName="dd2",Seats=3,Price=500},
                      new Movie{MovieName="jailer",Seats=4,Price=700},
                };

                foreach(var i in movies)
                {
                    context.TamilMovies.Add(i);
                }
               
                context.SaveChanges();
                Console.WriteLine("Movie is successfully added");

            }
        }
            public static void UpdateMovie()
            {
            using (var context = new EFCoreContext())
            {
                var updatemovie = context.TamilMovies.FirstOrDefault(x => x.MovieName == "Leo");
                updatemovie.MovieName = "vikram";
                context.SaveChanges();
                Console.WriteLine("updated");
            }
            }
            public static void DeleteMovie()
            {
            using (var context = new EFCoreContext())
            {
                var updatemovie = context.TamilMovies.FirstOrDefault(x => x.MovieName == "dd2");
                context.TamilMovies.Remove(updatemovie);
                context.SaveChanges();
                Console.WriteLine("deleted");
            }
            }
        }
    }

