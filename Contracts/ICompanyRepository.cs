using Webapi7.Models;

namespace Webapi7.Contracts
{
    public interface ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanies();
        public Task<Company> GetCompanyById(int id);

        public Task<Company> GetCompanyAndEmployee(int id);

        public Task<List<Company>> GetCompanyAndEmployeeMappingRelation();

    }
}
