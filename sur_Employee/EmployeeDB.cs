using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sur_Employee
{
    public  class EmployeeDB
    {

        public void SaveEmployee(EmployeeVO emp, string mode)
        {
            try
            {

            
            using (var context = new TrainingDbContext())
            {
                switch (mode.ToLower())
                {
                    case "insert":
                        long maxId = context.Employees.Any() ? context.Employees.Max(e => e.EmployeeId) : 0;
                        emp.EmployeeId = maxId+1;
                        context.Employees.Add(emp);
                        break;

                    case "update":
                        context.Entry(emp).State = EntityState.Modified;
                        break;

                    case "delete":
                        var empToDelete = context.Employees.Find(emp.EmployeeName);
                        if (empToDelete != null)
                            context.Employees.Remove(empToDelete);
                        break;

                    default:
                        throw new ArgumentException("Invalid mode");
                }

                context.SaveChanges();
            }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
