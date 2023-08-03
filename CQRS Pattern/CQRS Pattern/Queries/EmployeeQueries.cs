using CQRS_Pattern.Dto_s;
using CQRS_Pattern.Models;
using CQRS_Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Pattern.Queries
{
    public class EmployeeQueries : IEmployeeQueries
    {
        private readonly EmployeeQueriesRepository _emp;
        public EmployeeQueries(EmployeeQueriesRepository emp)
        {
            _emp = emp;
        }
        public EmployeeDTO FindById(int id)
        {
            var emp=_emp.getById(id);
            return new EmployeeDTO
            {
                Id = emp.Id,
                FullName = emp.FirstName + " " + emp.LastName,
                address = emp.Address
            };
        }
    }
}
