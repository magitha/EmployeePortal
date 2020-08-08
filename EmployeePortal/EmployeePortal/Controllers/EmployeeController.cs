using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using EmployeePortalBAL;
using EmployeePortalDAL;

namespace EmployeePortal.Controllers
{
    public class EmployeeController : ApiController
    {
        private IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("api/employee/GetEmployee")]
        public List<Employee> GetEmployees()
        {
            return _service.GetEmployees();
        }
        [AcceptVerbs("POST", "GET")]
        [HttpPost]
        [Route("api/employee/AddEmployee")]
        public void AddEmployee(string name, string designation)
        {
            _service.AddEmployee(name, designation);
        }
    }
}