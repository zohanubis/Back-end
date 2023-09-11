using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Lesson4.Models;

namespace Lesson4.Models
{
    public class ConnectEmployee
    {
        public string conStr = "Data Source=ZOHANUBIS;Initial Catalog=QL_NhanSu;Integrated Security=True";
        public List<Employee> getData()
        {
            List<Employee> listEmployees = new List<Employee>();
            SqlConnection con = new SqlConnection(conStr);
            string sql = "SELECT * FROM tbl_Employee";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Employee emp = new Employee();
                emp.ID = Convert.ToInt32(rdr.GetValue(0).ToString());
                emp.Name = rdr.GetValue(1).ToString();
                emp.Gender = rdr.GetValue(2).ToString();
                emp.City = rdr.GetValue(3).ToString();
                listEmployees.Add(emp);
            }
            return (listEmployees);

        }
        public int getSL()
        {
            SqlConnection con = new SqlConnection(conStr);
            string sql = "SELECT COUNT(*) FROM tbl_Employee";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            int sl = (int)cmd.ExecuteScalar();
            con.Close();
            return sl;
        }
    }

}