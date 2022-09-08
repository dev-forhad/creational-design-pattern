using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Factory.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee employee)
        {
            BaseEmployeeFactory returnVal = null;
            if (employee.EmployeeTypeId == 1){
                returnVal = new PermanentEmployeeFactory(employee);
            }
            else if (employee.EmployeeTypeId == 2)
            {
                returnVal = new ContractualEmployeeFactory(employee);
            }

            return returnVal;
        }
    }
}
