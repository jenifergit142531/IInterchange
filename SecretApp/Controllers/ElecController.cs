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
            string connectionString = Configuration["ConnectionStrings:ElecConnection"];
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string selectQuery = "select * from ElecInventory";
                SqlCommand cmd = new SqlCommand(selectQuery, con);
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        ElecInventory inventory = new ElecInventory();
                        inventory.Id = Convert.ToInt32(sdr["id"]);
                        inventory.Pname = Convert.ToString(sdr["pname"]);
                        inventory.Price = Convert.ToInt32(sdr["price"]);
                        inventory.Quantity = Convert.ToInt32(sdr["quantity"]);
                        inventory.Updateddate = Convert.ToDateTime(sdr["updateddate"]);
                        inventoryList.Add(inventory);

                    }

                }
                con.Close();
            }

            return View(inventoryList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ElecInventory inventory)
        {
            string connectionString = Configuration["ConnectionStrings:ElecConnection"];
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                string insertQuery = $"insert into ElecInventory(id,pname,price,quantity,updateddate)" +
                    $"values ('{inventory.Id}','{inventory.Pname}','{inventory.Price}','{inventory.Quantity}','{inventory.Updateddate}')";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }

                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ElecInventory inventory = new ElecInventory();
            string connectionString = Configuration["ConnectionStrings:ElecConnection"];
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                string getId = $"select * from ElecInventory where id='{id}'";
                con.Open();
                SqlCommand cmd = new SqlCommand(getId, con);
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {

                        inventory.Id = Convert.ToInt32(sdr["id"]);
                        inventory.Pname = Convert.ToString(sdr["pname"]);
                        inventory.Price = Convert.ToInt32(sdr["price"]);
                        inventory.Quantity = Convert.ToInt32(sdr["quantity"]);
                        inventory.Updateddate = Convert.ToDateTime(sdr["updateddate"]);


                    }

                }
                con.Close();

            }

            return View(inventory);
        }

        [HttpPut]
        public IActionResult Update(ElecInventory inventory, int id)
        {
            string connectionString = Configuration["ConnectionStrings:ElecConnection"];
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                string updateQuery = $"update ElecInventory set pname='{inventory.Pname}'," +
                    $"price='{inventory.Price}',quantity = '{inventory.Quantity}',updateddate='{inventory.Updateddate}' where id='{id}'";


                SqlCommand cmd = new SqlCommand(updateQuery, con);
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }


                return RedirectToAction("Index");
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            string connectionString = Configuration["ConnectionStrings:ElecConnection"];
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string deleteQuery = "delete from ElecInventory where id='{id}'";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            return RedirectToAction("Index");
        }
    }
}
