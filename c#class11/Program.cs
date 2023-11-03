

using c_class11;
using System.ComponentModel.Design;

class Program
{
    public void Menu()
    {
        Console.WriteLine("Choose \n 1.View All property \n 2.Insert Property \n 3.Update Property \n 4.Delete Property \n 5.Exit");
        Console.WriteLine("What do you Need ????");
        int options = Convert.ToInt32(Console.ReadLine());
        PropertyADO prop1 = new PropertyADO();

        switch (options)
        {

            case 1:
                prop1.GetPropertyDetails();
                break;
            case 2:
                prop1.InsertProperty();
                break;
            case 3:
                prop1.UpdateProperty();
                break;
            case 4:
                prop1.DeleteProperty();
                break;
            case 5:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid option");
                break;

        }
    }
    public static void Main()
    {
        Console.WriteLine("Welcome to Fera Luxe Property Management");
        Console.WriteLine("\n **************************************");
        Program p = new Program();
        Login lg = new Login();
        lg.logincheck();
        //p.Menu();
        
        
    }
}
        

        

        // prop1.GetPropertyById();
        // PropertyADO.check();
        //prop1.InsertProperty();
        //prop1.DeleteProperty();
        //prop1.UpdateProperty();

       // PropertyADO.GetPropertyDetails();
       // TaskParallel.TaskParallelism();

        //DataParallel.ShowLoop();
        //SimpleTask.IndianFood();
        //SimpleTask.ChineseFood();
        //SimpleTask.Continental();
    
