using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
namespace sur_Employee
{
    class EmployeeDAO
    {  
       const string  strcon = @"Data Source=PMSPL-SERVER;Initial Catalog=Training;User ID=dvuser1;password=whatanidea@123";
        SqlConnection con = new SqlConnection(strcon);
        public void OperationEmployee(EmployeeVO empVO)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Opertion_Employee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mode", empVO.Mode);
                cmd.Parameters.AddWithValue("@EmployeeID", empVO.EmployeeId);
                cmd.Parameters.AddWithValue("@EmployeeName", empVO.EmployeeName);
                cmd.Parameters.AddWithValue("@EmployeeDOB", empVO.EmployeeDOB);
                cmd.Parameters.AddWithValue("@EmployeeDOJ", empVO.EmployeeDOJ);
                cmd.Parameters.AddWithValue("@EmployeeDepartment", empVO.EmployeeDepartment);
                cmd.Parameters.AddWithValue("@EmployeeMobile", empVO.EmployeeMobile);
                cmd.Parameters.AddWithValue("@EmployeeDesignation", empVO.EmployeeDesignation);
                cmd.Parameters.AddWithValue("@EmployeeSalary", empVO.EmployeeSalary);
                cmd.Parameters.AddWithValue("@EmployeeCity", empVO.EmployeeCity);
                con.Open();
                if (cmd.ExecuteNonQuery() == 0)
                {
                    throw new Exception("unable to save data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public void GetEmployee(List<EmployeeVO> lstEmployees)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select EmployeeID,EmployeeName,EmployeeDOB,EmployeeDOJ,EmployeeDepartment,EmployeeDesignation,EmployeeMobile,EmployeeCity,EmployeeSalary from TblEmployee1", con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i == 0)
                {
                    MessageBox.Show("unable to save data");
                }
                SqlDataReader reader = cmd.ExecuteReader();
                int count = 1;
                while(reader.Read())
                {
                    EmployeeVO empVO = new EmployeeVO();
                    empVO.SerialNumber = count++;
                    empVO.EmployeeId = Convert.ToInt64(reader["EmployeeID"]);
                    empVO.EmployeeName = reader["EmployeeName"] == DBNull.Value ? string.Empty : Convert.ToString(reader["EmployeeName"]);
                    empVO.EmployeeDOB = reader["EmployeeDOB"] == DBNull.Value ? new DateTime(1900,01,01) : Convert.ToDateTime(reader["EmployeeDOB"]);
                    empVO.EmployeeDOJ = reader["EmployeeDOJ"] == DBNull.Value ? new DateTime(1900, 01, 01) : Convert.ToDateTime(reader["EmployeeDOJ"]);
                    empVO.EmployeeDepartment =reader["EmployeeDepartment"]== DBNull.Value ?string.Empty: Convert.ToString(reader["EmployeeDepartment"]);
                    empVO.EmployeeDesignation = reader["EmployeeDesignation"] == DBNull.Value ? string.Empty : Convert.ToString(reader["EmployeeDesignation"]);
                    empVO.EmployeeMobile = reader["EmployeeMobile"] == DBNull.Value ? 0 : Convert.ToInt64(reader["EmployeeMobile"]);
                    empVO.EmployeeSalary = reader["EmployeeSalary"] == DBNull.Value ? 0 : Convert.ToInt64(reader["EmployeeSalary"]);
                    empVO.EmployeeCity =reader["EmployeeCity"]== DBNull.Value ?string.Empty: Convert.ToString(reader["EmployeeCity"]);
                    lstEmployees.Add(empVO);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                throw new Exception();
            }
            finally
            {
                con.Close();
            }
        }
    }
}