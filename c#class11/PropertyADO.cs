using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class11
{
    internal class PropertyADO : IProperty
    {
        public static string pname;
        public static string oname;
        public static int page;
        public static int price;
        public static DateTime pdate;
        public string id;



        public static string connectionString = "Data Source=REV-PG02C4Y5;Initial Catalog=property;Integrated Security=True;Persist Security Info=False;";

        public void GetPropertyDetails()
        {
            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand("getproperty", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Property Id :{reader["propid"]}," + "\n" +
                                $"Property Name :{reader["propname"]}," + "\n" +
                                $"Owner Name :{reader["ownername"]}," + "\n" +
                                $"Property Age :{reader["propage"]}," + "\n" +
                                $"Property Price :{reader["propprice"]}," + "\n" +
                                $"Property Posted Date :{reader["postedDate"]}");
                        }
                    }
                }

            }
        }


        public void GetUserInput()
        {
            Console.WriteLine("Enter the property name :");
            pname = Console.ReadLine();

            Console.WriteLine("Enter the owner name :");
            oname = Console.ReadLine();

            Console.WriteLine("Enter the age of the property :");
            page = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the property price :");
            price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the last posted date :");
            pdate = Convert.ToDateTime(Console.ReadLine());
        }

        public void GetPropertyByName()
        {
            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand("getpropertybyname", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@propname", pname);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Property Id :{reader["propid"]}," + "\n" +
                                $"Property Name :{reader["propname"]}," + "\n" +
                                $"Owner Name :{reader["ownername"]}," + "\n" +
                                $"Property Age :{reader["propage"]}," + "\n" +
                                $"Property Price :{reader["propprice"]}," + "\n" +
                                $"Property Posted Date :{reader["postedDate"]}");
                        }
                    }
                }
            }
        }
        public void InsertProperty()
        {
            GetUserInput();
            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand("insertproperty", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@propname", pname);
                    cmd.Parameters.AddWithValue("@ownername", oname);
                    cmd.Parameters.AddWithValue("@propage", page);
                    cmd.Parameters.AddWithValue("@propprice", price);
                    cmd.Parameters.AddWithValue("@postedDate", pdate);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Property details successfully added");
                    Console.WriteLine("Please find the property details below :");

                    //GetPropertyById();
                    GetPropertyByName();


                }
            }
        }

        public void UpdateProperty()
        {
            GetPropertyById();
            Console.WriteLine("Please enter the details to be updated");
            GetUserInput();
            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand("updateProperty", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@propname", pname);
                    cmd.Parameters.AddWithValue("@ownername", oname);
                    cmd.Parameters.AddWithValue("@propage", page);
                    cmd.Parameters.AddWithValue("@propprice", price);
                    cmd.Parameters.AddWithValue("@postedDate", pdate);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Property details successfully updated");
                   

                }
            }
        }
        public void DeleteProperty()
        {

            GetPropertyById();
            
            Console.WriteLine("Are you sure that you want to delete this property ? (Y /N)");
            char choice = Convert.ToChar(Console.ReadLine());
            if (choice == 'Y')
            {
                using (var con = new SqlConnection(connectionString))
                {
                    using (var cmd = new SqlCommand("deleteproperty", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                Console.WriteLine("Property successfully deleted");
            }
            else
            {
                Console.WriteLine("Property not deleted ");
                GetPropertyDetails();
            }
        }

        public void GetPropertyById()
        {
            Console.WriteLine("Enter the property Id :");
            id = Console.ReadLine();
            Console.WriteLine("*************************************************");
            Console.WriteLine("Please find the property details below :");
            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand("getpropertybyid", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@propid", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Property Id :{reader["propid"]}," + "\n" +
                                $"Property Name :{reader["propname"]}," + "\n" +
                                $"Owner Name :{reader["ownername"]}," + "\n" +
                                $"Property Age :{reader["propage"]}," + "\n" +
                                $"Property Price :{reader["propprice"]}," + "\n" +
                                $"Property Posted Date :{reader["postedDate"]}");
                        }
                    }
                }
            }
        }
    }
}


