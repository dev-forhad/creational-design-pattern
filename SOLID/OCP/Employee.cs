using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Employee(string name, decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
        public abstract decimal CalculateBonus();
    }
    public class PermanentEmplpoyee : Employee
    {
        public PermanentEmplpoyee(string name, decimal salary) : base(name, salary) {}
        public override decimal CalculateBonus()
        {
            return  this.Salary * .1M;
        }
    }

    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee(string name, decimal salary) : base(name, salary) {}
        public override decimal CalculateBonus()
        {
            return this.Salary * .05M;
        }
    }    


}
