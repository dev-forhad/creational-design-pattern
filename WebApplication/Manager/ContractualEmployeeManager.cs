using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Manager
{
    public class ContractualEmployeeManager : IEmployeeManager
    {
        public double GetBonus()
        {
            return 5;
        }

        public double GetPay()
        {
            return 12;
        }

        public double GetMedicalAllowance()
        {
            return 100;
        }
    }
}
