using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortalDAL
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();

        void AddEmployee( string name, string designation);
    }
}
