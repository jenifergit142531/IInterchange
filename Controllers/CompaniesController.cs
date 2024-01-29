using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webapi7.Contracts;

namespace Webapi7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;
        public CompaniesController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {

            try
            {
                var companies = await _companyRepository.GetCompanies();
                return Ok(companies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompanies(int id)
        {

            try
            {
                var companies = await _companyRepository.GetCompanyById(id);
                return Ok(companies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("Multiresult/{id}")]

        public async Task<IActionResult> GetEmployeeByCompany(int id)
        {

            try
            {
                var companies = await _companyRepository.GetCompanyAndEmployee(id);
                return Ok(companies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("MultipleMapping")]
        public async Task<IActionResult> GetEmployeeByCompanyMapping()
        {

            try
            {
                var companies = await _companyRepository.GetCompanyAndEmployeeMappingRelation();
                return Ok(companies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    

    }
}
