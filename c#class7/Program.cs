using c_class7;


delegate bool loginDelegate(string uname, string pwd);


delegate void MathOperation(int a);
class Program
{
    public static string uname;
    public static string pwd;
    public static void GetUserDetails()
    {
        Console.WriteLine("Enter the username :");
        uname = Console.ReadLine();
        Console.WriteLine("Enter the password :");
        pwd = Console.ReadLine();

    }
    public static void Main()
    {

        ActionDelegate.MyAction();
        //function delegate

        /*Func<int, int, int> f1 = FuncDelegate.sum;
        Console.WriteLine(f1(10, 10));*/

        /* func delegate with anonymous method 

        Func<int> generateRandom = delegate ()
        {
            Random rnd = new Random();
            return rnd.Next(1, 100);
        };

        Console.WriteLine(generateRandom());*/

        /* func delegate with lambda expression

        Func<int> randomnum = () => new Random().Next(60, 100);
        Console.WriteLine(randomnum());*/
        
       



        //anonymous delegate

       // Anonymous.CalcEven();

       /* MathOperation loop = delegate (int x)
        {
           for(int i=0;i<=x;i++)
            {
                Console.WriteLine(i);
            }

           
        };

        loop(10);*/

        


        //genericDeletegate<string> gd1 = Delegating.concat;
        //Console.WriteLine(gd1("hello", "world"));
       

        //genericDeletegate<int> gd2 = Delegating.add;
        //Console.WriteLine(gd2(10, 20));

        //genericDeletegate<double> gd3 = Delegating.area;
        //Console.WriteLine(gd3(45, 12));






       //loginDelegate userlogin = new loginDelegate(Authenticate.login);

      // loginDelegate userlogin2 = Authenticate.login;
        //Program.GetUserDetails();
        //bool result=userlogin(uname,pwd);
        //if(result)
        //{
        //    Console.WriteLine("Login successful !!!");
        //}
        //else
        //{
        //    Console.WriteLine("Login failes..try again");
        //}






        //set the target method


       // delSingle ds1 = new delSingle(Delegating.add);

        //ds1 += new delSingle(Delegating.sub);


        //ds1 += new delSingle(Delegating.multiply);

        //ds1 += new delSingle(Delegating.Divide);


        //delSingle ds2 = new delSingle(Delegating.sub);

        //invocation

        //ds1(100, 20);

        //ds2(30, 20);


    }
}