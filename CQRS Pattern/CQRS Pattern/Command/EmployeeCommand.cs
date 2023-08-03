using CQRS_Pattern.Models;
using CQRS_Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Pattern.Command
{
    public class EmployeeCommand : IEmployeeCommand
    {
        private readonly EmployeeCommandRepository _employee;
        public EmployeeCommand(EmployeeCommandRepository employee)
        {
            _employee = employee;
        }

        public void saveEmployees(Employee employee)
        {
        }

    }
}
