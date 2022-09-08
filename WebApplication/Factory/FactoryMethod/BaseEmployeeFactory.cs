using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Manager;
using WebApplication.Models;

namespace WebApplication.Factory.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _employee;
        public BaseEmployeeFactory(Employee employee)
        {
            _employee = employee;
        }

        public Employee ApplySalary()
        {
            IEmployeeManager employeeManager = this.Create();
            _employee.Bonus = employeeManager.GetBonus();
            _employee.HourlyPay = employeeManager.GetPay();
            return _employee;
        }

        public abstract IEmployeeManager Create();
    }
}
