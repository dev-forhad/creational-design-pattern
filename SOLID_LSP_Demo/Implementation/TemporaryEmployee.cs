using SOLID_LSP_Demo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_LSP_Demo.Implementation
{
    class TemporaryEmployee : Employee
    {
        public TemporaryEmployee(string name, decimal salary) : base(name, salary) {}
        public override decimal CalculateBonnus()
        {
            return this.Salary*.05M;
        }
        public override decimal GetYearlySalary()
        {
            return this.Salary*12;
        }
    }
}
