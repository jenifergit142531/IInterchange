using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Class10
{
    [AttributeUsage(AttributeTargets.All)]
    internal class CustomAttribute : Attribute
    {
        private string developerName;
        private string action;
        private string status;
        private string lastUpdatedDate;

        public CustomAttribute(string developerName, string action, string status, string lastUpdatedDate)
        {
            this.developerName = developerName;
            this.action = action;
            this.status = status;
            this.lastUpdatedDate = lastUpdatedDate;
        }

        public string DeveloperName
        {
            get
            {
                return developerName;
            }
        }
        public string Action
        {
            get
            {
                return action;
            }
        }
        public string Status
        {
            get
            {
                return status;
            }
        }

        public string LastUpdatedDate
        {
            get
            {
                return lastUpdatedDate;
            }
        }

    }

   
}
