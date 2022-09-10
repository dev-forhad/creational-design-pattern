using SOLID_LSP_Demo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_LSP_Demo.Implementation
{
    class PermanentEmployee : Employee
    {
        public PermanentEmployee(string name, decimal salary) : base(name, salary) {}
        public override decimal CalculateBonnus()
        {
            return this.Salary*.1M;
        }
        public override decimal GetYearlySalary()
        {
            return this.Salary*12;
        }
    }
}
