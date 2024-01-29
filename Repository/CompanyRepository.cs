using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Data;
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
            using (var multiresult = await connection.QueryMultipleAsync(query, new { id }))
            {
                var company = await multiresult.ReadSingleOrDefaultAsync<Company>();
                if (company != null)
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

        //Mapping multiple tables with relationship

        public async Task<List<Company>> GetCompanyAndEmployeeMappingRelation()
        {
            var query = "select * from companies c JOIN employees e on c.Id=e.CompanyId";
            using (var connection = _context.CreateConnection())
            {
                var companyDict = new Dictionary<int, Company>();
                var companies = await connection.QueryAsync<Company, Employee, Company>(
                    query, (company, employee) =>
                    {
                        if (!companyDict.TryGetValue(company.Id, out var currentCompany))
                        {
                            currentCompany = company;
                            companyDict.Add(currentCompany.Id, currentCompany);
                        }
                        currentCompany.Employees.Add(employee);
                        return currentCompany;
                    });
                return companies.Distinct().ToList();


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


        //Using stored procedures on dapper
        public async Task<Company> GetEmployeeAndCompanySP(int id)
        {
            var procedureName = "usp_select";
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32, ParameterDirection.Input);

            using (var connection = _context.CreateConnection())
            {
                var company = await connection.QueryFirstOrDefaultAsync<Company>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;

            }
        }
    }

       
}
