using CQRS_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Pattern.Repositories
{
    public class EmployeeQueriesRepository : IEmployeeQueriesRepository
    {
        public Employee getById(int id)
        {
            return new Employee()
            {
                Id = 100,
                Name = "satya",
                FirstName = "satyajit",
                LastName = "Das",
                Address = "New market"
            };
        }
    }
}
