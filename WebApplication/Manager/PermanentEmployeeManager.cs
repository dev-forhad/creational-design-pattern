using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Manager
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public double GetBonus()
        {
            return 10;
        }

        public double GetPay()
        {
            return 8;
        }

        public double GetHouseAllowance()
        {
            return 150;
        }
    }
}
