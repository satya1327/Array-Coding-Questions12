using CQRS_Pattern.Command;
using CQRS_Pattern.Queries;
using System;

namespace CQRS_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeCommand = new EmployeeCommand(new Repositories.EmployeeCommandRepository());
            employeeCommand.saveEmployees(new Models.Employee()
            {
                Id = 1,
                FirstName = "satya",
                LastName = "das",
                Address = "new market",
                Name = "satyajit"
            });
            Console.WriteLine("Employee Data is stored");
            var employeeQuery=new EmployeeQueries(new Repositories.EmployeeQueriesRepository());
            var empQue=employeeQuery.FindById(100);
            Console.WriteLine($"id is {empQue.Id} , Name is {empQue.FullName}, address is {empQue.address}");
        }
    }
}
