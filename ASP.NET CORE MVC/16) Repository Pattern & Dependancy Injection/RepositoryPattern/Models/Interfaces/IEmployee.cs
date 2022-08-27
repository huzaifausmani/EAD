using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Models.Interfaces
{
    public interface IEmployee
    {
        public List<Employee> GetAllEmployee();
    }
}