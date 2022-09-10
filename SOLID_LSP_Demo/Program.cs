
using SOLID_LSP_Demo.Abstract;
using SOLID_LSP_Demo.Implementation;
using SOLID_LSP_Demo.Interface;
using System;
using System.Collections.Generic;

namespace SOLID_LSP_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Get Yearly salary with Bonus. Here Permanent and Temporary are eligible
            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanentEmployee("Fayaz", 50000));
            employees.Add(new TemporaryEmployee("Sadi", 50000));

            foreach (var employee in employees)
            {
                Console.WriteLine("Name: {0} -- Yearly Salary: {1} -- Bonus: {2}", employee.Name,
                    employee.GetYearlySalary().ToString(), employee.CalculateBonnus().ToString());
            }
            #endregion

            #region Get Yearly salary. All type of emplyee eligible here
            List<IEmployee> employeeList = new List<IEmployee>();
            employeeList.Add(new PermanentEmployee("Fayaz", 50000));
            employeeList.Add(new TemporaryEmployee("Sadi", 50000));
            employeeList.Add(new ContractualEmployee("Mahadi", 50000));

            foreach (var employee in employeeList)
            {
                Console.WriteLine("Name: {0} -- Min Salary: {1}", employee.Name, employee.GetYearlySalary().ToString());
            } 
            #endregion
        }
    }
}
