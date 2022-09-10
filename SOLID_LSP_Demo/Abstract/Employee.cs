using SOLID_LSP_Demo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_LSP_Demo.Abstract
{
    public abstract class Employee : IEmployee, IEmployeeBonus
    {
        public Employee(string name, decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public abstract decimal CalculateBonnus();

        public abstract decimal GetYearlySalary();
    }
}
