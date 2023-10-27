

using C_class8;
using System;
using System.ComponentModel.DataAnnotations;

class Program
{
   
    public static void Main()
    {
        RegisterPage rp = new RegisterPage();
       
            Console.WriteLine("Enter the userid :");
            rp.UserId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the user name :");
            rp.UserName = Console.ReadLine();
            Console.WriteLine("Enter the phone number :");
            rp.Phoneno = Console.ReadLine();
            Console.WriteLine("Enter the email :");
            rp.Email = Console.ReadLine();

       
        ValidationContext context = new ValidationContext(rp);
        List<ValidationResult> results = new List<ValidationResult>();
        bool valid = Validator.TryValidateObject(rp, context, results, true);
        if(!valid)
        {
            foreach(ValidationResult vr in results)
            {
                Console.WriteLine(vr.ErrorMessage);
            }
        }



        // Lambda.sample();

        //EventHandling ev = new EventHandling();

        //ev.press += new delAlarm(ev.alarm);

        //ev.remote += new delTv(ev.Tv);

        //ev.raiseEvent();
    }
}
