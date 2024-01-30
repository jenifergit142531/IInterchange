using Webapi7.Models;

namespace Webapi7.Contracts
{
    public interface ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanies();
        public Task<Company> GetCompanyById(int id);

        public Task<Company> GetCompanyAndEmployee(int id);

        public Task<List<Company>> GetCompanyAndEmployeeMappingRelation();

        public Task<Company> GetEmployeeAndCompanySP(int id);

        public Task DeleteCompany(int id);

        public Task UpdateCompany(int id, Company company);

        public Task<Company> AddCompany(Company company);

        public Task AddMultipleCompanies(List<Company> company);

        

    }
}
