using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_LSP_Demo.Interface
{
    interface IEmployee
    {
        string Name { get; set; }
        decimal Salary { get; set; }
        decimal GetYearlySalary();
    }
}
