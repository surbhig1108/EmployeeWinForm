using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sur_Employee
{
    class EmployeeBO
    {

        public void OperationEmployee(EmployeeVO empvo)
        {
            try
            {
                //EmployeeDAO empDAO = new EmployeeDAO();
                //empDAO.OperationEmployee(empvo);
                EmployeeDB employeeDB = new EmployeeDB();
                employeeDB.SaveEmployee(empvo, "insert");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void GetEmployee(List<EmployeeVO> lstEmployees)
        {
            try
            {
                EmployeeDAO empDAO = new EmployeeDAO();
                empDAO.GetEmployee(lstEmployees);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }
    }
}
