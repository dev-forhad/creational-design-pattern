using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Manager
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetManager(int employeeTypeId)
        {
            IEmployeeManager retrunValue = null;

            if (employeeTypeId == 1)
            {
                retrunValue = new PermanentEmployeeManager();
            }
            else if (employeeTypeId == 2)
            {
                retrunValue = new ContractualEmployeeManager();
            }

            return retrunValue;
        }
    }
}
