using CQRS_Pattern.Dto_s;
using CQRS_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Pattern.Queries
{
    public interface IEmployeeQueries
    {
        EmployeeDTO FindById(int id);
    }
}
