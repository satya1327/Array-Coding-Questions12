using CQRS_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Pattern.Repositories
{
    public class EmployeeCommandRepository : IEmployeeCommandRepository
    {
        public void saveEmployee(Employee employee)
        {
            Console.WriteLine($"Data saved SuccessFully");
        }
    }
}
