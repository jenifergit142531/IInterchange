using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class11
{
    internal class Login : ILogin
    {

        public string username;

       
        public string pwd { get; set; }

        static SqlCommand cmd;

        public static string connectionString = "Data Source=REV-PG02C4Y5;Initial Catalog=property;Integrated Security=True;Persist Security Info=False;";

        public void ShowMenu()
        {

            Program p = new Program();
            p.Menu();
            Console.WriteLine("Would you like to continue (Y / N)");
            char choice = Convert.ToChar(Console.ReadLine());
            while (choice == 'Y' && choice != 'N')
            {
                p.Menu();
            }
        }
        public void LoginUserInput()
        {
            Console.WriteLine("Enter username");
            username = Console.ReadLine();
            Console.WriteLine("Enter password");
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter)
                {
                    pwd += keyInfo.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (keyInfo.Key != ConsoleKey.Backspace && pwd.Length > 0)
                    {
                        pwd = pwd.Substring(0, (pwd.Length - 1));
                       // Console.Write("\b \b");
                    }
                }

            } while (keyInfo.Key != ConsoleKey.Enter);

            Console.WriteLine();
            Console.WriteLine("_____________________________________");
          //  pwd = Console.ReadLine();
        }

        public void UserRegistration()
        {
            LoginUserInput();
            using (var con = new SqlConnection(connectionString))
            {

                
                using (var cmd = new SqlCommand("userregistration", con))
                {

                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@pwd", pwd);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("User registration successfull");
                    ShowMenu();

                }
            }
        }


        public void logincheck()
        {
            using (var con = new SqlConnection(connectionString))
            {

                LoginUserInput();

                using (var cmd = new SqlCommand("select dbo.loginchecking(@username,@pwd)", con))
                {
                    
                    
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@pwd", pwd);
                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                        

                    if (count == 1)
                    {

                        Console.WriteLine("welcome "+ username);
                        ShowMenu();


                    }
                    else
                    {
                        Console.WriteLine("User profile not available,Register Yourself");
                        Console.WriteLine("Choose \n 1.Register Yourself \n 2.Exit");
                        int options = Convert.ToInt32(Console.ReadLine());
                        switch(options)
                        {
                            case 1:
                                UserRegistration();
                                break;

                            case 2:
                                Environment.Exit(0);
                                break;
                            default:
                                break;
                        }
                        
                    }
                }
            }
        }
    }
}
    

