using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryPattern.Models.Interfaces;

namespace RepositoryPattern.Models.Repositories
{
    public class EmployeeRepository: IEmployee
    {
        public List<Employee> GetAllEmployee()
        {
            var employees = new List<Employee>()
            {
                new Employee()
                {
                    ID = 1,
                    Name = "Ali"
                },
                new Employee()
                {
                    ID = 2,
                    Name = "Hassan"
                },
                new Employee()
                {
                    ID = 3,
                    Name = "Hussain"
                }
            };
            return employees;
        }
    }
}