using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Manager;
using WebApplication.Models;

namespace WebApplication.Factory.FactoryMethod
{
    public class ContractualEmployeeFactory : BaseEmployeeFactory
    {
        public ContractualEmployeeFactory(Employee employee) : base(employee)
        {
        }

        public override IEmployeeManager Create()
        {
            ContractualEmployeeManager manager = new ContractualEmployeeManager();
            _employee.MedicalAllowanc = manager.GetMedicalAllowance();
            return manager;
        }
    }
}
