using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeePortal;
using EmployeePortalBAL;
using Moq;
using NUnit.Framework;

namespace EmployeePortal.Test
{
    [TestFixture]
    public class EmployeeTest
    {
        Mock<IEmployeeService> mockObject = new Mock<IEmployeeService>();
        

        [Test]
        public void GetEmployeeDetails()
        {

         

        }
    }
}
