
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeePortalDAL;

namespace EmployeePortalBAL
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();

        void AddEmployee(string name, string designation);
     }
}
