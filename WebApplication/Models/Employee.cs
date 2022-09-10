using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobDescriptiom { get; set; }
        public string Number { get; set; }
        #region This two field vary on Employee Type
        public double HourlyPay { get; set; }
        public double Bonus { get; set; }
        #endregion
        //Only applicable for Permanent Employee
        public double? HouseAllowanc { get; set; }

        //Only applicable for Contractual Employee
        public double? MedicalAllowanc { get; set; }

        public int EmployeeTypeId { get; set; }
        public string ComputerDetails { get; set; }
        [ForeignKey("EmployeeTypeId")]
        public virtual EmployeeType EmployeeType { get; set; }
    }
}
