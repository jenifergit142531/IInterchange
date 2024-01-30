using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webapi7.Contracts;
using Webapi7.Models;

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


        [HttpGet("GetbySP/{id}")]
        public async Task<IActionResult> GetEmployeeByCompanySP(int id)
        {

            try
            {
                var companies = await _companyRepository.GetEmployeeAndCompanySP(id);
                return Ok(companies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteCompany(int id)
        {

            try
            {
                var companies = await _companyRepository.GetCompanyById(id);
                if (companies == null)
                    return NotFound();
                await _companyRepository.DeleteCompany(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]

        public async Task<IActionResult>UpdateCompany(int id,Company company)
        {

            try
            {
                var companies = await _companyRepository.GetCompanyById(id);
                if (companies == null)
                    return NotFound();
                await _companyRepository.UpdateCompany(id, company);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> GetEmployeeByCompanyMapping(Company company)
        {

            try
            {
                var companies = await _companyRepository.AddCompany(company);
                return Ok(companies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
