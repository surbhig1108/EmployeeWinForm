using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sur_Employee
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Database.SetInitializer(new CreateDatabaseIfNotExists<TrainingDbContext>());

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FRM_Employee());
        }
    }
}
