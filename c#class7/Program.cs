using c_class7;


delegate bool loginDelegate(string uname, string pwd);
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
        loginDelegate userlogin = Authenticate.login;
        Program.GetUserDetails();
        bool result=userlogin(uname,pwd);
        if(result)
        {
            Console.WriteLine("Login successful !!!");
        }
        else
        {
            Console.WriteLine("Login failes..try again");
        }






        //set the target method


        //delSingle ds1 = new delSingle(Delegating.add);


        //ds1 += new delSingle(Delegating.multiply);


        //delSingle ds2 = new delSingle(Delegating.sub);

        //invocation

        //ds1(10, 20);

        //ds2(30, 20);


    }
}