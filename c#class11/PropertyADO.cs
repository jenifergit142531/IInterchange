using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class11
{
    internal class PropertyADO
    {
        public static string connectionString = "Data Source=REV-PG02C4Y5;Initial Catalog=property;Integrated Security=True;Persist Security Info=False;";
        public static void GetPropertyDetails()
        {
            using (var con = new SqlConnection(connectionString))
            {
                using (var cmd=new SqlCommand("getproperty",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
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
        public static void InsertProperty()
        {

        }
        public static void UpdateProperty()
        {

        }
        public static void DeleteProperty()
        {

        }
    }
}
