using Dapper;
using Microsoft.AspNetCore.Mvc;
using Webapi7.Context;
using Webapi7.Contracts;
using Webapi7.Models;

namespace Webapi7.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DapperContext _context;
        public CompanyRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Company>> GetCompanies()
        {
            var query = "select * from companies";
            using (var connection = _context.CreateConnection())
            {
                var companies = await connection.QueryAsync<Company>(query);
                return companies.ToList();
            }
        }

        //multiple result set
      
        public async Task<Company> GetCompanyAndEmployee(int id)
        {
            var query = "select * from companies where Id=@Id;" +
                "select * from employees where CompanyId=@Id";
            using (var connection = _context.CreateConnection())
                using(var multiresult=await connection.QueryMultipleAsync(query, new {id}))
            {
                var company = await multiresult.ReadSingleOrDefaultAsync<Company>();
                if(company!=null)
                {
                    company.Employees = (await multiresult.ReadAsync<Employee>()).ToList();
                    return company;
                }
                else
                {
                    return null;
                }
            }
        }


        //parameterised query using dapper
        public async Task<Company> GetCompanyById(int id)
        {
            var query = "select * from companies where id=@id";
            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<Company>(query, new { id });
                return company;
            }
        }
    }
}
