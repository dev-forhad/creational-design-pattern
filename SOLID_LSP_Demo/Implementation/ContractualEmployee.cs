using SOLID_LSP_Demo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_LSP_Demo.Implementation
{
    public class ContractualEmployee : IEmployee
    {
        public ContractualEmployee(string name, decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public decimal GetYearlySalary()
        {
            return this.Salary * 12;
        }
    }
}
