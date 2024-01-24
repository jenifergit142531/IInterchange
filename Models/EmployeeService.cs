using EFCore.BulkExtensions;
using Microsoft.VisualBasic;

namespace webapi5.Models
{
    public class EmployeeService
    {
        private readonly EmpContext _context;
        private DateTime Start;
        private TimeSpan timeSpan;
        public EmployeeService(EmpContext empContext)
        {
            _context = empContext;
        }

        //code for inserting 10,000 records
        public async Task<TimeSpan> AddBulkDataAsync()
        {
            List<Employee> employee = new List<Employee>();
            Start = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                employee.Add(new Employee()
                {
                    Name = "Employee_" + i,
                    Designation = "Designation_" + i,
                    Location = "Location_" + i
                });


            }
            await _context.BulkInsertAsync(employee);
            timeSpan = DateTime.Now - Start;
            return timeSpan;
        }

        //code for updating 10,000 records
        public async Task<TimeSpan> UpdateBulkDataAsync()
        {
            List<Employee> employee = new List<Employee>();
            Start = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                employee.Add(new Employee()
                {
                    Id = (i + 1),
                    Name = "Updated_Employee_" + i,
                    Designation = "Updated_Designation_" + i,
                    Location = "Updated_Location_" + i
                });


            }
            await _context.BulkUpdateAsync(employee);
            timeSpan = DateTime.Now - Start;
            return timeSpan;
        }


        //code for deleting 10,000 records
        public async Task<TimeSpan> DeleteBulkDataAsync()
        {
            List<Employee> employee = new List<Employee>();
            Start = DateTime.Now;
            employee = _context.Employees.ToList();
            await _context.BulkDeleteAsync(employee);
            timeSpan = DateTime.Now - Start;
            return timeSpan;

        }
    }
}
