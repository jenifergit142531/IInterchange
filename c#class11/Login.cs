using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class11
{
    internal class Login : ILogin
    {

        public string uname;
        public string pwd;
        static SqlCommand cmd, cmd2;

        public static string connectionString = "Data Source=REV-PG02C4Y5;Initial Catalog=property;Integrated Security=True;Persist Security Info=False;";

        public void check()
        {
            Console.WriteLine("Enter username");
            uname = Console.ReadLine();
            Console.WriteLine("Enter password");
            pwd = Console.ReadLine();
        }


        public void logincheck()
        {
            using (var con = new SqlConnection(connectionString))
            {


                con.Open();

                using (var cmd = new SqlCommand("select count(*) from login where username = @uname AND pwd=@pwd", con))
                {

                    cmd.Parameters.AddWithValue("@username", uname);
                    cmd.Parameters.AddWithValue("@pwd", pwd);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {

                        Console.WriteLine("Existing user");
                    }
                    else
                    {
                        Console.WriteLine("Invalid user");
                        //logincheck();

                        //cmd2 = new SqlCommand("insert into login values(@uname,@pwd)", con);
                        //{                       
                        //    cmd2.ExecuteNonQuery();
                        //    Console.WriteLine("User is successfully registered");
                        //}
                    }
                }
            }
        }
    }
}
    

