using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sur_Employee
{
    public class TrainingDbContext : DbContext
    {
        public TrainingDbContext()
            : base("name=TrainingDbConnection") { }

        public DbSet<EmployeeVO> Employees { get; set; }
    }
}
