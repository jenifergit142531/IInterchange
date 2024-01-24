using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi5.Models;

namespace webapi5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BulkController : ControllerBase
    {
        private readonly EmployeeService _employeeService;
        public BulkController(EmployeeService _employeeService)
        {
            _employeeService = _employeeService;
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddBulkData()
        {
            var response = await _employeeService.AddBulkDataAsync();
            return Ok(response);
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateBulkData()
        {
            var response = await _employeeService.UpdateBulkDataAsync();
            return Ok(response);
        }
        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteBulkData()
        {
            var response = await _employeeService.DeleteBulkDataAsync();
            return Ok(response);
        }
    }
}
