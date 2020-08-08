using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortalDAL
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> data = new List<Employee>();
            using (var db = new EmployeePortalEntities())
            {
               data = (from b in db.Employees  select b).ToList();
            }
            return data;
        }

        public void AddEmployee(string name, string designation)
        {
            using (var db = new EmployeePortalEntities())
            {
                var employees = db.Set<Employee>();
                employees.Add(new Employee { Designation= designation, Name = name});

                db.SaveChanges();
            }
        }
    }
}
