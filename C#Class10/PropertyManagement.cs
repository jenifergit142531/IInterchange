using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Class10
{
    internal class PropertyManagement      
    {

        public string propName;
        public int propPrice;
        public string location;

        public PropertyManagement()
        {
            propName = string.Empty;
            propPrice = 0;
            location = string.Empty;
        }

        public PropertyManagement(string propName, int propPrice, string location)
        {
            this.propName = propName;
            this.propPrice = propPrice;
            this.location = location;
        }
        [CustomAttribute("Vinitha","Insertmodule","Inprogress","10-30-2023")]
        public void InsertPropertyDetails()
        {
            Console.WriteLine("Property added successfully");
        }
        [CustomAttribute("Ragav", "Deletemodule", "completed", "10-27-2023")]
        public void DeleteProperty()
        {
            Console.WriteLine("Property deleted successfully");
        }
        [CustomAttribute("Sakthivel", "Update", "Bug", "10-10-2023")]
        public void UpdateProperty()
        {
            Console.WriteLine("Property updated successfully");
        }
        [CustomAttribute("Tamil", "ViewModule", "Migration.net 4.8 to .net core 3.1", "10-25-2023")]
        public void ShowAllProperty()
        {
            Console.WriteLine("All properties details here");
        }
    }
}
