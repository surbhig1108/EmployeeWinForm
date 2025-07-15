using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace sur_Employee
{
    public partial class FRM_Employee : Form
    {
        long EmployeeId = 0;
        int Mode=1;
        public FRM_Employee()
        {
            InitializeComponent();
            DTP_EmpDOJ.CustomFormat = "dd/MM/yyyy";
            DTP_EmpDOB.CustomFormat = "dd/MM/yyyy";
        }

        public bool ValidatationofData()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TB_EmpName.Text))
                {
                    TB_EmpName.Focus();
                    MessageBox.Show("name should not be empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (string.IsNullOrWhiteSpace(TB_EmpDepartment.Text))
                {
                    TB_EmpName.Focus();
                    MessageBox.Show("department should not be empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (CMB_EmpCity.SelectedIndex<0)
                {
                    CMB_EmpCity.Focus();
                    MessageBox.Show("city should not be empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                string mob = TE_EmpMobile.Text.Trim();
                if (string.IsNullOrWhiteSpace(TE_EmpMobile.Text))
                {
                    MessageBox.Show("mobile should not be empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (mob.Length != 10)
                {
                    MessageBox.Show("mobile number lenght should be 10 digits", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (string.IsNullOrWhiteSpace(TE_EmpSalary.Text))
                {
                    MessageBox.Show("salary should not be empty", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public void ResetData()
        {
            TB_EmpName.Text = string.Empty;
            TB_EmpDepartment.Text = string.Empty;
            TB_EmpDesignation.Text = string.Empty;
            TE_EmpSalary.Text = string.Empty;
            TE_EmpMobile.Text = string.Empty;
            DTP_EmpDOB.Value = DateTime.Now;
            DTP_EmpDOJ.Value = DateTime.Now;
            CMB_EmpCity.SelectedIndex = -1;
            CMB_EmpCity.Text = "<SELECT CITY>";
            EmployeeId = 0;
        }

        public void EnabledData(bool flag)
        {
            TE_EmpMobile.Enabled = flag;
            TB_EmpDepartment.Enabled = flag;
            TB_EmpDesignation.Enabled = flag;
            TE_EmpSalary.Enabled = flag;
            DTP_EmpDOB.Enabled =   flag;
            DTP_EmpDOJ.Enabled =   flag;
            TB_EmpName.Enabled = flag;
            CMB_EmpCity.Enabled = flag;
        }

        public void OperationData(int Mode)
        {
            try
            {
                        EmployeeVO empVO = new EmployeeVO();
                        empVO.EmployeeName = TB_EmpName.Text;
                        empVO.EmployeeDOB = DTP_EmpDOB.Value;
                        empVO.EmployeeId = EmployeeId;
                        empVO.EmployeeDOJ = DTP_EmpDOJ.Value;
                        empVO.Mode = Mode;
                        empVO.EmployeeDepartment = TB_EmpDepartment.Text;
                        empVO.EmployeeDesignation = TB_EmpDesignation.Text;
                        empVO.EmployeeSalary = decimal.Parse(TE_EmpSalary.Text);
                        empVO.EmployeeCity = CMB_EmpCity.SelectedItem.ToString();
                        empVO.EmployeeMobile = long.Parse(TE_EmpMobile.Text);
                        EmployeeBO empbo = new EmployeeBO();
                       empbo.OperationEmployee(empVO);
                        GetEmployeeData();
                        GR_Employee.Refresh();
            }
            catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                        throw new Exception() ;
                    }
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            try
            {
                 if (ValidatationofData())
            {
                OperationData(Mode);
                MessageBox.Show("data saved");         
            }
            }
            catch (Exception ex )
            {
                
              MessageBox.Show(ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            } 
        }
        public void GetEmployeeData()
        {
            try
            {
                List<EmployeeVO> lstEmployees = new List<EmployeeVO>() { };
                EmployeeBO empbo = new EmployeeBO();
                empbo.GetEmployee(lstEmployees);
                GR_Employee.DataSource = lstEmployees;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void BTN_Showdetail_Click(object sender, EventArgs e)
        {
            try
            {
                GetEmployeeData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GR_Employee_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Mode = 2;
                TB_EmpName.Text = Convert.ToString(GV_Employee.GetFocusedRowCellValue("EmployeeName"));
                TB_EmpDepartment.Text = Convert.ToString(GV_Employee.GetFocusedRowCellValue("EmployeeDepartment"));
                TB_EmpDesignation.Text = Convert.ToString(GV_Employee.GetFocusedRowCellValue("EmployeeDesignation"));
                TE_EmpSalary.Text = Convert.ToString(GV_Employee.GetFocusedRowCellValue("EmployeeSalary"));
                DTP_EmpDOB.Value = Convert.ToDateTime(GV_Employee.GetFocusedRowCellValue("EmployeeDOB"));
                DTP_EmpDOJ.Value = Convert.ToDateTime(GV_Employee.GetFocusedRowCellValue("EmployeeDOJ"));
                TE_EmpMobile.Text = Convert.ToString(GV_Employee.GetFocusedRowCellValue("EmployeeMobile"));
                CMB_EmpCity.SelectedItem = Convert.ToString(GV_Employee.GetFocusedRowCellValue("EmployeeCity"));
                EmployeeId = Convert.ToInt64(GV_Employee.GetFocusedRowCellValue("EmployeeId"));
                EnabledData(false);
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            } 
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            if (Mode == 2)
            {
                EnabledData(true);
            }
            else
            {
                MessageBox.Show("you can edit after selecting data from show details option", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Mode = 3;
                OperationData(Mode);
                ResetData();
                MessageBox.Show("data delete");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_New_Click(object sender, EventArgs e)
        {
            try
            {
                Mode = 1;
                ResetData();
                EnabledData(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }

        private void TE_EmpSalary_Properties_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == '-');
        }

        private void TE_EmpMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == '-');
        }

        private void TE_EmpMobile_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
