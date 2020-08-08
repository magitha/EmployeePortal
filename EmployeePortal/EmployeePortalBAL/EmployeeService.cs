
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeePortalDAL;

namespace EmployeePortalBAL
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public List<Employee> GetEmployees()
        {
            return _employeeRepository.GetEmployees();
        }

        public void AddEmployee(string name, string designation)
        {
            _employeeRepository.AddEmployee(name, designation);
        }
    }
}
