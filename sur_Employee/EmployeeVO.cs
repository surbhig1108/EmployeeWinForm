using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sur_Employee
{
    public class EmployeeVO
    {
        public int Mode { get; set; }
        public int SerialNumber { get; set; }
        public long EmployeeId { get; set; }
        [Key]
        public string EmployeeName { get; set; }
        public DateTime EmployeeDOB { get; set; }
        public DateTime EmployeeDOJ { get; set; }
        public string EmployeeDepartment { get; set; }
        public long EmployeeMobile { get; set; }
        public string EmployeeDesignation { get; set; }
        public decimal EmployeeSalary { get; set; }
        public string EmployeeCity { get; set; }

        public EmployeeVO()
        {
            Mode = 0;
            SerialNumber = 0;
            EmployeeId = 0;
            EmployeeName = string.Empty;
            EmployeeDOB = new DateTime(1900, 01, 01);
            EmployeeDOJ = new DateTime(1900, 01, 01);
            EmployeeMobile = 0;
            EmployeeDepartment = string.Empty;
            EmployeeDesignation = string.Empty;
            EmployeeSalary = 0;
            EmployeeCity = string.Empty;
        }
    }
}
