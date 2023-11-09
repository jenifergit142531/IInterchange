using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SecretApp.Models;

namespace SecretApp.Controllers
{
    public class ElecController : Controller
    {
        public IConfiguration Configuration { get; }

        public ElecController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

       

        public IActionResult Index()
        {
            List<ElecInventory> inventoryList = new List<ElecInventory>();
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string selectQuery = "select * from ElecInventory";
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while(sdr.Read())
                    {
                        ElecInventory inventory = new ElecInventory();
                        inventory.Id = Convert.ToInt32(sdr["id"]);
                        inventory.Pname = Convert.ToString(sdr["pname"]);
                        inventory.Price = Convert.ToInt32(sdr["price"]);
                        inventory.Quantity = Convert.ToInt32(sdr["quantity"]);
                        inventory.Updateddate = Convert.ToDateTime(sdr["updateddate"]);
                        inventoryList.Add(inventory);

                    }
                    con.Close();
                }
            }

                return View(inventoryList);
        }
    }
}
