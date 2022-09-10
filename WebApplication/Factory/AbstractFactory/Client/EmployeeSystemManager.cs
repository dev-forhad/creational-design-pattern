using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Factory.AbstractFactory
{
    public class EmployeeSystemManager
    {
        IComputerFactory _computerFactory;
        public EmployeeSystemManager(IComputerFactory computerFactory)
        {
            _computerFactory = computerFactory;
        }


        public string GetSystemDetails()
        {
            IBrand brand = _computerFactory.Brand();
            IProcessor processor = _computerFactory.Processor();
            ISystemType system = _computerFactory.SystemType();
            string returnValue = String.Format("{0} {1} {2}", brand.GetBrand(),
                system.GetSystemType(), processor.GetProcessor());

            return returnValue;
        }
    }
}
