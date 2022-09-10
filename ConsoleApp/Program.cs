using SOLID.OCP;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Open Close Principle
            Employee employee1 = new PermanentEmplpoyee("Fayaz", 50000);
            Console.WriteLine("Employee: {0} Bonus: {1}", employee1.Name, employee1.CalculateBonus().ToString());

            Employee employee2 = new TemporaryEmployee("Sadi", 50000);
            Console.WriteLine("Employee: {0} Bonus: {1}", employee2.Name, employee2.CalculateBonus().ToString());
            #endregion


            
        }
    }
}
